using System;
					
public class Program
{
	public void show(params object[] val){
for(int i=0;i<val.Length;i++)
	{
	Console.WriteLine(val[i]);
}}
	public static void Main(string[] args)
	{
		Console.WriteLine("Params");
		Program p=new Program();
		//int[] arr=new int[4]{2,3,4,90};
		//show(2,'b',4,5);//takes i as 105,a as 97,b as 98
		p.show(2,"hi",3,4);
	}
}