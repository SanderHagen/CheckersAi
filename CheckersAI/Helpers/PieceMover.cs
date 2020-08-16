using CheckersAI.Game;
using System;

namespace CheckersAI.Helpers
{
    public static class PieceMover
    {
        public static void MovePiece(Board board, Tile pieceToMove, int desiredRow, int desiredColumn)
        {
            double desiredColor = pieceToMove.GetPieceColor();
            board.board[pieceToMove.Row, pieceToMove.Column].SetPieceColor(0);

            board.board[desiredRow, desiredColumn].SetPieceColor(desiredColor);
        }

        public static bool IsValidMove(Board board, Tile pieceToMove, int desiredRow, int desiredColumn)
        {
            return IsTileEmpty(board.board, desiredRow, desiredColumn) &&
                IsTileForwards(pieceToMove, desiredRow) &&
                IsTileDiagonal(pieceToMove, desiredColumn) &&
                PlayerOwnsTile(pieceToMove);
        }

        private static bool PlayerOwnsTile(Tile pieceToMove)
        {
            return BlackPlayerTurnAndOwnsTile(pieceToMove) ||
                WhitePlayerTurnAndOwnsTile(pieceToMove);
        }

        private static bool WhitePlayerTurnAndOwnsTile(Tile pieceToMove)
        {
            return GameEngine.currentPlayer == Players.White && pieceToMove.GetPieceColor() > 0;
        }

        private static bool BlackPlayerTurnAndOwnsTile(Tile pieceToMove)
        {
            return GameEngine.currentPlayer == Players.Black && pieceToMove.GetPieceColor() < 0;
        }

        private static bool IsTileEmpty(Tile[,] board, int row, int column)
        {
            return board[row, column].GetPieceColor() == 0;
        }

        private static bool IsTileForwards(Tile pieceToMove, int desiredRow)
        {
            if (pieceToMove.GetPieceColor() == Tile.WhitePiece) return desiredRow > pieceToMove.Row;
            if (pieceToMove.GetPieceColor() == Tile.BlackPiece) return desiredRow < pieceToMove.Row;

            return false;
        }

        private static bool IsTileDiagonal(Tile piece, int column)
        {
            return (piece.Column - 1) == column || (piece.Column + 1) == column;
        }
    }
}
