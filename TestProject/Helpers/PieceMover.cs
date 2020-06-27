using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckersAI.Game;

namespace TestProject.Helpers
{
    /// <summary>
    /// Summary description for PieceMover
    /// </summary>
    [TestClass]
    public class PieceMover
    {
        [TestMethod]
        public void TestMovePieceValid()
        {
            Board board = new Board();
            Tile tileToMove = board.GetTileAtPosition(3, 0);
            int originalX = tileToMove.Location.X;
            int originalY = tileToMove.Location.Y;

            Tile desiredTile = board.GetTileAtPosition(4, 1);
            int destX = desiredTile.Location.X;
            int destY = desiredTile.Location.Y;

            board.MovePiece(board.GetTileAtPosition(3, 0), 4, 1);

            Assert.AreEqual(Tile.WhitePiece, board.GetTileAtPosition(4, 1).GetPieceColor());
            Assert.AreEqual(destX, board.GetTileAtPosition(4, 1).Location.X);
            Assert.AreEqual(destY, board.GetTileAtPosition(4, 1).Location.Y);
            Assert.AreEqual(originalX, board.GetTileAtPosition(3, 0).Location.X);
            Assert.AreEqual(originalY, board.GetTileAtPosition(3, 0).Location.Y);
            Assert.AreEqual(0, board.GetTileAtPosition(3, 0).GetPieceColor());
        }
    }
}
