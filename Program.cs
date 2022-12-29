using System;
using System.Linq;

namespace Prime_Number_task
{
	public static class Program
	{
		public static void Main()
		{
			Console.WriteLine("Please Enter The First Number");
			int number1 =int.Parse(Console.ReadLine());
			
			Console.WriteLine("Please Enter The Second Number");
			int number2 = int.Parse(Console.ReadLine());
			
         int x,tmp=0;
         for(;number1<=number2;number1++)
         {
         	for(x=1;x<=number1;x++)
         	{
         		if(number1%x==0)
         		{
         			tmp++;
         		}
         	}
         	if(tmp==2)
         	{
         		Console.WriteLine(" "+ number1+ "  is prime ");
         		tmp=0;
         	}
         	else
         	{
         		tmp=0;
         	}
         }
		}
	}
}