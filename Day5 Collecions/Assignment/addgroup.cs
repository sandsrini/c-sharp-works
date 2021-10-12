using System;
using System.Collections;

public class addGroup
{
	
	public int noofballs;
	public int ballsresult;
	public void Gold(string name)
	{
	ArrayList gold=new ArrayList(){"san","sandy"};//should use collection dictionary and list
		gold.Add(name);
	foreach(var i in gold)
	{
		Console.WriteLine(i);
	}
	}
	public void Silver(string name)
	{
	ArrayList silver=new ArrayList(){"pri","priya"};
		silver.Add(name);
		foreach(var i in silver)
	{
		Console.WriteLine(i);
	}
	}
	public void Platinum(string name)
	{
	ArrayList platinum=new ArrayList(){"poochi","pooja"};
		platinum.Add(name);
		foreach(var i in platinum)
	{
		Console.WriteLine(i);
	}
	}
}
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Add member");
		Console.WriteLine("Enter group");
		string g=Console.ReadLine();
		if((g.ToLower()=="silver") || (g.ToLower()=="gold") || (g.ToLower()=="platinum"))
		{
			Console.WriteLine("Enter name");
			string n=Console.ReadLine();
			addGroup p=new addGroup();
			if(g=="Gold"||g=="gold")
			{p.Gold(n);
			}
			else if(g=="Silver"||g=="silver")
			{
				p.Silver(n);
			}
			else if(g=="Platinum"||g=="platinum")
			{
				p.Platinum(n);
			}
		}
		else
		{
			Console.WriteLine("Give the correct Group name. The available group names are Gold,Silver and Platinum");
		}
	}
}