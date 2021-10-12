using System;
using System.Collections;

public class PlayerBO
{
	
	public int noofballs;
	public int ballsresult;
	public void addOverDetails(int oversBowled)
	{
	ArrayList arr=new ArrayList();
		arr.Add(oversBowled);
	}
	public int getNoOfBallsBowled()
	{
	ballsresult=noofballs*6;
		return ballsresult;
	}
}
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Ball Bowled");
		Console.WriteLine("Enter the number of overs");
		int over=Convert.ToInt32(Console.ReadLine());
		PlayerBO p=new PlayerBO();
		p.addOverDetails(over);
		p.noofballs=over;
		int noofballs1=p.getNoOfBallsBowled();
		Console.WriteLine("Number of balls"+ noofballs1);
	}
}