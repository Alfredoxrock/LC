using System;
using System.Linq;
using System.Collections;

namespace nulltype{
	class example{
		static void Main(string[] args){
			
			int? num = null;

      // Is the HasValue property true?
      if (num.HasValue)
      {
          System.Console.WriteLine("num = " + num.Value);
      }
      else
      {
          System.Console.WriteLine("num = Null");
      }

      // y is set to zero
      int y = num.GetValueOrDefault();

      // num.Value throws an InvalidOperationException if num.HasValue is false
      try
      {
          y = num.Value;
      }
      catch (System.InvalidOperationException e)
      {
          System.Console.WriteLine(e.Message);
      }

      Console.ReadKey();


		}
	}
}
