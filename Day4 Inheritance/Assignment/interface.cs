using System;

interface iopenable
{
	void sesame();
}
class Treasurebox : iopenable
{
	public void sesame(){
		Console.WriteLine("Congratulations, Here is your lucky win");
	}
}
public class Parachute : iopenable
{
	public void sesame(){
		Console.WriteLine("Having a thrilling experience of flying in air");
	}
}
public class Program
{
	public static void Main(){
		Treasurebox t=new Treasurebox();
		Parachute p=new Parachute();
		char ch;
			Console.WriteLine("Enter a character");
		ch=Convert.ToChar(Console.ReadLine());
		if(ch=='T'||ch=='t'){
			t.sesame();
		}
		else {
			if(ch=='P'||ch=='p')
		{
			p.sesame();
		}
			else{
				Console.WriteLine("hi");
			}
		}
	}
}