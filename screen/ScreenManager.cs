using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSwitchTP.screen
{
    public class ScreenManager
    {
        private Form ParentForm;
        private UserControl CurrentControl;

        public enum SCREEN_ID
        {
            TOP,
            MENU,
        }

        public ScreenManager(Form form)
        {
            this.ParentForm = form;
        }

        public void SetScreen(SCREEN_ID id)
        {
            this.ParentForm.Controls.Remove(this.CurrentControl);

            switch (id)
            {
                case SCREEN_ID.TOP:
                    this.CurrentControl = new ScreenTop();
                    break;
                case SCREEN_ID.MENU:
                    this.CurrentControl = new ScreenMenu();
                    break;
            }

            this.ParentForm.Controls.Add(this.CurrentControl);
        }
    }
}
