using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class StackTests
    {
        [Test]
        public void Push_WhenObjIsNull_ArgumentNullException()
        {
            var stack = new Fundamentals.Stack<string>();


            Assert.That(()=>stack.Push(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Push_ValidObj_AddElementToTheStack()
        {
            var stack = new Fundamentals.Stack<int>();

            stack.Push(1);
            stack.Push(2);

            Assert.That(stack.Count, Is.EqualTo(2));
        }
        [Test]
        public void Count_StackIsEmpty_ReturnZero()
        {
            var stack = new Fundamentals.Stack<int>();

            
            Assert.That(stack.Count, Is.EqualTo(0));
        }
        [Test]
        public void Count_StackIsNotEmpty_ReturnTheNumberOfStackElements()
        {
            var stack = new Fundamentals.Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.That(stack.Count, Is.EqualTo(3));
        }

        [Test]
        public void Pop_CountIsEqualToZero_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<int>();

            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_CountIsGreaterThanZero_ReturnElementFromTheFrontOfTheStack()
        {
            // Arrange
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Pop();

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Pop_CountIsGreaterThanZero_RemoveElementFromTheFrontOfTheStack()
        {
            // Arrange
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            stack.Pop();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(1));
        }


        [Test]
        public void Peek_CountIsEqualToZero_ThrowsInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<int>();

            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_CountIsGreaterThanZero_ReturnTheFirstElementOnTheTop()
        {
            // Arrange
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Peek();

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Peek_CountIsGreaterThanZero_DonotRemoveTheElementOnTheTop()
        {
            // Arrange
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            stack.Peek();

            // Assert
            Assert.That(stack.Count, Is.EqualTo(2));

        }

    }
}
