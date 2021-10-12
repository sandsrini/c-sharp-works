using System;
using System.Collections.Generic;
public delegate bool addemp(Employee e);//declaring a delegate
public class Employee{
	public int Id{get;set;}
	public string Name{get;set;}
	public int Salary{get;set;}
	public int Exp{get;set;}
	public void promoteEmployee(List<Employee> emplist,addemp iselligible)
	{
		foreach(var emp in emplist){
			if(iselligible(emp))
			   {
				   Console.WriteLine("{0} promoted",emp.Name);
			   }}}}
	public class Program{
	public static bool Promote(Employee e)
	{
		if(e.Exp>=3)
	{
		return true;
	}
	 else
	 {
		 return false;
	 }
	}
	public static void Main()
	{
		List<Employee> employee=new List<Employee>();
		employee.Add(new Employee(){Id=1,Name="san",Salary=200000,Exp=2});
		employee.Add(new Employee(){Id=2,Name="sandy",Salary=200000,Exp=3});
		employee.Add(new Employee(){Id=3,Name="sandhya",Salary=200000,Exp=5});
		employee.Add(new Employee(){Id=4,Name="sansrini",Salary=200000,Exp=5});
		employee.Add(new Employee(){Id=5,Name="sansrinivasan",Salary=200000,Exp=5});
		Employee p=new Employee();
		addemp a = new addemp(Promote);
		p.promoteEmployee(employee,a);
	}
}