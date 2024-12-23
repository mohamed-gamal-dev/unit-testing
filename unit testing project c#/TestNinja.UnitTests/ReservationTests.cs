using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrang
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            // Assert

            //Assert.IsTrue(result);
            //Assert.That(result == true);
            Assert.That(result, Is.True);
            
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrang
            var user = new User();
            var reservation = new Reservation() { MadeBy=user};
            
            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);

        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrang
            var reservation = new Reservation() { MadeBy = new User()};
            var user = new User();

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            //Assert.IsFalse(result);
            Assert.That(result, Is.False);


        }
    }
}