from cgitb import reset
from unittest import result
import defs as file 



def createDict(data):
    resLetter = []
    resCounter = []
    for i in range(0,len(data)):
        if i ==0:
            resLetter.append(data[i])
            resCounter.append(1)
        elif data[i] == data[i-1]: 
            resCounter[len(resCounter)-1] +=1
        else: 
            resLetter.append(data[i])
            resCounter.append(1)
    return list(zip(resLetter,resCounter))

def RLE():
    result =createDict( file.readFileFromConsole())
    print(file.listToStr( result))
    file.writeInFile("Python/Homework/SEM6HW/RLEout.txt",file.listToStr((result)))
    return result
RLE()
