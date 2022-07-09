'''
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Пример:
- 6 -> да
- 7 -> да
- 1 -> нет
'''

def booleanToRussian(bool): 
    if bool == True:
        return "да"
    return "нет"

def isWeekend(a):
    if a == 6 or a == 7: 
        return True
    return False

dayInt = int(input("input day of the week (between 1 and 7): "))

if 0<dayInt<8:
    print(f"{dayInt} -> {booleanToRussian(isWeekend(dayInt))}")
else: 
    print("wrong input")
