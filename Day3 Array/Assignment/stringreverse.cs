using System;
					
public class Program
{
	public static string[] rev(string s1){
		string[] s2=new string[s1.Length];
		s2=s1.Split(' ');
		string[] s3= new string[s2.Length];
		for(int i=0,j=s2.Length-1;i<s2.Length;i++,j--){
			s3[i]=s2[j];
		}
        Array.Reverse(s2);
	//return s3;
    return s2;
	}
	public static void Main()
	{
		Console.WriteLine("Reverse string");
		Console.WriteLine("Enter a string");
		string s1=Console.ReadLine();
		Console.WriteLine(string.Join(" ",Program.rev(s1)));
		//string[] s2=Program.rev(s1);
		//for(int i=s2.Length,j=0 ; i>0 ; i--,j++)
		//{
		//	s2[j]=s1[i];
			//Console.WriteLine(s2[i]);
		//}
	}
}