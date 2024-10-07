public class Solution {
    public void Rotate(int[][] matrix) {
        int[] temp = new int[matrix.Length * matrix[0].Length];
        int columnValue = matrix[0].Length - 1;
        int tempIndex = temp.Length - 1;
        int counter = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            temp[tempIndex] = matrix[i][columnValue];
            counter++;
            tempIndex--;
            
            if (counter == matrix.Length)
            {
                i = -1; 
                columnValue--;
                counter = 0;
            }
            if (columnValue < 0)
            {
                break;
            }
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = temp[counter];
                counter++;
            }
        }
    }
}
