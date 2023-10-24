using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SillyStackTests
{
	public class StringManager
	{
		private string originalInput = string.Empty;

		public string Reverse(string s)
		{
			originalInput = s;
			Stack<char> stack = new Stack<char>();
			foreach (char c in s)
			{
				stack.Push(c);
			}

			StringBuilder reversed = new StringBuilder();
			while (stack.Count > 0)
			{
				reversed.Append(stack.Pop());
			}

			return reversed.ToString();
		}

		public string Reverse(string s, bool preserveCaseLocation)
		{
			originalInput = s;
			Stack<char> stack = new Stack<char>();
			Queue<int> caseLocations = new Queue<int>();

			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				stack.Push(c);

				if (char.IsLetter(c))
				{
					caseLocations.Enqueue(i);
				}
			}

			StringBuilder reversed = new StringBuilder();
			while (stack.Count > 0)
			{
				char c = stack.Pop();
				if (preserveCaseLocation && char.IsLetter(c))
				{
					int location = caseLocations.Dequeue();
					reversed.Insert(location, c);
				}
				else
				{
					reversed.Append(c);
				}
			}

			return reversed.ToString();
		}

		public bool Symmetric(string s)
		{
			return s.Equals(Reverse(s));
		}

		public override string ToString()
		{
			if (originalInput.Length == 0)
			{
				return "Negative One";
			}

			StringBuilder result = new StringBuilder();
			foreach (char c in originalInput)
			{
				result.Append($"{(int)c} ");
			}

			return result.ToString().Trim();
		}


		public override bool Equals(object obj)
		{
			if (obj is string str)
			{
				return originalInput.Equals(str);
			}

			return false;
		}
	}
}
