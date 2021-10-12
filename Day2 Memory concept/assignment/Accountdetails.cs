using System;
public class Program {
  public static void Main() {
    Console.WriteLine("Account Details");
    Console.WriteLine("Enter your account number");
    int id=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your accont type");
    string type=Console.ReadLine();
    Console.WriteLine("Enter your balance");
    double balance=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter amount to withdraw");
    double amount=Convert.ToDouble(Console.ReadLine());
    // Account acc=new Account();
    Account acc=new Account(id,type,balance);
    acc.withdraw(amount);
    acc.getDetails();
  }
}
class Account{
     int id;
     string account_Type;
     double balance;
    public double amount;
	public double result;
    public Account(){
Console.WriteLine("initiated");
    }
    public Account(int i, string b, double c)
    {
        id=i;
        account_Type=b;
        balance=c;
    }
    public bool withdraw(double amount)
    {
        if(amount<balance)
        {
            result=balance-amount;
			return true;
        }
        else{
            return false;
        }
    }
    public void getDetails()
    {
        Console.WriteLine("Account details");
        Console.WriteLine("Account Id is:"+id);
        Console.WriteLine("Account Type is"+account_Type);
        Console.WriteLine("Account balance is"+balance);
        if(reslut){
        Console.WriteLine("New balance"+result);
        }
    }
}