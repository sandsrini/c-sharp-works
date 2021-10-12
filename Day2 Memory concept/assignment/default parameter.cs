using System;
public class HelloWorld {
    public string concat(string firstname,string lastname){
        return (firstname+" "+lastname);
    }
    public string concat1(string firstname="sandhya",string lastname="srini"){
        return (firstname+" "+lastname);
    }
	public string concat2(string firstname,string lastname)
	{
		return (firstname+" "+lastname);
	}
  public static void Main(string[] args) {
      HelloWorld obj=new HelloWorld();
    Console.WriteLine("Default Parameter");// default parameter is required for all the fields
    Console.WriteLine("Enter you firstname:");
    string a,b;
a=Console.ReadLine();
Console.WriteLine("Enter your lastname");
b=Console.ReadLine();
// string c=(a+" "+b);
// Console.WriteLine("Full name:"+c);
Console.WriteLine("Full name:"+obj.concat(a,b));
Console.WriteLine("Full name:"+obj.concat1(a));//default parameter
	  Console.WriteLine("Full name:"+obj.concat2(lastname:b,firstname:a));//named parameter
  }
}