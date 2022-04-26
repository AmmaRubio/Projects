int Max(int arg1, int arg2, int arg3){
    int res = arg1; 
    if(arg2>res) res = arg2; 
    if (arg3 > res) res = arg3 ; 
}
int n1 = 1; 
int n2 = 22; 
int n3 = 4; 
int n4 = 33; 
int n5 = 223; 
int n6 = 90; 
int n7 = 852; 
int n8 = 951; 
int n9 = 658; 

int maximal = Max(Max(n1,n2,n3),Max(n4,n5,n6),Max(n7,n8,n9)); 
Console.WriteLine(maximal);