using OtusHomeWork30.Entities;

namespace OtusHomeWork30.xUnitTests
{
    public class HouseTests
    {
        [Fact]
        public void Copy_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GenerateHouse();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void Clone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GenerateHouse();

            // Act
            var actual = expected.Clone();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void Copy_FieldsAreCopied()
        {
            // Arrange
            var expected = GenerateHouse();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.Equal(expected.Price, actual.Price);
            Assert.Equal(expected.Square, actual.Square);
            Assert.Equal(expected.CountRooms, actual.CountRooms);
            Assert.Equal(expected.Floor, actual.Floor);
            Assert.Equal(expected.Floors, actual.Floors);
            Assert.Equal(expected.SquareRegion, actual.SquareRegion);
        }

        [Fact]
        public void Clone_FieldsAreCopied()
        {
            // Arrange
            var expected = GenerateHouse();

            // Act
            var actual = (House)expected.Clone();

            // Assert
            Assert.Equal(expected.Price, actual.Price);
            Assert.Equal(expected.Square, actual.Square);
            Assert.Equal(expected.CountRooms, actual.CountRooms);
            Assert.Equal(expected.Floor, actual.Floor);
            Assert.Equal(expected.Floors, actual.Floors);
            Assert.Equal(expected.SquareRegion, actual.SquareRegion);
        }

        [Fact]
        public void Copy_ChangeOriginObjectDoesNotChangeCopyObject()
        {
            // Arrange
            var expected = GenerateHouse();

            // Act
            var actual = expected.Copy();
            expected.CountRooms = expected.CountRooms + 1;

            // Assert
            Assert.NotEqual(expected.CountRooms, actual.CountRooms);
        }

        [Fact]
        public void Clone_ChangeOriginObjectDoesNotChangeCloneObject()
        {
            // Arrange
            var expected = GenerateHouse();

            // Act
            var actual = (House)expected.Clone();
            expected.CountRooms = expected.CountRooms + 1;

            // Assert
            Assert.NotEqual(expected.CountRooms, actual.CountRooms);
        }


        private House GenerateHouse()
        {
            return new House
            {
                CountRooms = 3,
                Floor = 4,
                Floors = 5,
                Price = 6_000_000,
                Square = 50,
                SquareRegion = 200
            };
        } 
    }
}