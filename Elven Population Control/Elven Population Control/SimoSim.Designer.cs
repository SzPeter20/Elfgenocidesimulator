
namespace Elven_Population_Control
{
    partial class SimoSim
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimoSim));
            this.timer_life = new System.Windows.Forms.Timer(this.components);
            this.pctbx_muzzle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_muzzle)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_life
            // 
            this.timer_life.Tick += new System.EventHandler(this.timer_life_Tick);
            // 
            // pctbx_muzzle
            // 
            this.pctbx_muzzle.BackColor = System.Drawing.Color.Transparent;
            this.pctbx_muzzle.Image = ((System.Drawing.Image)(resources.GetObject("pctbx_muzzle.Image")));
            this.pctbx_muzzle.Location = new System.Drawing.Point(337, 258);
            this.pctbx_muzzle.Name = "pctbx_muzzle";
            this.pctbx_muzzle.Size = new System.Drawing.Size(40, 18);
            this.pctbx_muzzle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx_muzzle.TabIndex = 0;
            this.pctbx_muzzle.TabStop = false;
            this.pctbx_muzzle.Visible = false;
            // 
            // SimoSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pctbx_muzzle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "SimoSim";
            this.Text = "SimoSim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimoSim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_muzzle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_life;
        private System.Windows.Forms.PictureBox pctbx_muzzle;
    }
}