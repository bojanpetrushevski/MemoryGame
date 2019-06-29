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

namespace MemoryGame
{
    public partial class Scene : Form
    {

        public GameSettings Settings { set; get; }
        public CardsCreator Creator { set; get; }
        public SoundPlayer SoundPlayer { set; get; }
        public Form1 Caller { set; get; }
        public Scene()
        {
            InitializeComponent();
        }
        public Scene(GameSettings gameSettings, Form1 caller) : base()
        {
            InitializeComponent();
            Settings = gameSettings;
            Caller = caller;
        }
    }
}
