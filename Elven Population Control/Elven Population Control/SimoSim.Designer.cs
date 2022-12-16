
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
            this.pctbx_letter = new System.Windows.Forms.PictureBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_other = new System.Windows.Forms.Button();
            this.lbl_doyouwant = new System.Windows.Forms.Label();
            this.btn_rest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_muzzle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_letter)).BeginInit();
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
            // pctbx_letter
            // 
            this.pctbx_letter.BackColor = System.Drawing.Color.Transparent;
            this.pctbx_letter.Location = new System.Drawing.Point(458, 337);
            this.pctbx_letter.Name = "pctbx_letter";
            this.pctbx_letter.Size = new System.Drawing.Size(124, 94);
            this.pctbx_letter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbx_letter.TabIndex = 5;
            this.pctbx_letter.TabStop = false;
            this.pctbx_letter.Visible = false;
            // 
            // btn_continue
            // 
            this.btn_continue.Location = new System.Drawing.Point(780, 221);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(55, 55);
            this.btn_continue.TabIndex = 6;
            this.btn_continue.Text = "Да";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Visible = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(780, 117);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(55, 55);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Нет";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_other
            // 
            this.btn_other.Location = new System.Drawing.Point(713, 295);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(90, 48);
            this.btn_other.TabIndex = 8;
            this.btn_other.Text = "Másik játék választása";
            this.btn_other.UseVisualStyleBackColor = true;
            this.btn_other.Visible = false;
            this.btn_other.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // lbl_doyouwant
            // 
            this.lbl_doyouwant.AutoSize = true;
            this.lbl_doyouwant.BackColor = System.Drawing.Color.Black;
            this.lbl_doyouwant.ForeColor = System.Drawing.Color.White;
            this.lbl_doyouwant.Location = new System.Drawing.Point(727, 279);
            this.lbl_doyouwant.Name = "lbl_doyouwant";
            this.lbl_doyouwant.Size = new System.Drawing.Size(165, 13);
            this.lbl_doyouwant.TabIndex = 9;
            this.lbl_doyouwant.Text = "Szeretnél másik játékkal játszani?";
            this.lbl_doyouwant.Visible = false;
            // 
            // btn_rest
            // 
            this.btn_rest.Location = new System.Drawing.Point(809, 295);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(90, 48);
            this.btn_rest.TabIndex = 10;
            this.btn_rest.Text = "Hadjatok már pihenni békében";
            this.btn_rest.UseVisualStyleBackColor = true;
            this.btn_rest.Visible = false;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
            // 
            // SimoSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elven_Population_Control.Properties.Resources.forest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_rest);
            this.Controls.Add(this.lbl_doyouwant);
            this.Controls.Add(this.btn_other);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.pctbx_letter);
            this.Controls.Add(this.lbl_anyways);
            this.Controls.Add(this.lbl_ohno);
            this.Controls.Add(this.pctbx_direction);
            this.Controls.Add(this.pctbx_muzzle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "SimoSim";
            this.Text = "SimoSim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimoSim_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SimoSim_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_muzzle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_direction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_letter)).EndInit();
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
        private System.Windows.Forms.PictureBox pctbx_letter;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_other;
        private System.Windows.Forms.Label lbl_doyouwant;
        private System.Windows.Forms.Button btn_rest;
    }
}