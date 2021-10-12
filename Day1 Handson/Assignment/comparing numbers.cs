using System;
public class Assignment {
    int x;
    int y;
    public static bool compare(int x, int y){
        if(x>y){
            return false;
        }else
        {return true;
        }
    }
 public static void Main(string[] args) {
    Console.WriteLine("Comparing two numbers");
    Console.WriteLine("Enter the value x");
    int x=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the value y");
    int y=Convert.ToInt32(Console.ReadLine());
    bool result=Assignment.compare(x,y);
    Console.WriteLine($"The result of whether {x} is less than {y} is {result}");}}