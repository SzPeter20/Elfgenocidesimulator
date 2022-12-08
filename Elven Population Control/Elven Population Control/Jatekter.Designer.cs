
namespace Elven_Population_Control
{
    partial class Jatekter
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tank_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tank_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontok: ";
            // 
            // tank_pictureBox
            // 
            this.tank_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.tank_pictureBox.Image = global::Elven_Population_Control.Properties.Resources._09eed588a581ba5;
            this.tank_pictureBox.Location = new System.Drawing.Point(445, 299);
            this.tank_pictureBox.Name = "tank_pictureBox";
            this.tank_pictureBox.Size = new System.Drawing.Size(105, 79);
            this.tank_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tank_pictureBox.TabIndex = 1;
            this.tank_pictureBox.TabStop = false;
            // 
            // Jatekter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Elven_Population_Control.Properties.Resources.png_clipart_night_sky_star_background_material_blue_night_sky_star2;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.tank_pictureBox);
            this.Controls.Add(this.label1);
            this.Name = "Jatekter";
            this.Text = "Jatekter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jatekter_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jatekter_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jatekter_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tank_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tank_pictureBox;
    }
}