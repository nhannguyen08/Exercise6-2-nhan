using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stackexercise6;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Stack s = new Stack(10);
            s.Push(7);
            s.Push(6);
            Assert.AreEqual(6, s.pop());            
        }
    }
}
