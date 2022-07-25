#  Даны два файла, в каждом из которых находится запись многочлена.
#  Задача - сформировать файл, содержащий сумму многочленов.



def rewritting01Coef(strList): 
    resultList = []
    for e in strList:
        if "x" in e:
            if "^" in e:
                resultList.append(e)
            else:
                resultList.append(e+"^1")
        else: 
            resultList.append(f"{e}*x^0")
    return resultList
def concatingToTouple(strList):
    return list(map(lambda str: (int(str.split("*")[0]),int(str.split("^")[1])), strList))
def addpoly(p1,p2):
    for i in range(len(p1)):
        for item in p2:
            if p1[i][1] == item[1]:
                p1[i] = ((p1[i][0] + item[0]),p1[i][1])
                p2.remove(item)
    p3 = p1 + p2
    for item in (p3):
        if item[0] == 0:
            p3.remove(item)
    return p3
def coefsToString(poly):
    result = ""
    for e in poly: 
        result = result + str(e[0]) + "x^" + str(e[1]) + "+"
    result = result.replace("x^1", "x")
    result = result.replace("x^0","")
    result = result[:-1]
    return result


def demo(): 
    fileName = input("input relative paths to files containing polynomials (separate them by space): ").split()
    poly1 = open(fileName[0],"r")
    data1 = poly1.read()
    poly1.close()
    poly2 = open(fileName[1],"r")
    data2 = poly2.read()
    poly2.close()

    data2 = rewritting01Coef(data2.split("+"))
    data1 = rewritting01Coef(data1.split("+"))

    result = (coefsToString(addpoly(concatingToTouple(data1),concatingToTouple(data2))))
    print ("result: " + result)

    resultFile = open("Python/Homework/Sem5HW/resultSumPoly.txt","w+")
    resultFile.write(result)
    resultFile.close()
demo()


