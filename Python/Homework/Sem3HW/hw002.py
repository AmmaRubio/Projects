from csv import list_dialects
from posixpath import split




def createDict(text): 
    text = str(text).lower()
    list = text.split(' ')
    resDict = {}
    for e in list: 
        if e in resDict.keys(): 
            resDict[e] += 1
        else: 
            resDict[e] = 1
    return resDict


def demo(): 
    inVar = input("Please, input text")
    outVar = createDict(inVar)
    print(outVar)

demo()