﻿using System;
using System.Collections.Generic;
using System.Text;
namespace BSTProblem
{
    class BinarySearchTree<T> where T : IComparable
    {
        T NodeData;
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        bool result = false;
        int leftCount = 0;
        int rightCount = 0;
        public BinarySearchTree(T NodeData)
        {
            this.NodeData = NodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine("Size of BST = " + (1 + leftCount + rightCount));
        }
        public bool SearchElement(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element " + node.NodeData + " in BST");
                return true;
            }
            else
                Console.WriteLine("Current element found in BST = {0}", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                SearchElement(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                SearchElement(element, node.rightTree);
            return result;
        }
    }
}
