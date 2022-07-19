#Задайте список.
#  Напишите программу, которая определит, присутствует ли в 
# заданном списке строк некое число.




def inputArray():
    list = []
    y = 1
    counter = 0
    while y !="00": 
        print(f" Now array consits of {counter} elements")
        y = input("Please input an element of array, or if you want to stop enter '00' ")
        if y !="00": 
            counter+=1
            list.append(y)
    return list

def containsAt(list, element): 
    counter = 0
    for e in list: 
        if e == element: 
            return counter
        else: 
             counter += 1 
    return -1 

def demo(): 
    print ("please create an array")
    sampleArray = inputArray(); 
    print("this is your array: ")
    print(sampleArray)
    inVar = input("please input some element to be searched in the array: ")
    outVar = containsAt(sampleArray,inVar)
    print(f"serching for {inVar} in {sampleArray} -> element is at index: {outVar}")

demo()