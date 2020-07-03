import random

fm = open('uniqueid_meals.txt')
fe = open('uniqueid_eat.txt')

meals = []
eateries = []


for line in fm:
    meals.append(line.rstrip())
for line in fe:
    eateries.append(line.rstrip())

fm.close()
fe.close()


f_res = open('generated.txt', 'w')

for i in range(100):
    amount = random.randrange(0, 15)
    if amount == 0:
        tmp_state = random.choice(['Нет в наличии', 'Готовится'])
    else:
        tmp_state = 'В наличии'
        
    f_res.write('(\'' + random.choice(eateries) + '\', \'' +
                random.choice(meals) + '\', ' +
                str(amount) + ', \'' +
                tmp_state + '\'),\n')
                
f_res.close()
