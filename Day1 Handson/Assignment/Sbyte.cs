using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a number");
    sbyte number=Convert.ToSByte(Console.ReadLine());
    Console.WriteLine("Largest value stored in a signed byte:"+number);
	}
}