using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stackexercise6;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            //push some item then count
            Stack s = new Stack(10);
            s.Push(7);
            s.Push(6);
            Assert.AreEqual(2, s.Count());            
        }
        
        [TestMethod]
        public void Testpop()
        {
            //put some item then pop it
            Stack s = new Stack(10);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.pop());
            Assert.AreEqual(2, s.pop());
        }
        [TestMethod]
        public void TestPeek()
        {

            Stack s = new Stack(10);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.peek());
            Assert.AreEqual(3, s.Count());
        }
        [TestMethod]
        public void TestClear()
        {
            Stack s = new Stack(10);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Clear();
            Assert.AreEqual(0, s.Count());
        }
    }
}
