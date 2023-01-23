using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int input_a = 1;
            int input_b = 2;

            int output = Operations.Add(input_a, input_b);

            Assert.AreEqual(input_a + input_b, output);
        }
    }
}
