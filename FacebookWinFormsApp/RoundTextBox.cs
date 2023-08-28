using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    class RoundedTextBox : TextBox
    {

        public RoundedTextBox()
        {
            this.BackColor = Color.DarkGray;
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int i_NLeftRect, // X-coordinate of upper-left corner or padding at start
            int i_NTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int i_NRightRect, // X-coordinate of lower-right corner or Width of the object
            int i_NBottomRect,// Y-coordinate of lower-right corner or Height of the object
                              //RADIUS, how round do you want it to be?
            int i_NheightRect, //height of ellipse 
            int i_NweightRect //width of ellipse

        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15)); //play with these values till you are happy
            this.BackColor = Color.LightGray;

        }
    }

}
