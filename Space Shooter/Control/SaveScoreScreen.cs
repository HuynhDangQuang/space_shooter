﻿using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using Space_Shooter.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class SaveScoreScreen : UserControl
    {
        string victorySentence = "Congrat! You beated the game!";
        string defeatedSentence = "Too bad! Better luck next time!";
        public User currentUser;
        public SaveScoreScreen(User user)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.currentUser = user;
        }

        public event EventHandler BackButtonClick;
        public event EventHandler SaveImageClick;

        private void btn_back_Click(object sender, EventArgs e)
        {
            BackButtonClick(sender, e);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.btn_back.Visible = false;
            this.btn_save.Visible = false;
            SaveImageClick(sender, e);
        }

        public void UpdateScreen()
        {
            pb_avatar.Image = Image.FromFile(FilePathManager.GetFilePath("images") + currentUser.avaPath);
            lb_userName.Text = currentUser.name;
            if (GameDataManager.GameEnd == true)
            {
                lb_senceten.Text = victorySentence;
                pb_victory.Image = Properties.Resources.victory_img;
            }
            else
            {
                pb_victory.Image = Properties.Resources.defeat_img;
                lb_senceten.Text = defeatedSentence;
            }
            lb_scoreVal.Text = GameDataManager.score.ToString();
            string difficulty = GameDataManager.GetDifficultyStr.ToLower();
            if (GameDataManager.score > currentUser.highestScore[difficulty])
            {
                lb_yourScore.Text = "New High Score";
            }
            else
            {
                lb_yourScore.Text = "Your Score";
            }
            lb_playtime.Text = "Play time: " + GameDataManager.PlayTimeStr;

            // Update user score
            if (currentUser.highestScore[difficulty] < GameDataManager.score)
            {
                UserRepo.UpdateScore(currentUser.email, GameDataManager.score, GameDataManager.PlayTime, difficulty);
                currentUser.SetHighestScore(difficulty, GameDataManager.score);
                currentUser.SetPlayTime(difficulty, GameDataManager.PlayTime);
            }
        }

        private void SaveScoreScreen_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
    }
}