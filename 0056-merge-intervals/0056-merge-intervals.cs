public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> intervalsList = new List<int[]>(intervals);
        intervalsList.Sort((a, b) => a[0].CompareTo(b[0]));
        intervalsList.Sort((a, b) => a[1].CompareTo(b[1]));
        bool sorting = true;
        int count = 0;
        while (sorting == true)
        {
            for (int i = 0; i < intervalsList.Count - 1; i++)
            {
                if (intervalsList[i+1][0] <= intervalsList[i][1])
                {
                    if (intervalsList[i+1][0] < intervalsList[i][0])
                    {
                        intervalsList[i][0] = intervalsList[i+1][0];
                    }
                    if (intervalsList[i+1][1] > intervalsList[i][1])
                    {
                        intervalsList[i][1] = intervalsList[i+1][1];
                    }
                    //intervalsList[i][1] = intervalsList[i+1][1];
                    intervalsList.RemoveAt(i+1);
                    i--;
                    count++;
                }
            }
            if(count == 0)
            {
                break;
            }
            count = 0;
        }
      
        intervals = intervalsList.ToArray();
        return intervals;
    }
}