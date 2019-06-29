import pygame
pygame.init()

screenWidth = 500
screenHeight = 480
win=pygame.display.set_mode((screenWidth, screenHeight)) #sets display window (x,y)

pygame.display.set_caption("First Game")

walkRight = [pygame.image.load('img/R1.png'), pygame.image.load('img/R2.png'), pygame.image.load('img/R3.png'), pygame.image.load('img/R4.png'), pygame.image.load('img/R5.png'), pygame.image.load('img/R6.png'), pygame.image.load('img/R7.png'), pygame.image.load('img/R8.png'), pygame.image.load('img/R9.png')]
walkLeft = [pygame.image.load('img/L1.png'), pygame.image.load('img/L2.png'), pygame.image.load('img/L3.png'), pygame.image.load('img/L4.png'), pygame.image.load('img/L5.png'), pygame.image.load('img/L6.png'), pygame.image.load('img/L7.png'), pygame.image.load('img/L8.png'), pygame.image.load('img/L9.png')]
bg = pygame.image.load('img/bg.jpg')
char = pygame.image.load('img/standing.png')

clock = pygame.time.Clock()

bulletSound = pygame.mixer.Sound('bullet.wav')
hitSound = pygame.mixer.Sound('hit.wav')
music = pygame.mixer.music.load('music.mp3')
pygame.mixer.music.play(-1)
score = 0

class player(object):
    def __init__(self,x,y,width,height):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.vel = 5
        self.isJump = False
        self.left = False
        self.right = False
        self.walkCount = 0
        self.jumpCount = 10
        self.standing = True
        self.hitbox = (self.x + 17, self.y+11, 29, 52)

    def draw(self,win):
        if self.walkCount + 1 >= 27:
            self.walkCount=0

        if not(self.standing):
            if self.left:
                win.blit(walkLeft[self.walkCount //3], (self.x,self.y))
                self.walkCount += 1
            elif self.right:
                win.blit(walkRight[self.walkCount //3], (self.x,self.y))
                self.walkCount += 1
        else:
            if self.right:
                win.blit(walkRight[0], (self.x,self.y))
            else:
                win.blit(walkLeft[0], (self.x,self.y))
        self.hitbox = (self.x + 17, self.y+11, 29, 52)
        # pygame.draw.rect(win, (255, 0, 0), self.hitbox, 2)
    def hit(self):
        self.isJump = False
        self.jumpCount = 10
        self.x = 60
        self.y = 410
        self.walkCount = 0
        font1 = pygame.font.SysFont('comicsans', 100)
        text = font1.render('-5',1,(255,0,0))
        win.blit(text,(screenWidth/2 -(text.get_width()/2), 125))
        pygame.display.update()
        i = 0 
        while i < 300:
            pygame.time.delay(10)
            i+=1
            for event in pygame.event.get():
                if event.type == pygame.QUIT():
                    i=301
                    pygame.quit()

class projectile(object):
    def __init__(self,x,y,radius,color,facing):
        self.x = x
        self.y = y
        self.radius = radius
        self.color = color
        self.facing = facing
        self.vel = 8*facing
    
    def draw(self,win):
        pygame.draw.circle(win, self.color, (self.x,self.y),self.radius)

class enemy(object):
    walkRight = [pygame.image.load('img/R1E.png'), pygame.image.load('img/R2E.png'), pygame.image.load('img/R3E.png'), pygame.image.load('img/R4E.png'), pygame.image.load('img/R5E.png'), pygame.image.load('img/R6E.png'), pygame.image.load('img/R7E.png'), pygame.image.load('img/R8E.png'), pygame.image.load('img/R9E.png'), pygame.image.load('img/R10E.png'), pygame.image.load('img/R11E.png')]
    walkLeft = [pygame.image.load('img/L1E.png'), pygame.image.load('img/L2E.png'), pygame.image.load('img/L3E.png'), pygame.image.load('img/L4E.png'), pygame.image.load('img/L5E.png'), pygame.image.load('img/L6E.png'), pygame.image.load('img/L7E.png'), pygame.image.load('img/L8E.png'), pygame.image.load('img/L9E.png'), pygame.image.load('img/L10E.png'), pygame.image.load('img/L11E.png')]

    def __init__(self, x, y, width, height, end):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.end = end
        self.path =[self.x, self.end]
        self.walkCount = 0
        self.vel = 3
        self.hitbox = (self.x + 17, self.y +2, 31, 57)
        self.health = 9
        self.visible = True

    def draw(self,win):
        self.move()
        if self.visible:
            if self.walkCount + 1 >= 33:
                self.walkCount = 0
            if self.vel > 0:
                win.blit(self.walkRight[self.walkCount //3], (self.x, self.y))
                self.walkCount+=1
            else:
                win.blit(self.walkLeft[self.walkCount //3], (self.x, self.y))
                self.walkCount+=1
            self.hitbox = (self.x + 17, self.y +2, 31, 57)
            # pygame.draw.rect(win, (255,0,0), self.hitbox, 2)
            pygame.draw.rect(win, (255,0,0), (self.hitbox[0], self.hitbox[1] - 20, 50, 10))
            pygame.draw.rect(win, (0,128,0), (self.hitbox[0], self.hitbox[1] - 20, 50 - (5 * (9- self.health)), 10))
    def move(self):
        if self.vel > 0:
            if self.x + self.vel < self.path[1]:
                self.x += self.vel
            else:
                self.vel = self.vel * -1
                self.walkCount=0
        else:
            if self.x - self.vel > self.path[0]:
                self.x += self.vel
            else:
                self.vel = self.vel * -1
                self.walkCount=0

    def hit(self):
        if self.health > 0:
            self.health -= 1
        else:
            self.visible = False
        print("hit")

def redrawGameWindow():
    win.blit(bg, (0,0))
    text = font.render('Score: ' + str(score), 1, (0,0,0))
    win.blit(text, (370, 10))
    man.draw(win)
    orc.draw(win)
    for bullet in bullets:
        bullet.draw(win)
 
    pygame.display.update()

#mainloop - actual game starts here
font = pygame.font.SysFont('comicsans', 30, True) #(font, size, bold, _italics_)
man = player(60, 410, 64, 64)
orc = enemy(100, 415, 64, 64, 450)
shootLoop = 0
bullets = []

run = True 

while run:
    clock.tick(27) #creates time-delay for clock in ms
    if orc.visible == True:
        if man.hitbox[1] < orc.hitbox[1] + orc.hitbox[3] and man.hitbox[1] + man.hitbox[3] > orc.hitbox[1]:
            if man.hitbox[0] + man.hitbox[2] > orc.hitbox[0] and man.hitbox[0] < orc.hitbox[0] + orc.hitbox[2]:
                man.hit()
                score -= 5

    if shootLoop >0:
        shootLoop +=1
    if shootLoop >3:
        shootLoop = 0

    for event in pygame.event.get():  #this ends the game if X is clicked
        if event.type == pygame.QUIT:
            run=False

    for bullet in bullets:
        if bullet.y - bullet.radius < orc.hitbox[1] + orc.hitbox[3] and bullet.y + bullet.radius > orc.hitbox[1]:
            if bullet.x + bullet.radius > orc.hitbox[0] and bullet.x - bullet.radius < orc.hitbox[0] + orc.hitbox[2]:
                hitSound.play()
                orc.hit()
                score += 1
                bullets.pop(bullets.index(bullet))


        if bullet.x < 500 and bullet.x > 0:
            bullet.x += bullet.vel
        else:
            bullets.pop(bullets.index(bullet))


    keys = pygame.key.get_pressed()

    if keys[pygame.K_f] and shootLoop == 0:
        bulletSound.play()
        facing = -1
        if man.left:
            facing = -1
        if man.right:
            facing = 1
        if len(bullets) < 10:
            bullets.append(projectile(round(man.x + man.width //2), round(man.y + man.height //2), 6, (0,0,0), facing))
        shootLoop = 1
    if (keys[pygame.K_LEFT] or keys[pygame.K_a]) and man.x > man.vel:
        man.x-=man.vel
        man.left = True
        man.right = False
        man.standing = False
        
    elif (keys[pygame.K_RIGHT] or keys[pygame.K_d]) and man.x < (screenWidth - man.width - man.vel):
        man.x+=man.vel
        man.left = False
        man.right = True
        man.standing = False
    else:
        man.standing = True
        man.walkCount = 0 
    if not(man.isJump):
        if keys[pygame.K_SPACE]:
            man.isJump = True
            man.walkCount = 0
    else:
        if man.jumpCount >= -10:
            neg = 1
            if man.jumpCount <0:
                neg = -1
            man.y -= (man.jumpCount ** 2) * 0.325 * neg *(.85)
            man.jumpCount -= 1
        else:
            man.isJump = False
            man.jumpCount = 10

    redrawGameWindow()
pygame.quit()