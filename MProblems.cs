using System;

namespace Mproblem {

	class Mathproblems {

	    static void Main(string[] args)
		{
			Console.WriteLine(signVal(-5));
			Console.ReadKey();
		}

		public static string signVal(int x){
			if(x > 0){
				return x + " is bigger than zero";
			}
			else if(x < 0){
				return x + " is smaller than zero";
			}
			
			return x + " is equal to zero";
		}

		public static int thePowerOf(int a, int x){
			int PowerOf = a;

			for (int i = 1; i < x; i++){
				PowerOf = PowerOf * a;
			}

			return PowerOf;
		}

		public static int Factorial(int x){
			int factorial = 1;
			for(int i = 1; i < x + 1; i++){
				factorial = factorial * i;
			}

			return factorial;
		}

		public static int absoluteValue(int x)
		{
			int newN = Math.Abs(x);
			return newN;
		}

		public static string biggerAndSmaller(int x, int y){
			string a;
			if(x > y){
				 a = x + " is bigger than " + y;
			}
			else if(y > x){
				 a = y + " is bigger than " + x;
			}
			else 
			{
				 a = x + " is equal to " + y;
			}

			return a;
		}

	}
}