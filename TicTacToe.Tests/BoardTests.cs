using System;
using Xunit;

namespace TicTacToe.Tests
{
    public class BoardShould
    {
        [Fact]
        public void HaveLengthAndWidthOf3()
        {
            var board = new Board();
            var newBoard = board.Show;
            var expectedWidth = 3;
            var expectedLength = 3;

            // TODO: Change width and length
            var actualWidth = newBoard.Width;
            var actualLength = newBoard.Length;

            Assert.Equal(expectedWidth, actualWidth);
            Assert.Equal(expectedLength, actualLength);
        }
    }
}
