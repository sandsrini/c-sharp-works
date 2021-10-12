using System;
public class Products
{
	public string _productName;
	public string _serialNumber;
	public DateTime _purchaseDate;
	public double _cost;
	public Products(string pname,string snumber,DateTime pdate,double cost)
	{
		_productName=pname;
		_serialNumber=snumber;
		_purchaseDate=pdate;
		 _cost=cost;
	}
	public void toString()
	{
		Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number",//should use string builder
"Purchase Date", "Purchase Cost"));
		Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", _productName, _serialNumber, _purchaseDate.ToShortDateString(), _cost));
	}
}public class Program
{
	public static void Main()
	{
		Console.WriteLine("Product details");
		Console.WriteLine("Enter product name");
		string pname=Console.ReadLine();
	Console.WriteLine("Enter serial number");
		string num=Console.ReadLine();
		Console.WriteLine("Enter purchase date");
		DateTime date=Convert.ToDateTime(Console.ReadLine());
		Console.WriteLine("Enter cost");
		int cost=Convert.ToInt32(Console.ReadLine());
		Products p=new Products(pname,num,date,cost);
		p.toString();
	}
}