using System;
using travelAgency;
using NUnit.Framework;


namespace travelAgency.UnitTests
{
    [TestFixture]
    class TouristUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var john = CreateTestTourist();

            Assert.AreEqual("John", john.Name);
            Assert.AreEqual("Johnson", john.Surname);
            Assert.AreEqual("123456", john.TourCode);
            Assert.AreEqual("06:00", john.StartTime);
            Assert.AreEqual("6", john.TourDuration);
            Assert.AreEqual("12:00", john.FinishTime);
            Assert.AreEqual("200$", john.TourPrise);
            Assert.AreEqual(PaymentType.Cash, john.Payment);
        }
        [Test]
        public void ToString_Tourist_NameSpaceSurname()
        {
            var john = CreateTestTourist();

            Assert.AreEqual("John Johnson", john.ToString());
        }
        private Tourist CreateTestTourist()
        {
            return new Tourist("123456", "John", "Johnson", "06:00", "6", "12:00", "200$", PaymentType.Cash);
        }
    }
}
