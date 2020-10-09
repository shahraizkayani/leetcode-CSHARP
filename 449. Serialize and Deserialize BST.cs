/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
  public static string dataser = "";
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
      if(root ==null) return "";
        dataser ="";
       Preorder(root);
       
        return dataser.TrimEnd();
        
    }
    public static void Preorder(TreeNode root){
            if(root == null) return ;
            dataser += root.val + " ";
            Preorder(root.left);
            
            Preorder(root.right);
            
        }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == "") return null;
       
        TreeNode root =null;
        string[] array = data.Split(' ');
        foreach(string ch in array){
            int datas = int.Parse(ch);
            root = insertRec(root,datas);
        }
        return root;
            TreeNode insertRec(TreeNode root, int key)
            {

                if (root == null)
                {
                    root = new TreeNode(key);
                    return root;
                }

                if (key < root.val)
                  root.left =  insertRec(root.left, key);
                else if (key > root.val)
                 root.right =   insertRec(root.right, key);


                return root;
            }
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// String tree = ser.serialize(root);
// TreeNode ans = deser.deserialize(tree);
// return ans;
