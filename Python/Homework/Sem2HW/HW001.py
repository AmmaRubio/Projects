def getSumOfChars(x):
    x = str(x)
    result = float(0)
    for i in x: 
        if i != "," and i != ".": 
            result = result + float(i)
    return result

inVar = float(input("input real number: "))
outVar = getSumOfChars(inVar); 

print(f"{inVar} -> {outVar}")