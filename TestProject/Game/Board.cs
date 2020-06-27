using CheckersAI.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Game
{
    [TestClass]
    public class BoardTest
    {
        Board board;

        [TestInitialize]
        public void createBoard()
        {
            board = new Board();

        }

        [TestCleanup]
        public void cleanup()
        {
            board = null;
        }

        [TestMethod]
        public void TestGenerateBoard()
        {

            Assert.IsNotNull(board.GetTileAtPosition(0, 0));
        }

        [TestMethod]
        public void TestGetTileAtPosition()
        {
            Assert.AreEqual(Tile.WhitePiece, board.GetTileAtPosition(0, 1).GetPieceColor());
        }

        [TestMethod]
        public void TestGetTileAtInvalidPosition()
        {
            var exception = Assert.ThrowsException<IndexOutOfRangeException>(() => board.GetTileAtPosition(-10, 1));
        }
    }
}
