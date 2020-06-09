using System;
using System.Windows.Forms;

namespace CheckersAI.Game
{
    public partial class GameEngine : UserControl
    {
        public static string currentPlayer = Players.White.ToString();

        public GameEngine()
        {
            InitializeComponent();
            playerTurnValue.Text = Players.White.ToString();
            board.OnChangeTurns += new EventHandler(OnTurnsChanged);
        }

        private void OnTurnsChanged(object sender, EventArgs e)
        {
            board.Refresh();

            if (currentPlayer == Players.White.ToString())
            {
                currentPlayer = Players.Black.ToString();
                playerTurnValue.Text = currentPlayer;
                return;
            }
            currentPlayer = Players.White.ToString();
            playerTurnValue.Text = currentPlayer;
        }
    }
}
