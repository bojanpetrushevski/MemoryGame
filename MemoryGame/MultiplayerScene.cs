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
    /// <summary>
    /// Multiplayer scene form. When users play multiplayer mode, this form is on the screen. It extends from Scene form.
    /// </summary>

    public partial class MultiplayerScene : Scene
    {
        public MultiplayerGame Game { set; get; }
        public PictureBox[] Frames { set; get; }
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
            Frames = CreateImageFrames();
            EnterNames();
        }
        public void NewGame()
        {
            Creator = new CardsCreator(Settings, Frames);
            Game = new MultiplayerGame(Creator.CreateCards());
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
        public void InitializeGame(string player1Name, string player2Name)
        {
            NewGame();
            Game.CreatePlayers(player1Name, player2Name);
            ShowPlayersNames();
            ToggleFingerImage();
            SetControls();
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
                    string message = null;
                    if (winner != null)
                    {
                        if (Settings.Sound)
                            PlaySound(Resources.ta_da_sound);
                        message = String.Format("{0} won the game.", winner.Name);
                    }
                    else
                    {
                        message = String.Format("It is draw.");
                    }
                    DeleteFingerImage();
                    PlayAgain(message, winner);
                }
            }
            else
            {
                Game.Miss(pair.Card1, pair.Card2);
                ToggleFingerImage();
                Game.ChangeTurn();
            }
        }
        public void DeleteFingerImage()
        {
            pbFinger.Image = null;
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
        public void PlayAgain(string message, Player winner)
        {
            PlayAgain playAgain = new PlayAgain(this, MainMenu, message, winner);
            playAgain.ShowDialog();
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
        private void pbBackArrow_Click(object sender, EventArgs e)
        {
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
    }
}
