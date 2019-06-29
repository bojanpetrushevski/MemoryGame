using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MultiplayerScene : Scene
    {
        public MultiplayerGame Game { set; get; }
        public MultiplayerScene(GameSettings gameSettings, Form1 caller) : base(gameSettings, caller)
        {
            InitializeComponent();
            SetScene();
        }
        public MultiplayerScene() : base()
        {
            InitializeComponent();
        }
        public void SetScene()
        {
            PictureBox[] frames = CreateImageFrames();
            Creator = new CardsCreator(Settings, frames);
            Game = new MultiplayerGame(Creator.CreateCards());
            EnterNames();
            SetControls();
        }
        public void SetControls()
        {
            this.Width = Settings.Width;
            this.Height = Settings.Height + 40;
            pnGameStats.Location = new Point((this.Width - pnGameStats.Width) / 2, this.Height - pnGameStats.Height - 20);
            lbMultiplayerModeTitle.Location = new Point((this.Width - lbMultiplayerModeTitle.Width) / 2, 20);
            lbOnTurn.Location = new Point((pnGameStats.Width - lbOnTurn.Width) / 2, 20);
            lbPlayer1Name.Location = new Point((pnPlayer1.Width - lbPlayer1Name.Width) / 2, 20);
            lbPlayer2Name.Location = new Point((pnPlayer2.Width - lbPlayer2Name.Width) / 2, 20);
        }
        public void InitializePlayers(string player1Name, string player2Name)
        {
            Game.CreatePlayers(player1Name, player2Name);
            ShowPlayersNames();
            ToggleFingerImage();
        }
        public void ShowPlayersNames()
        {
            lbPlayer1Name.Text = Game.Player1.Name;
            lbPlayer2Name.Text = Game.Player2.Name;
        }
        public void EnterNames()
        {
            EnterNames enterNames = new EnterNames(this);
            enterNames.ShowDialog();
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
            if (Game.OpenCard((PictureBox)sender))
                if (Settings.Sound)
                    PlaySound(Resources.select_sound);
            Pair pair = Game.CheckPair();
            if (pair == null)
                return;
            if (pair.ValidPair)
            {
                if (Settings.Sound)
                    PlaySound(Resources.correct_sound);
                Game.Hit(pair.Card1, pair.Card2);
                Game.UpdateOpenCards();
                Game.UpdatePairs();
                UpdateStats();
                if (Game.IsGameOver())
                {
                    Player winner = GetWinner();
                    if (winner != null)
                        MessageBox.Show("Game over. Winner is" + winner.Name);
                    else
                        MessageBox.Show("Game over. It is draw");
                }
            }
            else
            {
                Game.Miss(pair.Card1, pair.Card2);
                ToggleFingerImage();
                Game.ChangeTurn();
            }
        }
        public Player GetWinner()
        {
            if (Game.Player1.Pairs > Game.Player2.Pairs)
                return Game.Player1;
            else if (Game.Player1.Pairs < Game.Player2.Pairs)
                return Game.Player2;
            else
                return null;
        }
        public void ToggleFingerImage()
        {
            if(pbFinger.Image == null)
            {
                if (Game.OnTurn == Game.Player1)
                {
                    pbFinger.Image = Resources.finger_left;
                }
                else
                {
                    pbFinger.Image = Resources.finger_right;
                }
            }
            else
            {
                if (BitmapComparator.CompareBitmaps((Bitmap)pbFinger.Image, Resources.finger_left))
                {
                    pbFinger.Image = Resources.finger_right;
                }
                else
                {
                    pbFinger.Image = Resources.finger_left;
                }
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
        private void MultiplayerScene_Paint(object sender, PaintEventArgs e)
        {
            lbPlayer1Pairs.Text = Game.Player1.Pairs.ToString();
            lbPlayer2Pairs.Text = Game.Player2.Pairs.ToString();
        }
        private void pnGameStats_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Caller.Show();
        }
    }
}
