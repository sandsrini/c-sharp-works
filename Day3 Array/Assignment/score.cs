using System;
					
public class Program
{
	public static int GetTotal(params int[][] arr)
	{
		int sum=0;
		for(int i=0;i<arr.Length;i++)
		{
			for(int j=0;j<arr[i].Length;j++)
			{
				sum+=arr[i][j];
			}
			Console.WriteLine("The total score of team "+i+ "is" + sum);
			sum=0;
		}
	 return sum;
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("Quiz with jagged arraay");
		Console.WriteLine("Enter number of teams");
		int n=Convert.ToInt32(Console.ReadLine());
		int[][] arr=new int[n][];
		for(int i=0;i<n;i++){
			Console.WriteLine("Enter the number"+i);
			arr[i]=new int[Convert.ToInt32(Console.ReadLine())];
				for(int j=0;j<arr[i].Length;j++){
					Console.WriteLine("Enter the score for team"+i);
					arr[i][j]=Convert.ToInt32(Console.ReadLine());
		
		}
		}
	}
}

