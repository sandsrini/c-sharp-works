using System;
public class Assignment {
    
    public static int mul(int x, int y){
        return x*y;
    }
 public static void Main(string[] args) {
     int pizza=200;
    int puff=40;
    int pepsi=120;
    Console.WriteLine("Calculating Bill");
    Console.WriteLine("Enter the number of pizzas bought:");
    int x=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of puffs bought:");
    int y=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of pepsis bought:");
    int z=Convert.ToInt32(Console.ReadLine());
    int costpizza=Assignment.mul(pizza,x);
    int costpuff=Assignment.mul(puff,y);
    int costpepsi=Assignment.mul(pepsi,z);
    Console.WriteLine($"The cost of pizzas: {costpizza}");
     Console.WriteLine($"The cost of pizzas: {costpuff}");
     Console.WriteLine($"The cost of pepsis: {costpepsi}");
    int sum=costpizza+costpuff+costpepsi;
    float GST=(12*sum/100);
    float CESS=(5*sum/100);
    Console.WriteLine("The cost of pizzas:"+costpizza);
     Console.WriteLine("The cost of pizzas:"+costpuff);
     Console.WriteLine("The cost of pepsis:"+costpepsi);
         Console.WriteLine("Total Price:"+sum);
         Console.WriteLine("GST:"+GST);
         Console.WriteLine("CESS"+CESS);
         float totalprice=sum+GST+CESS;
         Console.WriteLine("Total price:"+totalprice);
 }}