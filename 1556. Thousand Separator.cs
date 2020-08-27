/*

Given an integer n, add a dot (".") as the thousands separator and return it in string format.

 

Example 1:

Input: n = 987
Output: "987"
Example 2:

Input: n = 1234
Output: "1.234"
Example 3:

Input: n = 123456789
Output: "123.456.789"
Example 4:

Input: n = 0
Output: "0"
 

Constraints:

0 <= n < 2^31







public static string ThousandSeparator(int n)
        {
            if (n < 1000)
            {
                return n.ToString();
            }
            var str = n.ToString();

            StringBuilder stringBuilder = new StringBuilder();

            var list1 = new List<int>() { 1, 4, 7, 10, 13, 16, 19, 22 };
            var list2 = new List<int>() { 2, 5, 8, 11, 14, 17, 20, 23 };

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 3 == 0 && i > 0 && str.Length % 3 == 0)
                {
                    stringBuilder.Append(".");
                }
                else if (list1.Contains(str.Length) && list1.Contains(i))
                {
                    stringBuilder.Append(".");

                }
                else if (list2.Contains(str.Length) && list2.Contains(i))
                {
                    stringBuilder.Append(".");

                }
                stringBuilder.Append(str[i].ToString());
            }

            return stringBuilder.ToString();
        }

*/
