using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Unit.Twst
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert

            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUSerCancellingTheReservation_ReturnsTrue()
        {
            var user = new User { IsAdmin = false };
            //Arrange
            var reservation = new Reservation();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUSerCancellingTheReservation_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();
            reservation.MadeBy = new User();

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert

            Assert.IsFalse(result);
        }
    }
}
