Console.Clear(); 

int xa = 50; 
int ya = 1; 
int xb = 1; 
int yb = 100; 
int xc = 100;
int yc = 100;

Console.SetCursorPosition(xa,ya); 
Console.Write("A");

Console.SetCursorPosition(xb,yb); 
Console.Write("B");

Console.SetCursorPosition(xc,yc); 
Console.Write("C");

int count = 0;
int x = xa; 
int y = ya; 

while (count <1000){
    int what = new Random().Next(0,3); //0,1,2
    if(what == 0)
    {
        x = (x + xa)/ 2; 
        y = (y + ya)/2;
    }
    else if(what == 1){
        x = (x + xb)/ 2;
        y = (y + yb) / 2; 
    }
     else if (what == 2 ){
        x = (x + xc)/2; 
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x,y); 
    Console.Write("*"); 
    count++; 
}