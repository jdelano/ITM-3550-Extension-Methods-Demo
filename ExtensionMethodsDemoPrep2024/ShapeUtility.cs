using System;
namespace ExtensionMethodsDemoPrep2024
{
	public static class ShapeUtility
	{

		public static Square Add(this Square first, Square second)
		{
			return new Square(first.Side + second.Side);
		}

		public static int Square(this int num)
		{
			return num * num;
		}

		public static void Display(this Square square, bool test)
		{
			Console.WriteLine("Ha Ha!");
		}
	}
}

