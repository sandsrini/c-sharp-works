using System;
public delegate void add(int a,int b);//declaring a delegate
public class Program
	{public void add(int a, int b){
		Console.WriteLine(a+b);//target method should have same signature as the delegate
	}
	public void sub(int a, int b){
		Console.WriteLine(a-b);
	}
	public void mul(int a, int b){
		Console.WriteLine(a*b);
	}
	public static void Main()
	{
		Program p=new Program();
		add a=p.add;//creating instance and assigning target method
		add b=p.sub;
		add c=p.mul;
		add mcd1=a+b-c;
		add mcd=a+b+c;//multicast delegates and combining three
		mcd(20,10);
		mcd1(20,20);
	}
}