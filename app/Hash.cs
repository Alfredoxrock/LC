using System;
using System.Linq;
using System.Collections;

namespace app{
	class Hash{
		static void Main(string[] args){
			Hashtable myTable = new Hashtable();
			myTable.Add("Alfredo", 100);
			myTable.Add("Marco", 101);
			myTable.Add("Antonio", 102);
			myTable.Add("Felipe", 103);

			foreach(DictionaryEntry entry in myTable){
				Console.WriteLine("{ " + entry.Key + " : " + entry.Value + " }");
			}
			
			Console.ReadKey();


		}
	}
}