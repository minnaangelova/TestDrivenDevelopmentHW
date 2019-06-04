using HW4TDD;
using NUnit.Framework;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestFixture]
    public class StackTests
    {
       [Test]
       public void CreateObject()
        {
           Stack<int> stack = new Stack<int>(3);
            Assert.AreEqual(0, stack.Size);
        }

        [Test]
        public void PushPop()
        {
            Stack<int> stack = new Stack<int>(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int value = stack.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        public void NoMorePop()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Pop());
        }

        [Test]
        public void NoMorePush()
        {
            Stack<int> stack = new Stack<int>(3);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.Throws<ExceededSizeException>(() => stack.Push(4));
        }

        [Test]
        public void PeekException()
        {
            Stack<int> stack = new Stack<int>(3);

            stack.Push(1);
            stack.Push(2);

            int value = stack.Peek();

            Assert.AreEqual(2, value);
            Assert.AreEqual(2, stack.Size);
        }
    }
}
