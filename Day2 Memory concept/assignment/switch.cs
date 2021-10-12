using System;

public class Switch{
	public static string grade;
    public static void Main(){
        Console.WriteLine("Switch statement");
        Console.WriteLine("Enter your mark");
        int mark=Convert.ToInt32(Console.ReadLine());

        string grade;
        switch(mark/10)
        {
            case 1:
            case 2:
            case 3:{
                Console.WriteLine("Try again");
            Switch.grade ="D";
            break;
                
            }
            case 4:
            case 5:
            case 6:{
                Console.WriteLine("Pass");
            Switch.grade ="C";
            break;
            }
            case 7:
            case 8:{
                Console.WriteLine("Average");
            Switch.grade ="B";
            break;}
            case 9:{
                Console.WriteLine("Firstclass");
            Switch.grade="A";
            break;}
            case 10:{
                Console.WriteLine("Distinction");
            Switch.grade ="O";
            break;}
        }
        Console.WriteLine("grade is "+Switch.grade);
    }
}