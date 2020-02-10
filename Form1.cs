using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_6._5_RPS
{
	public partial class Form1 : Form
	{
		string userChoiceStr;

		bool userChoseRock = false;
		bool userChosePaper = false;
		bool userChoseScissors = false;

		int gamesPlayed = 0;
		int userBet = 0;
		int userBalance = 50;
		int userScore = 0;
		int botScore = 0;
		int tieCount = 0;
        //keep track of score
		Random random = new Random();
		private void btnRock_Click(object sender, EventArgs e)
		{
			pictureBox4.Image = null;
			whatTheBotChose.Text = "";
			lblDisplayBotChoice.Text = "";
			lblTellGameResults.Text = "";
			userChoiceStr = "rock";
			userChoseRock = true;
			userChosePaper = false; 
			userChoseScissors = false;
			lblUserChoiceHUD.Text = "Choice: Rock";
			btnRock.BackColor = Color.LightSteelBlue;
			btnPaper.BackColor = Color.Gainsboro;
			btnScissors.BackColor = Color.Gainsboro;
		}
		private void btnPaper_Click(object sender, EventArgs e)
		{
			pictureBox4.Image = null;
			whatTheBotChose.Text = "";
			userChoiceStr = "paper";
			lblDisplayBotChoice.Text = "";
			lblTellGameResults.Text = "";
			userChoseRock = false;
			userChosePaper = true;
			userChoseScissors = false;
			lblUserChoiceHUD.Text = "Choice: Paper";
			btnRock.BackColor = Color.Gainsboro;
			btnPaper.BackColor = Color.LightSteelBlue;
			btnScissors.BackColor = Color.Gainsboro;

		}

		private void btnScissors_Click(object sender, EventArgs e)
		{
			pictureBox4.Image = null;
			whatTheBotChose.Text = "";
			userChoiceStr = "scissors";
			lblTellGameResults.Text = "";
			userChoseRock = false;
			userChosePaper = false;
			userChoseScissors = true;
			lblUserChoiceHUD.Text = "Choice: Scissors";
			btnRock.BackColor = Color.Gainsboro;
			btnPaper.BackColor = Color.Gainsboro;
			btnScissors.BackColor = Color.LightSteelBlue;
		}

		private void trackBarUserBet_Scroll(object sender, EventArgs e)
		{
			pictureBox4.Image = null;
			whatTheBotChose.Text = "";
			lblDisplayBotChoice.Text = "";
			lblTellGameResults.Text = "";
			userBet = trackBarUserBet.Value;
			lblYouHaveBetX.Text = $"You have bet ${trackBarUserBet.Value} on this game.";
			if (userBet == 0){lblUserBet.Text = "Bet: No bets have been made.";}
			else{lblUserBet.Text = $"Bet: ${trackBarUserBet.Value}";}
		}

		private void lblYouHaveBetX_Click(object sender, EventArgs e)
		{

		}

		private void btnRunGame_Click(object sender, EventArgs e)            //main game 
		{
			if ((userChosePaper || userChoseRock || userChoseScissors) && userBet<=userBalance)
			{
				gamesPlayed += 1;
				btnRock.BackColor = Color.Gainsboro;
				btnPaper.BackColor = Color.Gainsboro;
				btnScissors.BackColor = Color.Gainsboro;
				bool botChoseRock = false;
				bool botChosePaper = false;
				bool botChoseScissors = false;
				userBalance -= userBet; //remember to add double the bet back if they win!
				//what did the bot choose?
				int x = random.Next(1, 4); //get a random num from 1-3
				//the bot choice depends on what number they rolled 1-3
				if(x == 1)
				{
					whatTheBotChose.Text = "Rock!";
					pictureBox4.Image = Properties.Resources.rust_rock_png_4;
					lblDisplayBotChoice.Text = $"The bot chose rock, you chose {userChoiceStr}!";
					botChoseRock = true;
				}
				else if(x == 2)
				{
					whatTheBotChose.Text = "Paper!";
					pictureBox4.Image = Properties.Resources.Paper_icon;
					lblDisplayBotChoice.Text = $"The bot chose paper, you chose {userChoiceStr}!";
					botChosePaper = true;
				}
				else if(x == 3)
				{
					whatTheBotChose.Text = "Scissors!";
					pictureBox4.Image = Properties.Resources.scissors_icon_office_tools_icons_softiconsm_10;
					lblDisplayBotChoice.Text = $"The bot chose scissors, you chose {userChoiceStr}!";
					botChoseScissors = true;
				}
				//the bot now has a choice
				if ((userChoseRock && botChoseRock) || (userChosePaper && botChosePaper) || (userChoseScissors && botChoseScissors))
				{
					lblTellGameResults.Text = "You tied the match!";
					if (userBet != 0)
					{
						userBalance += userBet;
					}
					tieCount += 1;
					listBoxGameHistory.Items.Add($"{gamesPlayed}. Tie");
				}
				else if ((userChoseRock && botChosePaper) || (userChosePaper && botChoseScissors) || (userChoseScissors && botChoseRock))//loser
				{
					if (userBet != 0)
					{
						lblTellGameResults.Text = $"You lost the match and lost ${userBet}!";
					}
					else
					{
						lblTellGameResults.Text = $"You lost the match!";
					}
					listBoxGameHistory.Items.Add($"{gamesPlayed}. Bot won match");
					botScore += 1;
				}
				else if ((botChoseRock && userChosePaper) || (botChosePaper && userChoseScissors) || (botChoseScissors && userChoseRock))//winner
				{
					if (userBet != 0)
					{
						lblTellGameResults.Text = $"You won the match and won ${userBet}!";
						userBalance += 2 * userBet;
					}
					else
					{
						lblTellGameResults.Text = $"You won the match!";
					}
					listBoxGameHistory.Items.Add($"{gamesPlayed}. Local player won match");
					userScore += 1;

				}
				lblUserBalance.Text = $"Balance: ${userBalance.ToString()}";
				lblGameHistory.Text = "Previous game scores:";
				userChoseRock = false;
				userChosePaper = false;
				userChoseScissors = false;
				lblUserChoiceHUD.Text = "Choice: No choice has been made.";
				userBet = 0;
				trackBarUserBet.Value = 0;
				lblUserBet.Text = "Bet: No bets have been made.";
				lblYouHaveBetX.Text = $"You have bet ${trackBarUserBet.Value} on this game.";





			}
			else if (userBet > userBalance)
			{
				lblDisplayBotChoice.Text = "Insufficient funds.";
				lblTellGameResults.Text = "";
			}
			else
			{
				//write error message somewhere
				lblDisplayBotChoice.Text = "Please choose rock, paper, or scissors.";
				lblTellGameResults.Text = "";
				pictureBox4.Image = null;
				whatTheBotChose.Text = "";
			}
			


		}

		private void boxResults_Enter(object sender, EventArgs e)
		{

		}

		public Form1()
		{
			InitializeComponent();
		}


		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void mouseOn_btnRock(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to chose rock.";
		}

		private void mouseOff_btnRock(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "";
		}

		private void mouseOn_btnPaper(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to chose paper.";

		}

		private void mouseOff_btnPaper(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "";

		}

		private void mouseOn_btnScissors(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to chose scissors.";

		}

		private void mouseOn_betBar(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Drag left and right to adjust your bet.";

		}

		private void mouseOff_betBar(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "";

		}

		private void mouseOn_btnSubmit(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to submit data.";

		}

		private void mouseOff_btnSubmit(object sender, EventArgs e)
		{

			lblMessageCentre.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}







        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
