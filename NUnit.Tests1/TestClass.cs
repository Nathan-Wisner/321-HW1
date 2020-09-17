// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using _321HW;
using System;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [SetUp]
        public void Init()
        {
            
        }

        [Test]
        [Category("pass")]
        public void BSTInsertTest()
        {
            List<int> testing = new List<int>();
            testing.Add(1);
            testing.Add(2);
            testing.Add(3);
            testing.Add(4);
            testing.Add(7);
            testing.Add(9);

            BST tree = new BST();

            foreach (int s in testing)
            {
                tree.Add(s, ref tree.Root);
            }

            List<int> treeList = new List<int>();

            tree.TraverseInOrder(ref tree.Root, ref treeList);

            List<int> correctList = new List<int>();
            correctList.Add(1);
            correctList.Add(2);
            correctList.Add(3);
            correctList.Add(4);
            correctList.Add(7);
            correctList.Add(9);

            Assert.AreEqual(correctList, treeList);
        }

        [Test]
        [Category("pass")]
        public void CorrectSize()
        {
            List<int> testing = new List<int>();
            testing.Add(1);
            testing.Add(2);
            testing.Add(3);
            testing.Add(4);
            testing.Add(7);
            testing.Add(9);

            BST tree = new BST();

            foreach (int s in testing)
            {
                tree.Add(s, ref tree.Root);
            }

            List<int> treeList = new List<int>();

            tree.TraverseInOrder(ref tree.Root, ref treeList);

            List<int> correctList = new List<int>();
            correctList.Add(1);
            correctList.Add(2);
            correctList.Add(3);
            correctList.Add(4);
            correctList.Add(7);
            correctList.Add(9);

            Assert.AreEqual(correctList.Count, treeList.Count);
        }

        [Test]
        [Category("pass")]
        public void EmptyListTest()
        {
            BST tree = new BST();

            List<int> treeList = new List<int>();

            tree.TraverseInOrder(ref tree.Root, ref treeList);

            List<int> correctList = new List<int>();

            Assert.AreEqual(correctList.Count, treeList.Count);
        }

    }
}
