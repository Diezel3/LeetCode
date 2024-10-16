public class Solution {
    public int[][] GenerateMatrix(int n) {
        int nSquare = n * n;
        int [][] matrix = new int [n][];
        for (int i = 0; i < n; i++) 
        {
        matrix[i] = new int[n];
        }
        for (int i = 0; i < n; i++)
        {
            matrix[0][i] = i + 1; // First row filled
        }
        int lastFilledColumn = n - 1;
        int lastFilledNumber = n;
        int lastFilledRow = 0;
        bool operationEvaluated = true;
        string direction = "down";
        int temp = 0;

        while (operationEvaluated == true)
        {
            operationEvaluated = false;
            switch (direction)
            {
                case "down":
                {
                    if (lastFilledRow < n)
                    {
                        for (int i = lastFilledRow; i < n; i++)
                        {
                            if (matrix[i][lastFilledColumn] > 0)
                            {
                                continue;
                            }
                            lastFilledNumber++;
                            matrix[i][lastFilledColumn] = lastFilledNumber;
                            operationEvaluated = true;
                            temp = i;
                        }
                        lastFilledRow = temp;
                        direction = "left";
                    }
                    break;
                }
                    
                case "left":
                {
                    if (lastFilledColumn >= 0)
                    {
                        for (int i = lastFilledColumn; i >= 0; i--)
                        {
                            if (matrix[lastFilledRow][i] > 0)
                            {
                                continue;
                            }
                            lastFilledNumber++;
                            matrix[lastFilledRow][i] = lastFilledNumber;
                            operationEvaluated = true;
                            temp = i;
                        }
                        lastFilledColumn = temp;
                        direction = "up";
                    }
                    break;
                }
                case "up":
                {
                    if (lastFilledRow >= 0)
                    {
                        for (int i = lastFilledRow; i >= 0; i--)
                        {
                            if (matrix[i][lastFilledColumn] > 0)
                            {
                                continue;
                            }
                            lastFilledNumber++;
                            matrix[i][lastFilledColumn] = lastFilledNumber;
                            operationEvaluated = true;
                            temp = i;
                        }
                        lastFilledRow = temp;
                        direction = "right";
                    }
                    break;
                }
                case "right":
                {
                    if (lastFilledColumn < n)
                    {
                        for (int i = lastFilledColumn; i < n; i++)
                        {
                            if (matrix[lastFilledRow][i] > 0)
                            {
                                continue;
                            }
                            lastFilledNumber++;
                            matrix[lastFilledRow][i] = lastFilledNumber;
                            operationEvaluated = true;
                            temp = i;
                        }
                        lastFilledColumn = temp;
                        direction = "down";
                    }
                    break;
                }
                default:
                {
                    operationEvaluated = false;
                    break;
                }
            }
        }


        return matrix;



        //Fill up to right (run the iteration till the end and if you meet any number, stop.) 

        // Fill up downward (run the iteration considering the last filled index, same inner index number but a different row below (outer index +1) and when you get to the end or meet a number, stop.)
        // Fill up to the left (run the iteration considering the last filled index, move an index lower (-1) on the same row and when you get to the end or meet a number, stop.)
        // Fill up upward (run the iteration considering the last filled index, same inner index number but a different row above (outer index -1) and when you get to the end or meet a number, stop.)
        // Fill up to the right (run the iteration considering the last filled index, move an index higher (+1) on the same row and when you get to the end or meet a number, stop.)

        // Engulf all in a condition where True shows that an operation (fixing a number in a box) evaluated at least once and if it doesn't, it evaluates as false which falls out of the while loop. So at the beginning of the while loop, it should always change it to false and if it evaluates, change it to true.
        // Use a switch case to always tell what evaluation takes place next - Down -> Left -> Up -> Right (Note: Right iteration evaluates separately first before the switch case)

    }
}