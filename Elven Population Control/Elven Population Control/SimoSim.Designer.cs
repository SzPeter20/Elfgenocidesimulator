
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
            this.pctbx_direction = new System.Windows.Forms.PictureBox();
            this.lbl_ohno = new System.Windows.Forms.Label();
            this.lbl_anyways = new System.Windows.Forms.Label();
            this.timer_flash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_muzzle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_direction)).BeginInit();
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
            // pctbx_direction
            // 
            this.pctbx_direction.BackColor = System.Drawing.Color.Transparent;
            this.pctbx_direction.Location = new System.Drawing.Point(458, 437);
            this.pctbx_direction.Name = "pctbx_direction";
            this.pctbx_direction.Size = new System.Drawing.Size(124, 94);
            this.pctbx_direction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbx_direction.TabIndex = 1;
            this.pctbx_direction.TabStop = false;
            this.pctbx_direction.Visible = false;
            // 
            // lbl_ohno
            // 
            this.lbl_ohno.AutoSize = true;
            this.lbl_ohno.BackColor = System.Drawing.Color.Black;
            this.lbl_ohno.ForeColor = System.Drawing.Color.White;
            this.lbl_ohno.Location = new System.Drawing.Point(748, 60);
            this.lbl_ohno.Name = "lbl_ohno";
            this.lbl_ohno.Size = new System.Drawing.Size(122, 13);
            this.lbl_ohno.TabIndex = 2;
            this.lbl_ohno.Text = "Sajnos lelőttek. Szivacs.";
            this.lbl_ohno.Visible = false;
            // 
            // lbl_anyways
            // 
            this.lbl_anyways.AutoSize = true;
            this.lbl_anyways.BackColor = System.Drawing.Color.Black;
            this.lbl_anyways.ForeColor = System.Drawing.Color.White;
            this.lbl_anyways.Location = new System.Drawing.Point(710, 89);
            this.lbl_anyways.Name = "lbl_anyways";
            this.lbl_anyways.Size = new System.Drawing.Size(203, 13);
            this.lbl_anyways.TabIndex = 3;
            this.lbl_anyways.Text = "Szeretnéd, hogy más folytassa az utadat?";
            this.lbl_anyways.Visible = false;
            // 
            // timer_flash
            // 
            this.timer_flash.Interval = 1000;
            this.timer_flash.Tick += new System.EventHandler(this.timer_flash_Tick);
            // 
            // SimoSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.lbl_anyways);
            this.Controls.Add(this.lbl_ohno);
            this.Controls.Add(this.pctbx_direction);
            this.Controls.Add(this.pctbx_muzzle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "SimoSim";
            this.Text = "SimoSim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimoSim_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SimoSim_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_muzzle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_direction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_life;
        private System.Windows.Forms.PictureBox pctbx_muzzle;
        private System.Windows.Forms.PictureBox pctbx_direction;
        private System.Windows.Forms.Label lbl_ohno;
        private System.Windows.Forms.Label lbl_anyways;
        private System.Windows.Forms.Timer timer_flash;
    }
}