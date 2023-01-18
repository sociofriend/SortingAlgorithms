using System;
namespace SortingAlgorithms
{
	public class SelectionSort
	{
		public List<int> DataSelectAndSort (List<int> data)
		{
			int marker = 0;
			while(marker < data.Count)
			{
				for(int i = marker+1; i < data.Count; i++)
				{
					if (data[marker] > data[i])
					{
						(data[marker], data[i]) = (data[i], data[marker]);
                    }
				}
				marker++;
			}	
			return data;
		}
	}
}

