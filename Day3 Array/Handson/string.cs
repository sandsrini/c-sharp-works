using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("String methods");
		string s1="hi how are you?";
		string s2=s1.Substring(3,11);
		Console.WriteLine("String 1 is {0} string 2 is {1}",s1,s2);
		string s3=(string)s1.Clone();
		char[] s4=new char[4];
				s1.CopyTo(1,s4,0,2);
		Console.WriteLine("String 3 is {0} string 4 is {1}",s3,s4);
		Console.WriteLine(string.Compare(s1,s2));
		Console.WriteLine(string.Compare(s3,s2));
		Console.WriteLine(string.Compare(s1,s3));
		Console.WriteLine(string.Concat(s1,s2));
		string[] s5=s1.Split(' ');
		foreach(string s in s5)
		{
		Console.WriteLine(s);}
	}
}