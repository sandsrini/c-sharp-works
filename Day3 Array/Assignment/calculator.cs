using System;
public class Calculator {
    public int add(int a,int b){
        return a+b;
    }
    public int sub(int a,int b){
        return a-b;
    }
    public int mul(int a, int b){
        return a*b;
    }
    public int div(int a, int b,out double rem){
        int div=a/b;
        int remainder=a%b;
        rem=remainder;
		return div;
    }
  public static void Main() {
    Console.WriteLine("Calculator");
    Console.WriteLine("Enter the operator");
    string op=Console.ReadLine();
    Console.WriteLine("Enter the operand A");
    int op1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the operand B");
    int op2=Convert.ToInt32(Console.ReadLine());
    double remainder;
    Calculator c=new Calculator();
    int res;
    switch(op)
    {
        case "add":
        {
            res=c.add(op1,op2);
			Console.WriteLine("Result of {0} + {1} is {2}",op1,op2,res);
            break;
        }
        case "sub":
        {
            res=c.sub(op1,op2);
			Console.WriteLine("Result of {0} - {1} is{2}",op1,op2,res);
            break;
        }
        case "mul":
        {
            res=c.mul(op1,op2);
			Console.WriteLine("Result of {0} * {1} is{2}",op1,op2,res);
            break;
        }
        case "div":
        {
            res=c.div(op1,op2,out remainder);
			Console.WriteLine("Result of {0} / {1} is{2} and the remainder is {3}",op1,op2,res,remainder);
            break;
        }
			default:
        {
            //res=c.div(op1,op2,out remainder);
			Console.WriteLine("Invalid operator");
            break;
        }
    }
    //Console.WriteLine("Result of {0} {1} {2} is{res}",op1,op,op2,res);
  }
}
