using System;
using static System.Console;

string[]array = {"Hello,",  "2,",  "world,",   "1234,",     "1567,", "123,", "qws", "+_)", "computer science,"};       
WriteLine();  
MethodCreateInputArray(array);  
WriteLine();
MethodCreateOutputArray(array);
WriteLine();


void MethodCreateInputArray(string[] InputArray) 
{                                                
    Write($"InputArray: ");                      
    for (int i = 0; i < InputArray.Length; i++)  
    {
        Write($"{InputArray[i]}");
    }
}

void MethodCreateOutputArray(string[] OutputArray) 
{                                                  
    Write($"Output array: ");                     
    string[] newarr = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)    
    {                                              
        if (OutputArray[i].Length <=3)
        {
            newarr[i] = OutputArray[i];
            Write($"{newarr[i]}");
        }
    }
    WriteLine();
}