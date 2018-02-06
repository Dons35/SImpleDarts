using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace SimpleDarts
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Game fuf = new Game();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            fuf.Play();
            resultLabel.Text = "Player 1 score: " + fuf.Player1Score.ToString() + "<br />" + "Player 2 score: " + fuf.Player2Score.ToString() + "<br />" + fuf.WhoWon;

        }
    }

    public class Game
    {
        public int Player1Score = new int();
        public int Player2Score = new int();
        public string WhoWon = "";

        Dart Dart = new Dart();
        Dart Dart1 = new Dart();

        public void Play()
        {
            while (Player1Score < 300 && Player2Score < 300)
            {
                Round();
            }

            if (Player1Score > Player2Score)
                WhoWon = "Player 1 is the winner!";

            else
                WhoWon = "Player 2 is the winner!";

        }

        public void Round() // The maximum score in my game is actually quite high, because as long as a player has a score of 299 or lower, they still get their full turn of three throws before their max score is finalized.
        {                   // Normally in a game, you'd probably just end your turn early if you exceed 300 before the end of your turn.
            for (int i = 0; i <= 2; i++)
            {
                Dart.DartThrow();
                Player1Score = Player1Score + Dart.ScoreForThisThrow;

                Dart1.DartThrow();
                Player2Score = Player2Score + Dart1.ScoreForThisThrow;

                
            }
        }
    }
}