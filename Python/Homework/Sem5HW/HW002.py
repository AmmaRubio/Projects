# Дан список чисел. Создайте список, в который попадают числа, 
# описываемые возрастающую последовательность. Порядок элементов менять нельзя.

# как я понял, надо вывести непрырываемую последовательность начиная с меньшего числа

def fun1(list): 
    minX = min(list)
    resultSeq = []
    for i in range(minX,minX + len(list)): 
        if i in list:
            resultSeq.append(i)
        else:
            return resultSeq
    return resultSeq

def fun2(listin): 
    return list((min(listin),max(listin)))

def demo():
    inList = [int(e) for e in input("input integer numbers (divided by space): ").split()]
    result = fun2(fun1(inList))
    print(result)
demo()
