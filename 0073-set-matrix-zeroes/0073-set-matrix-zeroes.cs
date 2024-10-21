public class Solution {
    public void SetZeroes(int[][] matrix) {
        int [][] tempMatrix = new int [matrix.Length][];

        for (int i = 0; i < matrix.Length; i++)
        {
            tempMatrix[i] = new int [matrix[i].Length];

            for (int j = 0; j < matrix[i].Length; j++)
            {
                tempMatrix[i][j] = matrix[i][j];
            }
        }

        for (int i = 0; i < tempMatrix.Length; i++)
        {
            for (int j = 0; j < tempMatrix[i].Length; j++)
            {
                if (tempMatrix[i][j] == 0)
                {
                    for (int r = 0; r < matrix[i].Length; r++)
                    {
                        matrix[i][r] = 0;
                    }
                    for (int c = 0; c < matrix.Length; c++)
                    {
                        matrix[c][j] = 0;
                    }
                }
            }
        }
    }
}