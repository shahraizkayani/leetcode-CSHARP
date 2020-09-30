/*




*/
public class Solution {
    public int[][] Transpose(int[][] a) {
        
            List<List<int>> list = new List<List<int>>();
          
           
            for (int i = 0; i < a[0].Length; i++)
            {
                List<int> result = new List<int>();
                for (int j = 0; j <a.Length; j++)
                {

                    result.Add(a[j][i]);
                }
                list.Add(result);
            }

                
                 return list.Select(a => a.ToArray()).ToArray();
    }
}
