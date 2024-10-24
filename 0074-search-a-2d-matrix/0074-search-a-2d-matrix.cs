public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        for (int i = 0; i < matrix.Length; i++)
        {
            int left = 0;
            int right = matrix[i].Length - 1;
            int mid = (right + left) / 2;
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (target == matrix[i][mid] || target == matrix[i][left] || target == matrix[i][right])
                {
                    return true;
                }
                if (target > matrix[i][left] && target < matrix[i][mid])
                {
                    right = mid;
                    mid = (right + left) / 2;
                    continue;
                }
                if (target > matrix[i][mid] && target < matrix[i][right])
                {
                    left = mid;
                    mid = (right + left) / 2;
                    continue;
                }
                break;
            }
        }
        return false;
    }
}