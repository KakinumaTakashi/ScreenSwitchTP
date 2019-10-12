using ScreenSwitchTP.screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSwitchTP
{
    public partial class MainForm : Form
    {
        public ScreenManager ScreenManager { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ScreenManager = new ScreenManager(this);
            this.ScreenManager.SetScreen(ScreenManager.SCREEN_ID.TOP);
        }
    }
}
