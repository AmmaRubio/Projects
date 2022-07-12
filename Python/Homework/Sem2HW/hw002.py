def factorial(x): 
    if x==1: 
        return 1
    else: 
        return x * factorial(x-1)

def setOfFact(N): 
    resultString = "[ "
    for i in range(1,N+1):
        if (i == N):
            resultString += f"{factorial(i)} ]"
        else: 
            resultString += f"{factorial(i)}, "
    return resultString

inVar = int(input("input integer N: "))
outVar = setOfFact(inVar)
print(f"{inVar} -> {outVar}")