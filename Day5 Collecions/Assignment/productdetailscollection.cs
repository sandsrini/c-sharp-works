using System;
using System.Collections;
public class product
{
public string productname;
public string serialnumber;
public DateTime purchasedate;
public double cost;
ArrayList pr = new ArrayList() { "HairTrimmer" };
ArrayList sno = new ArrayList() { "HT123" };
ArrayList purdate = new ArrayList() { "10/02/2017" };
ArrayList price = new ArrayList() { "800" };
public string ToString(string pn, string sn, DateTime pd, double cost)
{



pr.Add(pn);
sno.Add(sn);
purdate.Add(pd.ToString("d"));
price.Add(cost);
string details = String.Format("{0,-15}{1,-15}{2,-15}{3,-15} \n", "Product Name", "Serial Number", "Purchase Date", "Cost");
for (int i = 0; i < pr.Count; i++)
{
details += String.Format("{0,-15}{1,-15}{2,-15}{3,-15} \n", pr[i], sno[i], purdate[i], price[i]);



}
return details;




//return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", pn, sn, pd ,cost);
}
}
public class program
{
public static void Main(string[] args)
{
product p = new product();
p.productname = Console.ReadLine();
p.serialnumber = Console.ReadLine();
p.purchasedate = Convert.ToDateTime(Console.ReadLine());
p.cost = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name","Serial Number", "Purchase Date" ,"Cost"));
Console.WriteLine(p.ToString(p.productname, p.serialnumber, p.purchasedate, p.cost));
//Console.WriteLine(p.purchasedate.ToString("d"));



}
}