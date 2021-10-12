using System;
					
public class Program
{
	public void Array1()
	{
		Console.WriteLine("Single Dimensional array");
		int[] arr1= new int[3];
		arr1[0]=3;
		arr1[1]=2;
		int[] arr2=new int[]{1,2,3};
		int[] arr3={1,2,3};
		for(int i=0;i<arr1.Length;i++){
		Console.WriteLine(arr1[i]);
		}
	}
	public void Array2()
	{
		Console.WriteLine("Two Dimensional array");
		int[,] arr1= new int[3,3];
		arr1[0,0]=2;
		arr1[0,1]=3;
		arr1[0,2]=2;
		arr1[1,0]=90;
		arr1[1,1]=90;
		arr1[1,2]=90;
		arr1[2,0]=20;
		arr1[2,1]=2;
		arr1[2,2]=90;
		int[,] arr2=new int[,]
		{
			{1,2,3},{2,3,4},{1,2,3}
		};
		int[,] arr3={
			{1,2,3},{2,3,4},{1,2,3}
		};
		for(int i=0;i<3;i++)
		{
		for(int j=0;j<3;j++)
		{
			Console.Write(arr1[i,j]+" ");
		}
					   Console.WriteLine();
		}
	}
	public void Array3()
	{
		Console.WriteLine("Jagged array");
		int[][] arr1= new int[2][];
		arr1[0]=new int[]{90,80,70};
		arr1[1]=new int[]{90,80,70,200};
		int[][] arr2=new int[2][]
		{
			new int[]{90,80,70},
			new int[]{90,80}
		};
		int[][] arr3=new int[2][]{
			new int[]{90,80,70},
			new int[]{90,80}};
		for(int i=0;i<arr1.Length;i++)
		{
		for(int j=0;j<arr1[i].Length;j++)
		{
		Console.Write(arr1[i][j]+" ");
		}
		Console.WriteLine();
		}
	}
	public static void Main()
	{
		Program arr1=new Program();
		arr1.Array1();
		arr1.Array2();
		arr1.Array3();
	}
}