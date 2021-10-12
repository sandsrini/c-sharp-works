using System;
public class Game{
public string Name{get;set;}
    public int MaxNumPlayers{get;set;}
    public virtual void toString(){
	Console.WriteLine("Maximum number of players for {0} are {1}",Name,MaxNumPlayers);
	}
}
public class GameWithTimeLimit : Game
{
    public int TimeLimit{get;set;}
	public string game1{get;set;}
	public int num1{get;set;}
    public override void toString()
	{
	//toString();
	Console.WriteLine("Maximum number of players for {0} are {1}", Name, MaxNumPlayers);
	Console.WriteLine("Maximum number of players for {0} are {1}",game1,num1);
	Console.WriteLine("Time limit for {0} is {1}",game1,TimeLimit);
	}
}
    public class Program {
  public static void Main() {
    Console.WriteLine("Game in inheritance");
    Console.WriteLine("Enter a game");
    string game=Console.ReadLine();
    Console.WriteLine("Enter the maximum number of players");
    int num=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a game that has a time limit");
	  
    string game1=Console.ReadLine();
	  
    Console.WriteLine("Enter the maximum number of players");
    int num1=Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("Enter the time limit in min");
	int time=Convert.ToInt32(Console.ReadLine());
	
	  GameWithTimeLimit g=new GameWithTimeLimit();
	  g.Name=game;
	  g.game1=game1;
	  g.num1=num1;
	  g.MaxNumPlayers=num;
	  g.TimeLimit=time;
	  g.toString();
  }
}