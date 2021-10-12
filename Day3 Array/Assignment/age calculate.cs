using System;
					
public class Persons
{
	private string firstname;
	private string lastname;
	private DateTime dob;
	public string result;
	public int age;
	public string Firstname{get;set;}
	public string Lastname{get;set;}
	public DateTime Dob{get;set;}
	public string Adult(int age){
		if(age>18)
		{
			result="Adult";
			return result;
		}
		else
		{
			result="Child";
			return result;
		}
	}
	public int agecal(DateTime dob){
	DateTime d1=DateTime.Now;
		age=d1.Year-dob.Year;
		return age;
	}
	public void getDetails(){
		Console.WriteLine("Your name is {0}. Your age is {1} and you are a/an {2}", firstname, agecal(dob),Adult(agecal(dob)));
	}
		
	public static void Main()
	{
		Console.WriteLine("Age calculator");
		Persons ob=new Persons();
		Console.WriteLine("Enter your firstname");
		string s1=Console.ReadLine();
		Console.WriteLine("Enter your lastname");
		string s2=Console.ReadLine();
		Console.WriteLine("Enter your dob");
		DateTime dob=Convert.ToDateTime(Console.ReadLine());
		ob.Firstname=s1;
		ob.Lastname=s2;
		ob.dob=dob;
		//age=ob.agecal(dob);
		//Console.WriteLine("your age is "+age);
		//Console.WriteLine("you are a/an"+Persons.Adult(age));
		ob.getDetails();
	}
}