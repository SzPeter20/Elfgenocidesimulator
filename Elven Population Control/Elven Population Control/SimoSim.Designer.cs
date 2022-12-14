
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(748, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sajnos lelőttek. Szivacs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(710, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szeretnéd, hogy más folytassa az utadat?";
            // 
            // SimoSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}