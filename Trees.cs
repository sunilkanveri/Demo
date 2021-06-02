using System;
using System.Collections.Generic;

namespace Programs
{
    partial class Tree{
        public int value;
        Tree leftNode;
        Tree rightNode;
        public Tree(int value){
            this.value = value;
        }
        public Tree InsertNode(int value){
            var newNode = new Tree(value);
            if(value<this.value){
                this.leftNode = newNode;
            }else{
                this.rightNode = newNode;
            }
            
            return this;
        }
        public Tree RemoveNode(int value){
        return this;

        }
        public List<int> TraverseTree(Tree root){
            List<int> treeValues = new List<int>();
            if(root.leftNode==null && root.rightNode==null){
                treeValues.Add(root.value);
            }
                
            TraverseTree(root.leftNode);
            TraverseTree(root.rightNode);
            return treeValues;
        }
    }
}