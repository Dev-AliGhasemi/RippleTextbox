namespace RippleTextbox
{
    partial class RippleTextbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRip = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblRip
            // 
            this.lblRip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRip.Location = new System.Drawing.Point(140, 0);
            this.lblRip.Name = "lblRip";
            this.lblRip.Size = new System.Drawing.Size(0, 2);
            this.lblRip.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RippleTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRip);
            this.Name = "RippleTextbox";
            this.Size = new System.Drawing.Size(281, 2);
            this.Load += new System.EventHandler(this.RippleTextbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRip;
        private System.Windows.Forms.Timer timer;
    }
}
