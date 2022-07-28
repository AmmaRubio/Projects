def readFileFromConsole():
    fileRelPath = input("input relative path to file: ")
    file = open(fileRelPath,"r")
    data = file.read()
    file.close()
    return data 
def writeInFile(filePath):
    resultFile = open(filePath,"w+")
    resultFile.write(result)
    resultFile.close()