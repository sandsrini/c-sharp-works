using System;
namespace ConsoleApp12
{
public class Program
{
public static void minarr(int[] arr)
{
Console.WriteLine("displaying array elements");
int min = arr[0];
for (int i = 1; i<arr.Length; i++)
{
if(min>arr[i])
{
min = arr[i];
}
}Console.WriteLine("minimum element in array is"+ min);}
	public static void maxarr(int[] arr)
{
Console.WriteLine("displaying array elements");
int max = arr[0];
for (int i = 1; i<arr.Length; i++)
{
if(max<arr[i])
{
max = arr[i];
}
}
Console.WriteLine("maximum element in array is"+ max);
}
public static void Main(string[] args)
{
int[] arr3= new int[5];//creation of array - declared
arr3[0] = 10;//initializing array
arr3[1] = 20;
arr3[2] = 30;
int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
int[] arr2 = { 11, 12, 17 };
minarr(arr3);//passing array to method
minarr(arr1);
minarr(arr2);
maxarr(arr3);
	maxarr(arr1);
	maxarr(arr2);
/* Console.WriteLine("using For loop");
for (int i=2;i>=0;i--)
{
Console.WriteLine(arr2[i]);
}
Console.WriteLine("using Foreachloop");
foreach (int j in arr1)
{
Console.WriteLine(j);
}*/
}}}