public class Solution {
    public int MySqrt(int x) {
    if (x == 0) return 0;

    int left = 1;
    int right = x;
    int closest = 0;  // To track the closest value

    while (left <= right) 
    {
        int mid = left + (right - left) / 2;
        long square = (long)mid * mid;  // Using long to handle large numbers

        if (square == x) 
        {
            return mid;  // Square root found
        } 
        else if (square < x) 
        {
            closest = mid;

            // Checking if mid + 1 is the closest square root
            long nextSquare = (long)(mid + 1) * (mid + 1);
            if (nextSquare == x) 
            {
                return mid + 1;  // Square root found
            } 
            else if (nextSquare > x) 
            {
                return mid;  // mid is the closest integer square root
            }

            left = mid + 1;  // Narrow the search to the upper half
        } 
        else 
        {
            // Additional check: see if mid - 1 is the closest square root
            long prevSquare = (long)(mid - 1) * (mid - 1);
            if (prevSquare == x) 
            {
                return mid - 1;  // Square root found
            } 
            else if (prevSquare < x) 
            {
                return mid - 1;  // mid - 1 is the closest integer square root
            }

            right = mid - 1;  // Narrow the search to the lower half
        }
    }

    return closest;  // Closest value found
}

}