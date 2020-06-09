using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CheckersAI.Game
{
    public partial class Tile : UserControl
    {
        public static readonly int height = 50;
        public static readonly int width = 50;
        public static readonly double WhitePiece = 0.5;
        public static readonly double BlackPiece = -0.5;

        private Board board;
        private int x;
        private int y;
        private double pieceColor = 0;

        public int Row { get; set; }
        public int Column { get; set; }

        public event EventHandler OnTileSelected;

        public Tile(Board board, int x, int y, int row, int column) : base()
        {
            InitializeComponent();
            Location = new Point(x, y);
            this.x = x;
            this.y = y;
            this.Row = row;
            this.Column = column;
            Width = width;
            Height = height;
            CalculateStartingValue();
        }

        public Tile(Tile tile)
        {
            InitializeComponent();
            board = tile.board;
            Location = new Point(tile.x, tile.y);
            x = tile.x;
            y = tile.y;
            Row = tile.Row;
            Column = tile.Column;
            Width = width;
            Height = height;
            pieceColor = tile.pieceColor;
        }

        public void SetColor(Color color)
        {
            BackColor = color;
        }

        public void SetPieceColor(double value)
        {
            this.pieceColor = value;
        }

        public double GetPieceColor()
        {
            return pieceColor;
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            OnTileSelected?.Invoke(this, null);            
        }

        private void CalculateStartingValue()
        {
            if (Row < 4)
            {
                if (EvenRow() && !EvenColumn()) pieceColor = WhitePiece;

                else if (!EvenRow() && EvenColumn()) pieceColor = WhitePiece;
            }

            if (Row > 5)
            {
                if (!EvenRow() && EvenColumn()) pieceColor = BlackPiece;

                else if (EvenRow() && !EvenColumn()) pieceColor = BlackPiece;
            }
        }

        public bool EvenColumn()
        {
            return Column % 2 == 0;
        }

        public bool EvenRow()
        {
            return Row % 2 == 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (pieceColor == 0) return;
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.FromArgb(100, 100, 100));

            if (pieceColor == WhitePiece) brush = new SolidBrush(Color.GhostWhite);

            Rectangle rect = new Rectangle(3, 3, width - 6, height - 6);
            g.FillEllipse(brush, rect);
        }
    }
}
