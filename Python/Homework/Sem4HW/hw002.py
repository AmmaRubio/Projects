
def findPrimaryMultiplier(N): 
    result = []
    while N > 1: 
     for mult in range(2,N+1):
        a = is_prime(mult) 
        if a: 
            if N % mult == 0: 
                N = N // mult
                result.append(mult)
                break
    return result

def is_prime(number): 
    for i in range (2,number):
        if (number % i == 0): 
            return False
    return True

def demo(): 
    inVar = int(input ( "Enter number to find prime factors of it: "))
    outVar = findPrimaryMultiplier(inVar)
    print(f"{inVar} is a multiplication of {outVar}")

demo()