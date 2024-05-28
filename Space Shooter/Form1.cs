﻿using Space_Shooter.AccountManagement;
using Space_Shooter.AccountManagement.Model;
using Space_Shooter.AccountManagement.Repository;
using Space_Shooter.Control;
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

namespace Space_Shooter
{
    public partial class Form1 : Form
    {
        public Screen_Game gameScreen;
        public HomeScreen homeScreen;
        public EndGameScreen endGameScreen;
        User currentUser;
        GameDifficulty currentDiff = GameDifficulty.Normal;
        Ship currentShip = Ship.Default;

        public Form1()
        {
            InitializeComponent();
            Input.GetKeyStates();
            ToCenter();
            AudioManager.PlayBGM(BGM.bgm_menu);
            gameScreen = new Screen_Game(this);
            homeScreen = new HomeScreen(null);
            homeScreen.StartGame += new EventHandler(this.HomeScreen_StartGame);
            homeScreen.SetDiff += HomeScreen_SetDiff;
            homeScreen.ChooseShip += HomeScreen_ChooseShip;
            panel_screen.Controls.Add(homeScreen);

            endGameScreen = new EndGameScreen(currentUser);
            endGameScreen.GoToMainMenu += EndGameScreen_GoToMainMenu;
            endGameScreen.Continue += EndGameScreen_Continue;
            endGameScreen.ShareOnFacebook += EndGameScreen_ShareOnFacebook;
            //panel_screen.Controls.Add(gameScreen);
        }

        private void HomeScreen_ChooseShip(object sender, EventArgs e)
        {
            currentShip = (sender as HomeScreen).currentShip;
        }

        private void HomeScreen_SetDiff(object sender, EventArgs e)
        {
            currentDiff = (sender as HomeScreen).currentDiff;
        }

        public void ToCenter()
        {
            StartPosition = FormStartPosition.Manual;
            Left = (SystemInformation.VirtualScreen.Width - Width) / 2;
            Top = (SystemInformation.VirtualScreen.Height - Height) / 2 - 50;
        }

        public bool IsCenter()
        {
            return Left == (SystemInformation.VirtualScreen.Width - Width) / 2
                && Top == (SystemInformation.VirtualScreen.Height - Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        public void BackToHomeScreen()
        {
            AudioManager.PlayBGM(BGM.bgm_gameover);
            endGameScreen.currentUser = homeScreen.currentUser;
            endGameScreen.UpdateScreen();
            panel_screen.Controls.Clear();
            panel_screen.Controls.Add(endGameScreen);
            if (currentUser.highestScore < GameDataManager.score)
            {
                UserRepo.UpdateScore(currentUser.email, GameDataManager.score);
                currentUser.highestScore = GameDataManager.score;
            }
        }

        private void HomeScreen_StartGame(object sender, EventArgs e)
        {
            AudioManager.PlayBGM(BGM.bgm_ingame);
            currentUser = sender as User;
            panel_screen.Controls.Clear();
            panel_screen.Controls.Add(gameScreen);
            panel_screen.Refresh();
            gameScreen.StartGame();
        }

        private void EndGameScreen_ShareOnFacebook(object sender, EventArgs e)
        {
            MessageBox.Show("share fb");
        }

        private void EndGameScreen_Continue(object sender, EventArgs e)
        {
            AudioManager.PlayBGM(BGM.bgm_ingame);
            panel_screen.Controls.Clear();
            panel_screen.Controls.Add(gameScreen);
            panel_screen.Refresh();
            gameScreen.StartGame();
        }

        private void EndGameScreen_GoToMainMenu(object sender, EventArgs e)
        {
            AudioManager.PlayBGM(BGM.bgm_menu);
            panel_screen.Controls.Clear();
            panel_screen.Controls.Add(homeScreen);
            panel_screen.Refresh();
        }

    }
}
