using System;
using System.Collections;
					
public class PlayerBO
{
	int noofballs;
	ArrayList arr=new ArrayList();
	public void addOverDetails(int over)
	{
		arr.Add(over);
	}
	public int getOverDetails()
	{
		return (int)arr[0] * 6;
	}
}
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ballsbowled");
		Console.WriteLine("Enter the number of overs");
		int over=Convert.ToInt32(Console.ReadLine());
		PlayerBO p=new PlayerBO();
		p.addOverDetails(over);
		Console.WriteLine("Balls bowled"+p.getOverDetails());
	}
}