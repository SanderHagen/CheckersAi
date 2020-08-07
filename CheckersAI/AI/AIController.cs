using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckersAI.Game;

namespace CheckersAI.AI
{
    class AIController
    {
        private Board board;
        public event EventHandler AiMoveDone;

        public AIController(Board board)
        {
            this.board = board;
        }

        public void DoMove()
        {

            return;
        }
    }
}
