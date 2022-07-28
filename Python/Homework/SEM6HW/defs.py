from unittest import result


def readFileFromConsole():
    fileRelPath = input("input relative path to file: ")
    file = open(fileRelPath,"r")
    data = file.read()
    file.close()
    return data 
def writeInFile(filePath,input):
    resultFile = open(filePath,"w+")
    resultFile.write(input)
    resultFile.close()

def listToStr(list):
    result = ""
    for e in list:
        result += str(e) +","
    return result