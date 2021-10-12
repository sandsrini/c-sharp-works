using System;
					
public class Program
{int a=20;
 public static int manipulate(int n){//call by value
	 return n=n*n;
 }
	 public static int manipulate(ref int n){
 return n=n*n;
 }//call by reference
 public static int manipulate1(out int n){//unassigned out parameter not allowed
	 int a=40;
	 n=a;
	 return n=n*n;
 }
	public static void Main()
	{
		Console.WriteLine("Call by value,call by reference, call by out parameter");
		Console.WriteLine("Enter a number");
int n=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Number before calling the function is:"+n);
		Program.manipulate(n);
// 		Program.manipulate(ref n);
// 		Program.manipulate1(out n);
		Console.WriteLine("See the number after calling the function:"+n);
	}
}