using System;
public class Assignment {
 public static void Main(string[] args) {
      Console.WriteLine("Assignment 1");
    Console.WriteLine("Enter your name");
    string name=Console.ReadLine();
    Console.WriteLine("Enter your age");
    int age=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your country");
    string country=Console.ReadLine();
    // Assignment ass1=new Assignment();
    // Console.WriteLine("Welcome {0}. Your age is {1} and you are from {2}",ass1.name,ass1.age,ass1.country);
    Console.WriteLine("Welcome {0}. Your age is {1} and you are from {2}",name,age,country);
}}