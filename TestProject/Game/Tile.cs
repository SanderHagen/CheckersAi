using CheckersAI.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Game
{
    [TestClass]
    public class TileTest
    {
        [TestMethod]
        public void TestInitializeTileRow1()
        {
            Tile tile = new Tile(new Board(), 0, 0, 1, 2);
            Assert.AreEqual(Tile.WhitePiece, tile.GetPieceColor());
        }

        [TestMethod]
        public void TestInitializeTileRow2()
        {
            Tile tile = new Tile(new Board(), 0, 0, 2, 2);
            Assert.AreEqual(0, tile.GetPieceColor());
        }

        [TestMethod]
        public void TestInitializeTileRow0()
        {
            Tile tile = new Tile(new Board(), 0, 0, 0, 3);
            Assert.AreEqual(Tile.WhitePiece, tile.GetPieceColor());
        }

        [TestMethod]
        public void TestEvenColumnIsEven()
        {
            Tile tile = new Tile(new Board(),0, 0, 0, 2);
            Assert.AreEqual(true, tile.EvenColumn());
        }

        [TestMethod]
        public void TestEvenColumnIsUneven()
        {
            Tile tile = new Tile(new Board(),0, 0, 0, 3);
            Assert.AreEqual(false, tile.EvenColumn());
        }
    }
}
