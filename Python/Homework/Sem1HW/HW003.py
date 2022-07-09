from turtle import xcor


xCor = int(input("input x coordinate (not 0): "))
yCor = int(input("input y coordinate (not 0): "))

def findQuarter(x,y): 
    if x>0:
        if y>0:
            return 1
        return 4
    if y > 0: 
        return 2
    return 3


if xCor != 0 and yCor != 0:
    output = findQuarter(xCor,yCor)
    print(f"x = {xCor}; y = {yCor} -> {output}")
else:
    print("wrong input")