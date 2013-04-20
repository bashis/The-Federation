using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace csharp_test
{
    public class MergerKing
    {
    public static List<T> merge<T>(T into, IEnumerable<T> other, Comparison<T> cmp, Func<T, IEnumerable<T>> GetChildren) where T : class
        {
            var result = new List<T>();

            foreach (T e in other)
            {
                var r = result.SingleOrDefault(_ => cmp(_, e) == 0);
                if (r != default(T))
                    result.AddRange(merge(r, GetChildren(e), cmp, GetChildren));
                else
                    result.Add(e);
            }

            return result;
        }

        public static List<TreeNode> SimpleMerge(TreeNode one, IEnumerable<TreeNode> other)
        {
        return merge<TreeNode>(one, other, (t1, t2) => string.Compare(t1.Text, t2.Text), t => t.Nodes.Cast<TreeNode>());
        }
   }
}

