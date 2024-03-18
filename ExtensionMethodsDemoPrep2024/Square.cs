using System;
namespace ExtensionMethodsDemoPrep2024
{
	public class Square
	{
		public int Side { get; set; }
		public Square(int side)
		{
			Side = side;
		}

		public void Display()
		{
			Console.WriteLine($"Square with side: {Side}");
		}
	}
}

