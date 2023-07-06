using NUnit.Framework;
using System.Data;
using System.Linq;
using TestNinja.Fundamentals;

namespace Unit.Twst
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp() 
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_RetrunTheSumOfArguments()
        {
            var result = _math.Add(2, 4);

            Assert.That(result, Is.EqualTo(6));

        
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_RetrunTheGreaterArguments(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        [Ignore("Because I wanted to")]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstAgrument()
        {
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Because I wanted to")]

        public void Max_SecondArgumentIsGreater_ReturnsTheSecondAgrument()
        {
            var result = _math.Max(2, 4);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        [Ignore("Because I wanted to")]

        public void Max_ArgumentsAreEqual_ReturnsTheSameAgrument()
        {
            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //general way
            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

        }


    }

}
