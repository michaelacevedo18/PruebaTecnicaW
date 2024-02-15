using Chess.Repository;
using Xunit;

namespace TestProject1
{
    public class RepositoryServiceChessTests
    {
        //[Theory]
        //[InlineData("1b", new[] { "3a", "3c" })]
        //[InlineData("1g", new[] { "2e", "3h", "3f" })]
        //[InlineData("8b", new[] { "6a", "6c" })]
        //[InlineData("8g", new[] { "7e", "6f", "7h" })]
        //public void GetKnightMoves_ReturnsExpectedMoves(string position, string[] expectedMoves)
        //{
        //    // Arrange
        //    var service = new RepositoryServiceChess();

        //    // Act
        //    var actualMoves = service.GetKnightMoves(position);

        //    // Assert
        //    Assert.Equal(expectedMoves, actualMoves);
        //}

        //[Fact]
        //public void GetKnightMoves_InvalidPosition_ThrowsArgumentException()
        //{
        //    // Arrange
        //    var service = new RepositoryServiceChess();
        //    var invalidPosition = "invalid";

        //    // Act & Assert
        //    Assert.Throws<ArgumentException>(() => service.GetKnightMoves(invalidPosition));
        //}
        
        [Fact]
        public void Position_1b_Test()
        {
            // Arrange
            var serv = new RepositoryServiceChess();
            var position = "1b";
            var expectedMoves = new[] { "3a", "3c" };
            // Act
            var result=serv.GetKnightMoves(position);

                // Assert
                
                
            Assert.Equal(expectedMoves, result);

        }

    }
}
