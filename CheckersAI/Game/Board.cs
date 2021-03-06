﻿using CheckersAI.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckersAI.Game
{
    public partial class Board : UserControl
    {
        private static readonly int beginPositionX = 10;
        private static readonly int beginPositionY = 10;
        private static readonly int MaxRows = 10;
        private static readonly int MaxColumns = 10;

        private Tile originalTile;
        private bool previousTileSelected = false;
        public Tile[,] board;

        public event EventHandler PlayerTurnDone;

        public Board()
        {
            GenerateTiles();
            InitializeComponent();
        }

        private void GenerateTiles()
        {
            int x = beginPositionX;
            int y = beginPositionY;
            board = new Tile[MaxRows, MaxColumns];

            for (int Row = 0; Row < MaxRows; Row++)
            {
                for (int Column = 0; Column < MaxColumns; Column++)
                {
                    DrawTile(Row, Column, x, y);
                    x += Tile.width;
                }
                y += Tile.height;
                x = beginPositionX;
            }
        }

        private void DrawTile(int row, int column, int x, int y)
        {
            Tile tile = new Tile(this, x, y, row, column);
            tile.OnTileSelected += new EventHandler(tile_OnTileSelected);
            Color color = Color.White;

            if (tile.EvenRow())
            {
                if (!tile.EvenColumn()) color = Color.Black;
            }
            else if (tile.EvenColumn()) color = Color.Black;

            tile.SetColor(color);
            board[row, column] = tile;
            Controls.Add(tile);
        }

        public Tile GetTileAtPosition(int row, int column)
        {
            return board[row, column];
        }

        public void MovePiece(Tile pieceToMove, int desiredRow, int desiredColumn)
        {
            PieceMover.MovePiece(this, pieceToMove, desiredRow, desiredColumn);
        }

        private void Board_Click(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private void tile_OnTileSelected(object sender, EventArgs e)
        {
            if(GameEngine.currentPlayer == Players.Black)
            {
                return;
            }

            Tile tile = (Tile)sender;
            if (previousTileSelected)
            {
                if (!PieceMover.IsValidMove(this, originalTile, tile.Row, tile.Column))
                {
                    previousTileSelected = false;
                    return;
                }

                PieceMover.MovePiece(this, originalTile, tile.Row, tile.Column);
                previousTileSelected = false;
                PlayerTurnDone?.Invoke(this, null);

                return;
            }
            originalTile = tile;
            previousTileSelected = true;
        }
    }
}
