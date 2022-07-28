#Создайте программу для игры в "Крестики-нолики".



gameboard = [["_","_","_"],["_","_","_"],["_","_","_"]]

def checkForTie(): 
    result = True
    for i in range(0,3):
        for j in range(0,3): 
            if gameboard[i][j] == "_":
                result = False
    return result

def gameXO(marker): 
        showUI()
        makeTurn(marker)
        if checkForTie():
            showUI
            print("It's a tie!")
        else:
            if checkWinner()[1]:
                showUI()
                print(f"Player {checkWinner()[0]} wins!")
            else: 
                if marker == "X":
                    gameXO("O")
                else: 
                    gameXO("X")


def showUI():
    print(gameboard[0])
    print(gameboard[1])
    print(gameboard[2])

def makeTurn(marker): 
    coordinates = [int(x)-1 for x in input("Player "+marker+ " input coordinates (between 0 and 3, two integers): ").split()]
    for e in coordinates: 
        if e<0 or e>=3:
            e = "wrong" 
    if  "wrong" in coordinates: 
        print("Error: numbers should be between 1 and 3")
        showUI()
        makeTurn(marker)
    elif gameboard[coordinates[0]][coordinates[1]] != "_": 
        print("Error: coordinate is already occupied!")
        showUI()
        makeTurn(marker)
    else: 
        gameboard[coordinates[0]][coordinates[1]] = marker

def checkWinner(): 
    if all(elem == gameboard[0][0] and elem != "_" for elem in gameboard[0]): 
        return (gameboard[0][0], True)
    elif all(elem == gameboard[1][0] and elem != "_" for elem in gameboard[1]):  
        return(gameboard[1][0],True)
    elif all(elem == gameboard[2][0] and elem != "_" for elem in gameboard[2]):
        return(gameboard[2],[0],True)
    elif gameboard[0][0] == gameboard[1][0] == gameboard[2][0] != "_":
        return (gameboard[0][0], True)
    elif gameboard[0][1] == gameboard[1][1] == gameboard[2][1] !="_":
        return (gameboard[0][1], True)
    elif gameboard[0][2] == gameboard[1][2] == gameboard[2][2]!= "_":
        return (gameboard[0][2], True)
    elif gameboard[0][0] == gameboard[1][1] == gameboard[2][2]!= "_":
        return (gameboard[0][0], True)
    elif gameboard[0][2] == gameboard[1][1] == gameboard[2][0]!= "_":
        return (gameboard[0][2], True)
    else:
        return ("-", False)

gameXO("X")

