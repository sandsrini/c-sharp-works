using System;
public class Assignment {
    public static double square(double n){
        return n*n;
        // Console.WriteLine("Square of {0} is {1}",n,sq);
    }
    public static double cube(double n){
        return n*n*n;
        // Console.WriteLine("Cube of {0} is {1}",n,cube);
    }
 public static void Main(string[] args) {
    Console.WriteLine("Find Square and Cube of a number");
    Console.WriteLine("Enter a number");
    double n=Convert.ToDouble(Console.ReadLine());
    double sq=Assignment.square(n);
    double cube=Assignment.cube(n);
    Console.WriteLine($"Square of {n} is {sq}");
    Console.WriteLine($"Cube of {n} is {cube}");
    
}}