try: 
    x1 = int(input("input first number"))
except: 
    print("you HAD to input integer")
try: 
    x2 = int(input("input second number"))
except:
    print("you had to input integer")

def sumWithPrint(a,b): 
    z = a + b
    print(f"{a} + {b} = {z}")
    return z

sumWithPrint(x1,x2)

def checkSquare(a,b):
    result = False
    if a**2 == b:
        result = True
    print(f"{b} is square of {a}? - {result}") 
    return result

checkSquare(x1,x2)

list = [1,2,3,4,10,9]

def findMax(list): 
    max = list[0]
    for i in list: 
        if i > max: 
            max = i
    return max

print(f"{list} -> {findMax(list)}")

def firstDigitAfterComma(a):
        result = a - a//1
       



