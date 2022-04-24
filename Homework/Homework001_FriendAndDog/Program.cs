// The Problem: We have two friends with speed of v1 and v2, they are distance appart, and 
// a dog is running between them , calculate how many times will the dog run until distance <=10m

string input=""; 
int distance; 
int v1; 
int v2; 
int vd; // dog speed
bool friend1 = true; 
int count = 0; //Dog's runs 

Console.WriteLine("input distance between friends:"); 
input = Console.ReadLine();
Int32.TryParse(input, out distance);
Console.WriteLine(distance);
Console.WriteLine("input speed of 1st friend");
input = Console.ReadLine();
Int32.TryParse(input, out v1);
Console.WriteLine("Input speed of 2nd friend"); 
input = Console.ReadLine();
Int32.TryParse(input, out v2);
Console.WriteLine("Input speed of the dog"); 
input = Console.ReadLine();
Int32.TryParse(input, out vd);

if(distance >10){
    while(distance > 10)
    { // if the distance is 10m, we say that friends have met
        if(friend1 == true){// if dog is running to friend 1
        int speed = v1 + vd; 
        int time = distance/speed; 
        distance = distance - time * (v1+v2);
        friend1 = false; // next time dog will run to friend2
        count++; 
        }
        else{
            int speed = v2 + vd; 
            int time = distance/speed; 
            distance = distance - time*(v1+v2); 
            friend1 = true; 
            count++; 
        }
    }
}
else Console.WriteLine("The distance is to small"); 

Console.WriteLine("the dog will run "+count+" times."); 

