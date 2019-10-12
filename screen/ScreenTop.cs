using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSwitchTP.screen
{
    public partial class ScreenTop : UserControl
    {
        public ScreenTop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((MainForm)this.ParentForm).ScreenManager.SetScreen(ScreenManager.SCREEN_ID.MENU);
        }
    }
}
