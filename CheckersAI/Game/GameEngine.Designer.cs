namespace CheckersAI.Game
{
    partial class GameEngine
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.board = new CheckersAI.Game.Board();
            this.playerTurn = new System.Windows.Forms.Label();
            this.playerTurnValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(3, 13);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(652, 588);
            this.board.TabIndex = 1;
            // 
            // playerTurn
            // 
            this.playerTurn.AutoSize = true;
            this.playerTurn.Location = new System.Drawing.Point(517, 26);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(60, 13);
            this.playerTurn.TabIndex = 2;
            this.playerTurn.Text = "Player turn:";
            // 
            // playerTurnValue
            // 
            this.playerTurnValue.AutoSize = true;
            this.playerTurnValue.Location = new System.Drawing.Point(575, 26);
            this.playerTurnValue.Name = "playerTurnValue";
            this.playerTurnValue.Size = new System.Drawing.Size(35, 13);
            this.playerTurnValue.TabIndex = 3;
            this.playerTurnValue.Text = "label1";
            // 
            // GameEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerTurnValue);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.board);
            this.Name = "GameEngine";
            this.Size = new System.Drawing.Size(5000, 5000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Board board;
        private System.Windows.Forms.Label playerTurn;
        private System.Windows.Forms.Label playerTurnValue;
    }
}
