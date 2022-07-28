def demo():
    inStr = input("input expression to be calculated: ")
    if ("os.system" in inStr):
        print("No, my friend, not this time :-)")
    else:
        d = eval(inStr)
        print(inStr+ " = " + str(round(d,2)))
demo()