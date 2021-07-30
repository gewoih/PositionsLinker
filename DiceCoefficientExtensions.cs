using System.Collections.Generic;

namespace Search
{
	public static class DiceCoefficientExtensions
	{
		public static double DiceCoefficient(this string strA, string strB)
		{
			HashSet<string> setA = new HashSet<string>();
			HashSet<string> setB = new HashSet<string>();

			for (int i = 0; i < strA.Length - 1; ++i)
				setA.Add(strA.Substring(i, 2));

			for (int i = 0; i < strB.Length - 1; ++i)
				setB.Add(strB.Substring(i, 2));

			HashSet<string> intersection = new HashSet<string>(setA);
			intersection.IntersectWith(setB);

			return (2.0 * intersection.Count) / (setA.Count + setB.Count);
		}
	}
}
