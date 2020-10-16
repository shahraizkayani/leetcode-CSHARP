public class Solution {
   public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0) return false;
            foreach (int[] row in matrix)
            {
                bool flag = false;

                int left = 0;
                int right = row.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left / 2);
                    if (row[mid] == target)
                    {
                        flag = true;
                        break;
                    }
                    if (row[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                        left = mid + 1;
                }
                if (flag == true) return true;
            }

            return false;

        }
}
