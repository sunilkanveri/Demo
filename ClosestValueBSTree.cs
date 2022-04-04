using System.Collections.Generic;
using System;


namespace Programs
{
    class BSTree
    {
        int FindClosestValueInBst(BST tree, int target)
        {
            return ClosestValueBST(tree, target, tree.value);
        }
        int ClosestValueBST(BST tree, int target, int closest)
        {
            if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
            {
                closest = tree.value;
            }
            if (tree.left != null && target < tree.value)
            {
                return ClosestValueBST(tree.left, target, closest);
            }
            else if (tree.right != null && target > tree.value)
            {
                return ClosestValueBST(tree.right, target, closest);
            }
            else
            {
                return closest;
            }
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;
            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}
