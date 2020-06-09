using CheckersAI.Game;
using System.Windows.Forms;

namespace CheckersAI
{
    public partial class Form1 : Form
    {
        private GameEngine game;

        public Form1()
        {
            InitializeComponent();
            game = new GameEngine();
        
            Controls.Add(game);
        }
    }
}
