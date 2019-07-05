using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MemoryGame
{
    /// <summary>
    /// Multiplayer scene form. When users play multiplayer mode, this form is on the screen. It extends from Scene form.
    /// </summary>
    public partial class SingleplayerScene : Scene
    {
        public SingleplayerGame Game { set; get; }
        public PictureBox[] Frames { set; get; }
        public EnterScore EnterScore { set; get; }
        public SingleplayerScene(GameSettings gameSettings, Form1 caller) : base(gameSettings, caller)
        {
            InitializeComponent();
            SetScene();
            InitializeGame();
        }
        public SingleplayerScene() : base()
        {
            InitializeComponent();
        }
        public void SetScene()
        {
            Frames = CreateImageFrames();
        }
        public void InitializeGame()
        {
            NewGame();
            SetControls();
            UpdateStats();
            StartTimer();
        }
        public void NewGame()
        {
            Creator = new CardsCreator(Settings, Frames);
            Game = new SingleplayerGame(Creator.CreateCards());
        }
       
        public void SetControls()
        {
            this.Width = Settings.Width;
            this.Height = Settings.Height;
            pnStats.Location = new Point((this.Width - pnStats.Width) / 2, this.Height - pnStats.Height - 20);
            lbRestart.Location = new Point(pnStats.Location.X + pnStats.Width + 20, this.Height - pnStats.Height + 15);
            lbSingleplayerModeTitle.Location = new Point((this.Width - lbSingleplayerModeTitle.Width) / 2, 20);
        }
        public PictureBox[] CreateImageFrames()
        {
            PictureBox[] Boxes = new PictureBox[Settings.SelectedCategory.NumberOfCards];
            for (int i = 0; i < Boxes.Length; i++)
            {
                Boxes[i] = new PictureBox();
                this.Controls.Add(Boxes[i]);
            }
            AddPicutreBoxesEventHandlers(Boxes);
            return Boxes;
        }
        public void AddPicutreBoxesEventHandlers(PictureBox[] Frames)
        {
            foreach (PictureBox pb in Frames)
            {
                pb.MouseClick += pb_MouseClick;
                pb.MouseEnter += pb_MouseEnter;
                pb.MouseLeave += pb_MouseLeave;
            }      
        }
        /// <summary>
        /// Handles all the action on user's mouse click on a single card. If the game is blocked (there are currently opened cards) it does nothing.
        /// Tries to open card and if it is successfully opened, user can 
        /// hear a sound (unless he/she has disabled sounds in game options).
        /// Also if new pair is created, this method will play the appropriate sound, update the open cards, update the number of pairs
        /// and will also check if game is over.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_MouseClick(object sender, EventArgs e)
        {
            if (Game.Blocked)
                return;
            if(Game.OpenCard((PictureBox)sender))
                if (Settings.Sound)
                    PlaySound(Resources.select_sound);
            Pair pair = Game.CheckPair();
            if (pair == null)
                return;
            if (pair.ValidPair)
            {
                if(Settings.Sound)
                    PlaySound(Resources.correct_sound);
                Game.Hit(pair.Card1, pair.Card2);
                Game.UpdateOpenCards();
                Game.UpdatePairs();
                UpdateStats();
                if (Game.IsGameOver())
                {
                    StopTimer();
                    CheckScore();
                }
            }
            else
            {
                Game.Miss(pair.Card1, pair.Card2);
            }
        }
        public void StartTimer()
        {
            timer.Start();
        }
        public void StopTimer()
        {
            timer.Stop();
        }
        public void CheckScore()
        {
            string message = null;
            SortedSet<Score> scores = null;
            if (Settings.SelectedCategory.Columns == 4)
                scores = BestScoresData.Best4x4;
            if (Settings.SelectedCategory.Columns == 5)
                scores = BestScoresData.Best4x5;
            if (Settings.SelectedCategory.Columns == 6)
                scores = BestScoresData.Best4x6;
            if (ScoreValidation.ValidateScore(scores, Game.Player.ElapsedTime))
            {
                EnterScore = new EnterScore(scores, Game.Player.ElapsedTime);
                EnterScore.ShowDialog();
                message = "Congrats, your score has been recorded in best scores";
            }
            else
            {
                message = "Sorry, not good enough for best scores";
            }
            PlayAgain(message);
        }
        public void PlayAgain(string message)
        {
            PlayAgain playAgain = new PlayAgain(this, MainMenu, message);
            playAgain.ShowDialog();
        }
        public void PlaySound(UnmanagedMemoryStream sound)
        {
            SoundPlayer = new SoundPlayer(sound);
            SoundPlayer.Play();
        }
        private void pb_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            Game.UpdateCardColor((PictureBox)sender);
        }
        private void pb_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            Game.UpdateCardColor((PictureBox)sender);
        }
        public void UpdateStats()
        {
            Invalidate(true);
        }
        private void SingleplayerScene_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                QuitGame();
        }
        public void QuitGame()
        {
            timer.Stop();
            Exit exitForm = new Exit(this);
            exitForm.ShowDialog();
            if (!Game.IsGameOver())
                timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Game.UpdateTime();
            UpdateStats();
        }

        private void SingleplayerScene_Paint(object sender, PaintEventArgs e)
        {
            int minutes = Game.Player.ElapsedTime / 60;
            int seconds = Game.Player.ElapsedTime % 60;
            lbTimeElapsed.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
            lbPairs.Text = String.Format("{0}/{1}", Game.Player.Pairs, Game.Cards.Count / 2);
        }

        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            StopTimer();
            BackToMainMenu backToMainMenu = new BackToMainMenu(this, MainMenu);
            backToMainMenu.ShowDialog();
        }

        private void pbBackArrow_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbBackArrow_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void lbRestart_MouseEnter(object sender, EventArgs e)
        {
            lbRestart.ForeColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void lbRestart_MouseLeave(object sender, EventArgs e)
        {
            lbRestart.ForeColor = Color.White;
            this.Cursor = Cursors.Default;
        }

        private void lbRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
