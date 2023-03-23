namespace RangeStruct.UnitTests
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        public void ConstructorTest()
        {
            var range = new Range(-20,18);
            Assert.That(range.LeftBorder, Is.EqualTo(-20));
            Assert.That(range.RightBorder, Is.EqualTo(18));
        }
        [TestCase(10,2)]
        [TestCase(0,-1)]
        [TestCase(-30, -35)]
        public void RightBorderSet_BigThenLeftValue_ArgumentException(int leftBorder,int rightBorder)
        {
            var range = new Range();
            Assert.That(() => (range.LeftBorder = leftBorder, range.RightBorder = rightBorder), Throws.ArgumentException);
        }
        [TestCase(2, 10, 8)]
        [TestCase(0, 3, 3)]
        [TestCase(-15, 0, 15)]
        [TestCase(0, 0, 0)]
        public void CountTest(int leftBorder, int rightBorder, int result)
        {
            var range = new Range(leftBorder, rightBorder);
            Assert.That(range.Count, Is.EqualTo(result));
        }
        [TestCase(15, 42, "[15; 42)\"")]
        [TestCase(0, 0, "[0; 0)\"")]
        [TestCase(-15, 42, "[-15; 42)\"")]
        public void ToStringTest(int leftBorder, int rightBorder, string result)
        {
            var range = new Range(leftBorder, rightBorder);
            Assert.That(range.ToString(), Is.EqualTo(result));

        }
        [TestCase(30, 30, true)]
        [TestCase(30, 15, false)]
        public void Equals_TwoRanges_ExpectedResult(int leftBorder1, int leftBorder2, bool result)
        {
            var range1 = new Range(leftBorder1, 100);
            var range2 = new Range(leftBorder2, 100);
            Assert.That(range1.Equals(range2), Is.EqualTo(result));
        }
        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var range = new Range();
            var smth = new object();
            Assert.That(() => range.Equals(smth), Throws.ArgumentException);
        }
        [Test]
        public static void GetHashCodeTest()
        {
            var x = new Range(18, 45);
            var y = new Range(18, 45);
            var z = new Range(-30, 45);
            Assert.That(x.Equals(y), Is.True);
            Assert.That(x.Equals(z), Is.False);
        }
        [TestCase(10, 30, 27, true)]
        [TestCase(-10, 35, 0, true)]
        [TestCase(0, 0, 0, false)]
        [TestCase(2, 10, 11, false)]
        public void IsContains_ExpectedResult(int leftBorder, int rightBorder, int number, bool result)
        {
            var range = new Range(leftBorder, rightBorder);
            var numb = number;
            Assert.That(range.IsContains(numb,range), Is.EqualTo(result));
        }
        [Test]
        public static void ComparisonTest()
        {
            var x = new Range(9, 18);
            var y = new Range(9, 18);
            var z = new Range(-30, 45);
            Assert.That(x == y, Is.True);
            Assert.That(x != y, Is.False);
            Assert.That(x == z, Is.False);
            Assert.That(x != z, Is.True);
        }
        [TestCase(3, 5, 0, 10, true)]
        [TestCase(0,10, 3, 5, true)]
        [TestCase(0, 1, 1, 2, false)]
        public void AdditionTest(int leftBorder1, int rightBorder1, 
        int leftBorder2, int rightBorder2,bool result)
        {
            var range1 = new Range(leftBorder1, rightBorder1);
            var range2 = new Range(leftBorder2, rightBorder2);
            Assert.That(range1 & range2, Is.EqualTo(result));
        }
        [TestCase(3, 5, 0, 10, 0, 10 )]
        [TestCase(-10, 10, 3, 50, -10, 50)]
        [TestCase(0, 1, 1, 2, 0,2)]
        [TestCase(0, 0, 0, 0, 0, 0)]
        public void SmallestOverallRange(int leftBorder1, int rightBorder1,
        int leftBorder2, int rightBorder2, 
        int res_leftBorder, int res_rightBorder)
        {
            var range1 = new Range(leftBorder1, rightBorder1);
            var range2 = new Range(leftBorder2, rightBorder2);
            var res_range = new Range(res_leftBorder, res_rightBorder);
            Assert.That(range1 | range2, Is.EqualTo(res_range));
        }
    }
}