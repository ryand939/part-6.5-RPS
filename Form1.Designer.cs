namespace part_6._5_RPS
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBoxConfirmation = new System.Windows.Forms.GroupBox();
			this.btnRunGame = new System.Windows.Forms.Button();
			this.lblUserBet = new System.Windows.Forms.Label();
			this.lblUserChoiceHUD = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.whatTheBotChose = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lblMessageCentre = new System.Windows.Forms.Label();
			this.boxResults = new System.Windows.Forms.GroupBox();
			this.lblTellGameResults = new System.Windows.Forms.Label();
			this.lblDisplayBotChoice = new System.Windows.Forms.Label();
			this.groupBoxUserChoice = new System.Windows.Forms.GroupBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.picRock = new System.Windows.Forms.PictureBox();
			this.btnScissors = new System.Windows.Forms.Button();
			this.btnPaper = new System.Windows.Forms.Button();
			this.btnRock = new System.Windows.Forms.Button();
			this.groupBoxBets = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUserBalance = new System.Windows.Forms.Label();
			this.trackBarUserBet = new System.Windows.Forms.TrackBar();
			this.lblYouHaveBetX = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lblGameHistory = new System.Windows.Forms.Label();
			this.listBoxGameHistory = new System.Windows.Forms.ListBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.groupBoxConfirmation.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.boxResults.SuspendLayout();
			this.groupBoxUserChoice.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
			this.groupBoxBets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarUserBet)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxConfirmation
			// 
			this.groupBoxConfirmation.Controls.Add(this.btnRunGame);
			this.groupBoxConfirmation.Controls.Add(this.lblUserBet);
			this.groupBoxConfirmation.Controls.Add(this.lblUserChoiceHUD);
			this.groupBoxConfirmation.Location = new System.Drawing.Point(236, -1);
			this.groupBoxConfirmation.Name = "groupBoxConfirmation";
			this.groupBoxConfirmation.Size = new System.Drawing.Size(221, 96);
			this.groupBoxConfirmation.TabIndex = 1;
			this.groupBoxConfirmation.TabStop = false;
			this.groupBoxConfirmation.Text = "Confirmation";
			// 
			// btnRunGame
			// 
			this.btnRunGame.BackColor = System.Drawing.Color.Gainsboro;
			this.btnRunGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRunGame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRunGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRunGame.Location = new System.Drawing.Point(6, 57);
			this.btnRunGame.Name = "btnRunGame";
			this.btnRunGame.Size = new System.Drawing.Size(209, 32);
			this.btnRunGame.TabIndex = 5;
			this.btnRunGame.Text = "Submit";
			this.btnRunGame.UseVisualStyleBackColor = false;
			this.btnRunGame.Click += new System.EventHandler(this.btnRunGame_Click);
			this.btnRunGame.MouseEnter += new System.EventHandler(this.mouseOn_btnSubmit);
			this.btnRunGame.MouseLeave += new System.EventHandler(this.mouseOff_btnSubmit);
			// 
			// lblUserBet
			// 
			this.lblUserBet.AutoSize = true;
			this.lblUserBet.Location = new System.Drawing.Point(6, 38);
			this.lblUserBet.Name = "lblUserBet";
			this.lblUserBet.Size = new System.Drawing.Size(157, 13);
			this.lblUserBet.TabIndex = 4;
			this.lblUserBet.Text = "Bets: No bets have been made.";
			// 
			// lblUserChoiceHUD
			// 
			this.lblUserChoiceHUD.AutoSize = true;
			this.lblUserChoiceHUD.Location = new System.Drawing.Point(6, 19);
			this.lblUserChoiceHUD.Name = "lblUserChoiceHUD";
			this.lblUserChoiceHUD.Size = new System.Drawing.Size(174, 13);
			this.lblUserChoiceHUD.TabIndex = 3;
			this.lblUserChoiceHUD.Text = "Choice: No choice has been made.";
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(3, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(470, 338);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.lblMessageCentre);
			this.tabPage1.Controls.Add(this.boxResults);
			this.tabPage1.Controls.Add(this.groupBoxUserChoice);
			this.tabPage1.Controls.Add(this.groupBoxConfirmation);
			this.tabPage1.Controls.Add(this.groupBoxBets);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(462, 309);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Rock Paper Scissors";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.whatTheBotChose);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Location = new System.Drawing.Point(236, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(221, 56);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bot Choice";
			// 
			// whatTheBotChose
			// 
			this.whatTheBotChose.AutoSize = true;
			this.whatTheBotChose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.whatTheBotChose.Location = new System.Drawing.Point(51, 21);
			this.whatTheBotChose.Name = "whatTheBotChose";
			this.whatTheBotChose.Size = new System.Drawing.Size(0, 22);
			this.whatTheBotChose.TabIndex = 7;
			this.whatTheBotChose.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 6;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(10, 15);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 34);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			// 
			// lblMessageCentre
			// 
			this.lblMessageCentre.AutoSize = true;
			this.lblMessageCentre.Location = new System.Drawing.Point(-1, 279);
			this.lblMessageCentre.Name = "lblMessageCentre";
			this.lblMessageCentre.Size = new System.Drawing.Size(0, 13);
			this.lblMessageCentre.TabIndex = 5;
			// 
			// boxResults
			// 
			this.boxResults.BackColor = System.Drawing.Color.Transparent;
			this.boxResults.Controls.Add(this.lblTellGameResults);
			this.boxResults.Controls.Add(this.lblDisplayBotChoice);
			this.boxResults.Location = new System.Drawing.Point(236, 151);
			this.boxResults.Name = "boxResults";
			this.boxResults.Size = new System.Drawing.Size(221, 127);
			this.boxResults.TabIndex = 4;
			this.boxResults.TabStop = false;
			this.boxResults.Text = "Results";
			this.boxResults.Enter += new System.EventHandler(this.boxResults_Enter);
			// 
			// lblTellGameResults
			// 
			this.lblTellGameResults.AutoSize = true;
			this.lblTellGameResults.Location = new System.Drawing.Point(7, 35);
			this.lblTellGameResults.Name = "lblTellGameResults";
			this.lblTellGameResults.Size = new System.Drawing.Size(0, 13);
			this.lblTellGameResults.TabIndex = 1;
			// 
			// lblDisplayBotChoice
			// 
			this.lblDisplayBotChoice.AutoSize = true;
			this.lblDisplayBotChoice.Location = new System.Drawing.Point(7, 19);
			this.lblDisplayBotChoice.Name = "lblDisplayBotChoice";
			this.lblDisplayBotChoice.Size = new System.Drawing.Size(0, 13);
			this.lblDisplayBotChoice.TabIndex = 0;
			// 
			// groupBoxUserChoice
			// 
			this.groupBoxUserChoice.Controls.Add(this.pictureBox3);
			this.groupBoxUserChoice.Controls.Add(this.pictureBox2);
			this.groupBoxUserChoice.Controls.Add(this.picRock);
			this.groupBoxUserChoice.Controls.Add(this.btnScissors);
			this.groupBoxUserChoice.Controls.Add(this.btnPaper);
			this.groupBoxUserChoice.Controls.Add(this.btnRock);
			this.groupBoxUserChoice.Location = new System.Drawing.Point(1, -1);
			this.groupBoxUserChoice.Name = "groupBoxUserChoice";
			this.groupBoxUserChoice.Size = new System.Drawing.Size(229, 177);
			this.groupBoxUserChoice.TabIndex = 0;
			this.groupBoxUserChoice.TabStop = false;
			this.groupBoxUserChoice.Text = "Local Player Choice";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::part_6._5_RPS.Properties.Resources.Paper_icon;
			this.pictureBox3.Location = new System.Drawing.Point(6, 70);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(51, 45);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::part_6._5_RPS.Properties.Resources.scissors_icon_office_tools_icons_softiconsm_10;
			this.pictureBox2.Location = new System.Drawing.Point(6, 121);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(51, 45);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// picRock
			// 
			this.picRock.Image = global::part_6._5_RPS.Properties.Resources.rust_rock_png_4;
			this.picRock.Location = new System.Drawing.Point(6, 19);
			this.picRock.Name = "picRock";
			this.picRock.Size = new System.Drawing.Size(51, 45);
			this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picRock.TabIndex = 3;
			this.picRock.TabStop = false;
			// 
			// btnScissors
			// 
			this.btnScissors.BackColor = System.Drawing.Color.Gainsboro;
			this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnScissors.Location = new System.Drawing.Point(63, 121);
			this.btnScissors.Name = "btnScissors";
			this.btnScissors.Size = new System.Drawing.Size(159, 45);
			this.btnScissors.TabIndex = 2;
			this.btnScissors.Text = "Scissors";
			this.btnScissors.UseVisualStyleBackColor = false;
			this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
			this.btnScissors.MouseEnter += new System.EventHandler(this.mouseOn_btnScissors);
			this.btnScissors.MouseLeave += new System.EventHandler(this.mouseOff_btnPaper);
			// 
			// btnPaper
			// 
			this.btnPaper.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPaper.Location = new System.Drawing.Point(63, 70);
			this.btnPaper.Name = "btnPaper";
			this.btnPaper.Size = new System.Drawing.Size(159, 45);
			this.btnPaper.TabIndex = 1;
			this.btnPaper.Text = "Paper";
			this.btnPaper.UseVisualStyleBackColor = false;
			this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
			this.btnPaper.MouseEnter += new System.EventHandler(this.mouseOn_btnPaper);
			this.btnPaper.MouseLeave += new System.EventHandler(this.mouseOff_btnPaper);
			// 
			// btnRock
			// 
			this.btnRock.BackColor = System.Drawing.Color.Gainsboro;
			this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRock.Location = new System.Drawing.Point(63, 19);
			this.btnRock.Name = "btnRock";
			this.btnRock.Size = new System.Drawing.Size(159, 45);
			this.btnRock.TabIndex = 0;
			this.btnRock.Text = "Rock";
			this.btnRock.UseVisualStyleBackColor = false;
			this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
			this.btnRock.MouseEnter += new System.EventHandler(this.mouseOn_btnRock);
			this.btnRock.MouseLeave += new System.EventHandler(this.mouseOff_btnRock);
			// 
			// groupBoxBets
			// 
			this.groupBoxBets.Controls.Add(this.pictureBox1);
			this.groupBoxBets.Controls.Add(this.lblUserBalance);
			this.groupBoxBets.Controls.Add(this.trackBarUserBet);
			this.groupBoxBets.Controls.Add(this.lblYouHaveBetX);
			this.groupBoxBets.Location = new System.Drawing.Point(1, 176);
			this.groupBoxBets.Name = "groupBoxBets";
			this.groupBoxBets.Size = new System.Drawing.Size(229, 100);
			this.groupBoxBets.TabIndex = 2;
			this.groupBoxBets.TabStop = false;
			this.groupBoxBets.Text = "Bets";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::part_6._5_RPS.Properties.Resources.money_flat_money_png_15;
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(51, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// lblUserBalance
			// 
			this.lblUserBalance.AutoSize = true;
			this.lblUserBalance.Location = new System.Drawing.Point(60, 32);
			this.lblUserBalance.Name = "lblUserBalance";
			this.lblUserBalance.Size = new System.Drawing.Size(70, 13);
			this.lblUserBalance.TabIndex = 3;
			this.lblUserBalance.Text = "Balance: $50";
			// 
			// trackBarUserBet
			// 
			this.trackBarUserBet.BackColor = System.Drawing.SystemColors.Control;
			this.trackBarUserBet.Cursor = System.Windows.Forms.Cursors.Default;
			this.trackBarUserBet.Location = new System.Drawing.Point(59, 51);
			this.trackBarUserBet.Name = "trackBarUserBet";
			this.trackBarUserBet.Size = new System.Drawing.Size(164, 45);
			this.trackBarUserBet.TabIndex = 1;
			this.trackBarUserBet.Scroll += new System.EventHandler(this.trackBarUserBet_Scroll);
			this.trackBarUserBet.MouseEnter += new System.EventHandler(this.mouseOn_betBar);
			this.trackBarUserBet.MouseLeave += new System.EventHandler(this.mouseOff_betBar);
			// 
			// lblYouHaveBetX
			// 
			this.lblYouHaveBetX.AutoSize = true;
			this.lblYouHaveBetX.Location = new System.Drawing.Point(60, 16);
			this.lblYouHaveBetX.Name = "lblYouHaveBetX";
			this.lblYouHaveBetX.Size = new System.Drawing.Size(152, 13);
			this.lblYouHaveBetX.TabIndex = 0;
			this.lblYouHaveBetX.Text = "You have bet $0 on this game.";
			this.lblYouHaveBetX.Click += new System.EventHandler(this.lblYouHaveBetX_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.lblGameHistory);
			this.tabPage3.Controls.Add(this.listBoxGameHistory);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(484, 284);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "History";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// lblGameHistory
			// 
			this.lblGameHistory.AutoSize = true;
			this.lblGameHistory.Location = new System.Drawing.Point(1, 4);
			this.lblGameHistory.Name = "lblGameHistory";
			this.lblGameHistory.Size = new System.Drawing.Size(339, 13);
			this.lblGameHistory.TabIndex = 1;
			this.lblGameHistory.Text = "Your previous games will be recorded here. Play a game to get started.";
			// 
			// listBoxGameHistory
			// 
			this.listBoxGameHistory.FormattingEnabled = true;
			this.listBoxGameHistory.Location = new System.Drawing.Point(2, 18);
			this.listBoxGameHistory.Name = "listBoxGameHistory";
			this.listBoxGameHistory.Size = new System.Drawing.Size(338, 290);
			this.listBoxGameHistory.TabIndex = 0;
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 328);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Part 6 - Rock Paper Scissors";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBoxConfirmation.ResumeLayout(false);
			this.groupBoxConfirmation.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.boxResults.ResumeLayout(false);
			this.boxResults.PerformLayout();
			this.groupBoxUserChoice.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
			this.groupBoxBets.ResumeLayout(false);
			this.groupBoxBets.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarUserBet)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBoxConfirmation;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBoxUserChoice;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox picRock;
		private System.Windows.Forms.Button btnScissors;
		private System.Windows.Forms.Button btnPaper;
		private System.Windows.Forms.Button btnRock;
		private System.Windows.Forms.Label lblUserChoiceHUD;
		private System.Windows.Forms.GroupBox groupBoxBets;
		private System.Windows.Forms.Label lblUserBet;
		private System.Windows.Forms.TrackBar trackBarUserBet;
		private System.Windows.Forms.Label lblYouHaveBetX;
		private System.Windows.Forms.Label lblUserBalance;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnRunGame;
		private System.Windows.Forms.GroupBox boxResults;
		private System.Windows.Forms.Label lblDisplayBotChoice;
		private System.Windows.Forms.Label lblTellGameResults;
		private System.Windows.Forms.Label lblMessageCentre;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label whatTheBotChose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lblGameHistory;
		private System.Windows.Forms.ListBox listBoxGameHistory;
	}
}

