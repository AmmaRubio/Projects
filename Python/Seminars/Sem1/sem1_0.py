li = [1,2,3,5,6,15,23,38]

listRes = [(i,i**2) for i in li if i % 2 == 0]
listRes2 = list(map(lambda x:(x,x**2),filter(lambda x: x%2 == 0, li)))


print(listRes)
print(listRes2)


