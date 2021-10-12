using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Libraby book code");
		Console.WriteLine("Enter the book code of length 18");
		string code=Console.ReadLine();
				int deptcode=Convert.ToInt32(code.Substring(0,3));
		int yr=Convert.ToInt32(code.Substring(3,4));
		int pgnum=Convert.ToInt32(code.Substring(7,5));
		string id=code.Substring(12,6);
		if(code.Length==18){
			if(deptcode==101||deptcode==102||deptcode==103)
			{
            Console.WriteLine("Department Code:" +deptcode);
                if(yr>=1900 && yr<=2020)
                {
                Console.WriteLine("Publication year:"+yr);
                    if(pgnum>=00001 && pgnum<=99999)
                    {
                    Console.WriteLine("Page Number:"+pgnum);
                        if(char.IsLetter(code,12))
                        {
                            Console.WriteLine("Department Code: {0} Year of publication: {1} Number of pages: {2} Book Id: {3}",deptcode,yr,pgnum,id);
                        }
                        else
                        {
                        Console.WriteLine("Invalid id");
                        }
                    }
                    else
                    {
                         Console.WriteLine("Invalid page number");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid year");
                }
            }
            else
			{
				Console.WriteLine("Invalide deptcode");
			}
		}
		else
		{
			Console.WriteLine("Invalid code");
		}
	}
}