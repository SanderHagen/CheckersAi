using System;
using System.Windows.Forms;
using CheckersAI.AI;

namespace CheckersAI.Game
{
    public partial class GameEngine : UserControl
    {
        public static string currentPlayer = Players.White.ToString();

        private AIController AIController;

        public GameEngine()
        {
            InitializeComponent();
            AIController = new AIController();
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
