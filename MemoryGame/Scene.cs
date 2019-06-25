using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Scene : Form
    {
        public Game Game { set; get; }
        public GameSettings Settings { set; get; }
        public CardsCreator Creator { set; get; }
        public Scene(GameSettings gameSettings)
        {
            InitializeComponent();
            Settings = gameSettings;
            SetScene();
        }
        public void SetScene()
        {
            PictureBox[] frames = CreateImageFrames();
            Creator = new CardsCreator(Settings, frames);
            Game = new Game(Creator.CreateCards());
            this.Width = Settings.Width;
            this.Height = Settings.Height;
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
                pb.MouseClick += pb_MouseClick;
        }
        private void pb_MouseClick(object sender, EventArgs e)
        {
            Game.CheckClicked((PictureBox)sender);
        }

        private void Scene_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit exitForm = new Exit(this);
            exitForm.ShowDialog();
        }

        private void Scene_KeyPress(object sender, KeyPressEventArgs e)
        {
            Exit exitForm = new Exit(this);
            exitForm.ShowDialog();
        }
    }
}
