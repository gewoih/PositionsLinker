using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Search;

namespace PositionsLinker
{
	public class Position
	{
		public string article { get; set; }
		public string name { get; set; }
		public SortedDictionary<string, double> foundMatches { get; set; }

		public Position(string article, string name)
		{
			this.article = article;
			this.name = name;
			foundMatches = new SortedDictionary<string, double>();
		}

		public void FindMatches(SortedSet<string> sourcePositions)
		{
			SearchPositions(sourcePositions);
		}

		public void SearchPositions(SortedSet<string> sourcePositions)
		{
			SortedDictionary<string, double> resultsDictionary = new SortedDictionary<string, double>();

			double diceMax = 0;
			double lcsMax = 0;

			foreach (var item in sourcePositions)
			{
				double diceResult = this.name.DiceCoefficient(item);
				double lcsResult = this.name.LongestCommonSubsequence(item);

				if (diceResult + lcsResult >= diceMax + lcsMax)
				{
					if (!resultsDictionary.ContainsKey(item))
						resultsDictionary.Add(item, diceResult + lcsResult);
					if (diceResult >= diceMax)
						diceMax = diceResult;
					if (lcsResult >= lcsMax)
						lcsMax = lcsResult;
				}
			}
			this.foundMatches = resultsDictionary;
		}
	}
}
