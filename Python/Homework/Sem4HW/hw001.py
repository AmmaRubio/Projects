# Вычислить результат деления двух чисел c заданной точностью d

def getRoundIndex(d): 
    roundIndex = 0
    start = 1
    while start > d: 
        start = start / 10 
        roundIndex += 1
    return roundIndex

def demo(): 
    d = float(input("input preciseness of devision D, such as 0.1>D>0.0000000001 ").replace(",","."))
    if 0.1 >= d >= 0.0000000001: 
        x, y = input("Enter two number for division, such as 1st Number is divided by Second: ").split()
        x = float(x)
        y = float(y)
        outVar = round(x/y, getRoundIndex(d))
        print(f"{d} - preciseness, {x}/{y} = {outVar}")
    else: 
        print("wrong Input")


demo()