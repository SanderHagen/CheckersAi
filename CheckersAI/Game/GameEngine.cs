using System;
using System.Windows.Forms;
using CheckersAI.AI;

namespace CheckersAI.Game
{
    public partial class GameEngine : UserControl
    {
        public static Players currentPlayer = Players.White;

        private AIController AIController;

        public GameEngine()
        {
            InitializeComponent();
            AIController = new AIController(board);
            playerTurnValue.Text = Players.White.ToString();
            board.PlayerTurnDone += new EventHandler(PlayerTurnDone);
            AIController.AiMoveDone += new EventHandler(AITurnDone);
        }

        private void AITurnDone(object sender, EventArgs e)
        {
            SwitchTurns();

            board.Refresh();
        }

        private void PlayerTurnDone(object sender, EventArgs e)
        {
            SwitchTurns();

            DoAITurn();
            
            board.Refresh();
        }

        private void DoAITurn()
        {
            Console.WriteLine("AI turn");
            return;
        }

        private void SwitchTurns()
        {
            if (currentPlayer == Players.White)
            {
                currentPlayer = Players.Black;
                playerTurnValue.Text = currentPlayer.ToString();
                return;
            }

            currentPlayer = Players.White;
            playerTurnValue.Text = currentPlayer.ToString();
        }
    }
}
