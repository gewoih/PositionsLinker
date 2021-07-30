using System;

namespace Search
{
	public static class LongestCommonSubsequenceExtensions
	{
		public static double LongestCommonSubsequence(this string s1, string s2)
		{
			if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2)) 
				return 0;

			s1 = s1.ToLower();
			s2 = s2.ToLower();

			int inputLen = s1.Length;
			int comparedToLen = s2.Length;

			int[,] lcs = new int[inputLen + 1, comparedToLen + 1];
			int[,] w = new int[inputLen + 1, comparedToLen + 1];
			int i, j;

			for (i = 0; i <= inputLen; ++i)
				lcs[i, 0] = 0;

			for (j = 0; j <= comparedToLen; ++j)
				lcs[0, j] = 0;

			for (i = 1; i <= inputLen; ++i)
			{
				for (j = 1; j <= comparedToLen; ++j)
				{
					if (s1[i - 1].Equals(s2[j - 1]))
					{
						int k = w[i - 1, j - 1];
						lcs[i, j] = lcs[i - 1, j - 1] + Square(k + 1) - Square(k);
						w[i, j] = k + 1;
					}
					else
						lcs[i, j] = lcs[i - 1, j - 1];

					if (lcs[i - 1, j] >= lcs[i, j])
					{
						lcs[i, j] = lcs[i - 1, j];
						w[i, j] = 0;
					}

					if (lcs[i, j - 1] >= lcs[i, j])
					{
						lcs[i, j] = lcs[i, j - 1];
						w[i, j] = 0;
					}
				}
			}
			double p = lcs[inputLen, comparedToLen];

			double coef = p / (inputLen * comparedToLen);
			return coef;
		}

		private static int Square(int p)
		{
			return p * p;
		}
	}
}
