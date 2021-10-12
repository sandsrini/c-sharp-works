using System;
					
public class Program
{public int cube(int n){
	return n*n*n;
	}
 public int add(int x,int y){
	return x+y;
	}public int add(int x,int y,int z){
	return x+y+z;
	}
 public string add(string a,string b){
	return a+b;
	}
 public float add(float x,float y){
	return x+y;
	}
	public static void Main()
	{
		Console.WriteLine("Method Overloading");
		Console.WriteLine("Enter three numbers");
		Program p=new Program();
		int x,y,z;
		x=Convert.ToInt32(Console.ReadLine());
		y=Convert.ToInt32(Console.ReadLine());
		z=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Adding two numbers:"+p.add(x,y));
		Console.WriteLine("Adding three numbers:"+p.add(x,y,z));
		Console.WriteLine("Enter two strings");
		string a,b;
		string c;
		a=Console.ReadLine();
		b=Console.ReadLine();
		Console.WriteLine("Adding two strings:"+p.add(a,b));
	}
}