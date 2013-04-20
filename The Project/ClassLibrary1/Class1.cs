using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MergeTrees
{
   public class Node
    {
        public string value;
        public Node parent = null;
        public List<Node> children = new List<Node>();
        public void Add(params string[] vals)
        {
            children.AddRange(vals.Select(val => new Node() { value = val, parent = this }));
        }
        public Node this[string st]
        {
            get
            {
                return children.First(node => node == st);
            }
        }
        public static implicit operator string(Node node)
        {
            return node.value;
        }
    }
    public class Program
    {
        public static Node CopyTree(Node head, Node parent = null)
        {
            Node result = new Node { value = head.value, parent = parent };
            foreach (var child in head.children)
                result.children.Add(CopyTree(child, result));
            return result;
        }

       public static void MergeTrees(Node head1, Node head2)
        {
            foreach (var child2 in head2.children)
            {
                Node child1 = head1.children.FirstOrDefault(node => node.value == child2.value);
                if (child1 != null)
                    MergeTrees(child1, child2);
                else
                {
                    head1.Add(child2);
                    MergeTrees(head1.children.Last(), child2);
                }
            }
        }

       public static void Main(string[] args)
        {
            Node head1 = new Node { value = "A" };
            head1.Add("B", "C", "F");
            head1["C"].Add("D", "E");
            head1["F"].Add("G", "H", "I");

            Node head2 = new Node { value = "A" };
            head2.Add("B", "C");
            head2["C"].Add("D", "K", "L");

            Node result = CopyTree(head1);
            MergeTrees(result, head2);
        }



       public static Node ToNode(TreeNode source)
       {
           Node n = new Node();
           n.value = source.Text;
           if (source.Nodes.Count==0)
           {
               return n;
           }
           else
           {
               for (int i = 0; i < source.Nodes.Count-1; i++)
               {
                  // n.children.Add(ToNode(source.Nodes(i)));

               }
           }

           return n;
       }
    }
}