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
    /// <summary>
    /// Scene form. This form is never showed on the screen, it is only used for code design purposes. 
    /// Things that are common for both singleplayer and multiplayer mode are in this 
    /// class and the separate SingleplayerScene form and MultiplayerScene form extends from this form.
    /// </summary>
    public partial class Scene : Form
    {

        public GameSettings Settings { set; get; }
        public CardsCreator Creator { set; get; }
        public SoundPlayer SoundPlayer { set; get; }
        public Form1 MainMenu { set; get; }
        public Scene()
        {
            InitializeComponent();
        }
        public Scene(GameSettings gameSettings, Form1 mainMenu) : base()
        {
            InitializeComponent();
            Settings = gameSettings;
            MainMenu = mainMenu;
        }
    }
}
