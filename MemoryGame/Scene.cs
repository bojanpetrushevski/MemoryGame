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
        public Scene()
        {
            InitializeComponent();
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
    }
}
