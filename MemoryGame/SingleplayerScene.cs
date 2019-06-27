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

namespace MemoryGame
{
    public partial class SingleplayerScene : Scene
    {
        public SingleplayerGame Game { set; get; }
        public System.Media.SoundPlayer SoundPlayer { set; get; }
        public EnterScore EnterScore { set; get; }
        public SingleplayerScene(GameSettings gameSettings) : base(gameSettings)
        {
            InitializeComponent();
            SetScene();
        }
        public SingleplayerScene() : base()
        {
            InitializeComponent();
        }
        public void SetScene()
        {
            PictureBox[] frames = CreateImageFrames();
            Creator = new CardsCreator(Settings, frames);
            Game = new SingleplayerGame(Creator.CreateCards());
            this.Width = Settings.Width;
            this.Height = Settings.Height;
            pnStats.Location = new Point((this.Width - pnStats.Width) / 2, this.Height - pnStats.Height - 20);
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
        private void pb_MouseClick(object sender, EventArgs e)
        {
            if (Game.Blocked)
                return;
            if (Settings.Sound)
                PlaySound(Resources.select_sound);
            Game.OpenCard((PictureBox)sender);
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
                    timer.Stop();
                    CheckScore();
                }
            }
            else
            {
                Game.Miss(pair.Card1, pair.Card2);
            }
        }
        public void CheckScore()
        {
            SortedSet<Score> scores = null;
            if (Settings.SelectedCategory.Columns == 4)
                scores = BestScoresData.Best4x4;
            if (Settings.SelectedCategory.Columns == 5)
                scores = BestScoresData.Best4x5;
            if (Settings.SelectedCategory.Columns == 6)
                scores = BestScoresData.Best4x6;
            if (ScoreValidation.ValidateScore(scores, Game.TimeElapsed))
            {
                EnterScore = new EnterScore(scores, Game.TimeElapsed);
                EnterScore.ShowDialog();
            }   
        }
        public void PlaySound(UnmanagedMemoryStream sound)
        {
            SoundPlayer = new System.Media.SoundPlayer(sound);
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
            {
                timer.Stop();
                Exit exitForm = new Exit(this);
                exitForm.ShowDialog();
                if(!Game.IsGameOver())
                    timer.Start();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Game.UpdateTime();
            UpdateStats();
        }

        private void SingleplayerScene_Paint(object sender, PaintEventArgs e)
        {
            int minutes = Game.TimeElapsed / 60;
            int seconds = Game.TimeElapsed % 60;
            lbTimeElapsed.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
            lbPairs.Text = String.Format("{0}/{1}", Game.Pairs, Game.Cards.Count / 2);
        }
    }
}
