using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SillyStackTests
{

	internal class Program
	{
		public static void Main(string[] args)
		{
			StringManager myStringMaker = new StringManager();

			// Test 1: Reverse a string
			Console.WriteLine(myStringMaker.Reverse("Sunbeam Tiger"));

			// Test 2: ToString()
			Console.WriteLine(myStringMaker.ToString());

			// Test 3: Reverse a string preserving casing location
			Console.WriteLine(myStringMaker.Reverse("Sunbeam Tiger", true));

			// Test 4: Equality check
			Console.WriteLine(myStringMaker.Equals("Sunbeam Tiger"));

			// Test 5: Symmetric check
			Console.WriteLine(myStringMaker.Symmetric("ABBA"));
			Console.WriteLine(myStringMaker.Symmetric("ABA"));
			Console.WriteLine(myStringMaker.Symmetric("ABba"));


		}
	}
}
