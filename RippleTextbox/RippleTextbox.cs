using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RippleTextbox
{
    public partial class RippleTextbox: UserControl
    {
        private static Color NormalColor, ErrorColor;
        private const byte GAM = 15;
        public RippleTextbox()
        {
            InitializeComponent();
        }
        public Color SetErrorColor
        {
            get { return ErrorColor; }
            set { ErrorColor = value; }
        }
        public Color SetNormalColor
        {
            get { return NormalColor; }
            set { NormalColor = value; }
        }

        private void RippleTextbox_Load(object sender, EventArgs e)
        {
            ComeToCenter();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblRip.Width <= this.Width)
            {
                lblRip.Width += GAM;
                lblRip.Left = (this.Width - lblRip.Width) / 2;
            }
            else
                timer.Stop();            
        }

        public void ShowError()
        {
            ComeToCenter();
            lblRip.BackColor = ErrorColor;
            timer.Start();
        }
        public void ShowNormal()
        {
            ComeToCenter();
            lblRip.BackColor = NormalColor;
            timer.Start();
        }

        private void ComeToCenter()
        {
            lblRip.Width = 0;
            lblRip.Left = this.Width / 2;
            lblRip.Height = this.Height;
        }
    }
}
