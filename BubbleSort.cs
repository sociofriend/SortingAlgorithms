using System;
namespace SortingAlgorithms
{
	public class BubbleSort
	{

		public List<int> SortBubles(List<int> bubbles)
		{
			bool swapped = true;

			while (swapped)
			{
				swapped = false;
				for (int i = 0; i < bubbles.Count - 1; i++)
				{
					if (bubbles[i] > bubbles[i + 1])
					{
						(bubbles[i], bubbles[i + 1]) = (bubbles[i + 1], bubbles[i]);
						swapped = true;
					}
				}
			}
			return bubbles;
		}

		public List<int> SortBubles1(List<int> bubbles)
		{
			for (int i = 0; i < bubbles.Count-1; i++)
				for (int j = 0; j < bubbles.Count -i - 1; j++)
					{
						if (bubbles[j] > bubbles[j + 1])
						{
							(bubbles[j], bubbles[j + 1]) = (bubbles[j + 1], bubbles[j]);
						}
					}
			return bubbles;
		}
	}
}

