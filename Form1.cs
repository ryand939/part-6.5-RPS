using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace part_6._5_RPS
{
	public partial class Form1 : Form
	{
		string userChoiceStr;

		bool userChoseRock = false;
		bool userChosePaper = false;
		bool userChoseScissors = false;

		int progBarIncrement = 20; //will increase progress bar by this value
		int gamesPlayed = 0;
		int userBet = 0;
		int userBalance = 50;
		int userScore = 0;
		int botScore = 0;
		int tieCount = 0;
        //keep track of score
		Random random = new Random();

		//cheats
		bool moneyLoss = true;
		bool alwaysWin = false;

		private void btnRock_Click(object sender, EventArgs e)
		{
			pictureBox4.Image = null;
			whatTheBotChose.Text = "";
			lblDisplayBotChoice.Text = "";
			lblTellGameResults.Text = "";
			lblCheat.Text = "";
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
			lblCheat.Text = "";
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
			lblDisplayBotChoice.Text = "";
			lblTellGameResults.Text = "";
			lblCheat.Text = "";
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
			lblCheat.Text = "";
			userBet = trackBarUserBet.Value;
			lblYouHaveBetX.Text = $"You have bet ${trackBarUserBet.Value} on this game.";
			if (userBet == 0){lblUserBet.Text = "Bet: No bets have been made.";}
			else{lblUserBet.Text = $"Bet: ${trackBarUserBet.Value}";}
		}



		private void btnRunGame_Click(object sender, EventArgs e)            //main game 
		{
            progressBar1.Value = 0;
            
            if ((userChosePaper || userChoseRock || userChoseScissors) && userBet<=userBalance)
			{
                timer2.Start();
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



		public Form1()
		{
			InitializeComponent();
		}


		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void mouseOn_btnRock(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to choose rock.";
		}

		private void mouseOff_btnRock(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "";
		}

		private void mouseOn_btnPaper(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to choose paper.";

		}

		private void mouseOff_btnPaper(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "";

		}

		private void mouseOn_btnScissors(object sender, EventArgs e)
		{
			lblMessageCentre.Text = "Click to choose scissors.";

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









        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
			progressBar1.Value += progBarIncrement;
			progressBar1.Value -= 1; //subtracting 1 causes the bar to automatically update itself.
									 //if you dont subtract 1, the bar will not completely fill (visually)

			if (progressBar1.Value >= 100){
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
                if (x == 1)
                {
                    whatTheBotChose.Text = "Rock!";
                    pictureBox4.Image = Properties.Resources.rust_rock_png_4;
                    lblDisplayBotChoice.Text = $"The bot chose rock, you chose {userChoiceStr}!";
                    botChoseRock = true;
                }
                else if (x == 2)
                {
                    whatTheBotChose.Text = "Paper!";
                    pictureBox4.Image = Properties.Resources.Paper_icon;
                    lblDisplayBotChoice.Text = $"The bot chose paper, you chose {userChoiceStr}!";
                    botChosePaper = true;
                }
                else if (x == 3)
                {
                    whatTheBotChose.Text = "Scissors!";
                    pictureBox4.Image = Properties.Resources.scissors_icon_office_tools_icons_softiconsm_10;
                    lblDisplayBotChoice.Text = $"The bot chose scissors, you chose {userChoiceStr}!";
                    botChoseScissors = true;
                }
                //the bot now has a choice
                if (((userChoseRock && botChoseRock) || (userChosePaper && botChosePaper) || (userChoseScissors && botChoseScissors)) && alwaysWin == false)
                {
                    lblTellGameResults.Text = "You tied the match!";
                    if (userBet != 0)
                    {
                        userBalance += userBet;
                    }
                    tieCount += 1;
                    listBoxGameHistory.Items.Insert(0, $"{gamesPlayed}. Tie [{userScore} - {tieCount} - {botScore}]");
                }
                else if (((userChoseRock && botChosePaper) || (userChosePaper && botChoseScissors) || (userChoseScissors && botChoseRock)) && alwaysWin == false)//loser
                {
                    if (userBet != 0)
                    {
                        lblTellGameResults.Text = $"You lost the match and lost ${userBet}!";
                    }
                    else
                    {
                        lblTellGameResults.Text = $"You lost the match!";
                    }
					if ((moneyLoss == false && userBet != 0))
					{
						userBalance += userBet;
						lblCheat.Text = "Your bet has been returned.";
					}
					botScore += 1;
					listBoxGameHistory.Items.Insert(0,$"{gamesPlayed}. Bot won match [{userScore} - {tieCount} - {botScore}]");
                }
                else if ((botChoseRock && userChosePaper) || (botChosePaper && userChoseScissors) || (botChoseScissors && userChoseRock) || alwaysWin == true)//winner
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
					userScore += 1;
					listBoxGameHistory.Items.Insert(0, $"{gamesPlayed}. Local player won match [{userScore} - {tieCount} - {botScore}]");

                }
                lblUserBalance.Text = $"Balance: ${userBalance.ToString()}";
                lblGameHistory.Text = "Previous game scores [W - T - L]:";
                userChoseRock = false;
                userChosePaper = false;
                userChoseScissors = false;
                lblUserChoiceHUD.Text = "Choice: No choice has been made.";
                userBet = 0;
                trackBarUserBet.Value = 0;
                lblUserBet.Text = "Bet: No bets have been made.";
                lblYouHaveBetX.Text = $"You have bet ${trackBarUserBet.Value} on this game.";
				progressBar1.Value = 0;
				timer2.Enabled = false;
            }
            

        }

		private void cBoxMoneyLoss_CheckedChanged(object sender, EventArgs e)
		{
			if(cBoxMoneyLoss.Checked == true)
			{
				listBoxCheatLogs.Items.Insert(1, $"{DateTime.Now.ToLongTimeString()} Money loss disabled.");
				moneyLoss = false;
			}
			else
			{
				listBoxCheatLogs.Items.Insert(1, $"{DateTime.Now.ToLongTimeString()} Money loss enabled.");
				moneyLoss = true;
			}
		}

		private void checkBoxWinCheat_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxWinCheat.Checked == true)
			{
				listBoxCheatLogs.Items.Insert(1, $"{DateTime.Now.ToLongTimeString()} Always win enabled.");
				alwaysWin = true;
			}
			else
			{
				listBoxCheatLogs.Items.Insert(1, $"{DateTime.Now.ToLongTimeString()} Always win disabled.");
				alwaysWin = false;
			}
		}

		private void btnAddFunds_Click(object sender, EventArgs e)
		{
			userBalance += Convert.ToInt32(numAddFunds.Value);
			lblUserBalance.Text = $"Balance: ${userBalance.ToString()}";
			if(numAddFunds.Value != 0)
			{
			listBoxCheatLogs.Items.Insert(1,$"Added ${numAddFunds.Value} to balance (${userBalance}).");
			}
		}

		private void btnResetLosses_Click(object sender, EventArgs e)
		{
			listBoxCheatLogs.Items.Insert(1, $"{DateTime.Now.ToLongTimeString()} Losses reset.");
			botScore = 0;
		}

		private void btnClearCheatLogs_Click(object sender, EventArgs e)
		{
			listBoxCheatLogs.Items.Clear();
			listBoxCheatLogs.Items.Add("[Cheat Log]");
		}
	}
}
