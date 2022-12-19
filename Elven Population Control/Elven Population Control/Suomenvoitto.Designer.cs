
namespace Elven_Population_Control
{
    partial class Suomenvoitto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suomenvoitto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_joo = new System.Windows.Forms.Button();
            this.btn_ei = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_beache = new System.Windows.Forms.Button();
            this.btn_historical = new System.Windows.Forms.Button();
            this.lbl_othergame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(410, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olemme tehneet isänmaan ylpeyden!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(514, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Fatherland is victorious!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(514, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Do you continue the fight?";
            // 
            // btn_joo
            // 
            this.btn_joo.Location = new System.Drawing.Point(534, 195);
            this.btn_joo.Name = "btn_joo";
            this.btn_joo.Size = new System.Drawing.Size(95, 44);
            this.btn_joo.TabIndex = 4;
            this.btn_joo.Text = "Joo, I want to go on!";
            this.btn_joo.UseVisualStyleBackColor = true;
            this.btn_joo.Click += new System.EventHandler(this.btn_joo_Click);
            // 
            // btn_ei
            // 
            this.btn_ei.Location = new System.Drawing.Point(534, 258);
            this.btn_ei.Name = "btn_ei";
            this.btn_ei.Size = new System.Drawing.Size(95, 44);
            this.btn_ei.TabIndex = 5;
            this.btn_ei.Text = "Ei, I got shot, can\'t continue!";
            this.btn_ei.UseVisualStyleBackColor = true;
            this.btn_ei.Click += new System.EventHandler(this.btn_ei_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(510, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Voitto karhusta!";
            // 
            // btn_beache
            // 
            this.btn_beache.Location = new System.Drawing.Point(466, 379);
            this.btn_beache.Name = "btn_beache";
            this.btn_beache.Size = new System.Drawing.Size(95, 44);
            this.btn_beache.TabIndex = 7;
            this.btn_beache.Text = "Joo, letsa kill da beeeaaar!";
            this.btn_beache.UseVisualStyleBackColor = true;
            this.btn_beache.Visible = false;
            this.btn_beache.Click += new System.EventHandler(this.btn_beache_Click);
            // 
            // btn_historical
            // 
            this.btn_historical.Location = new System.Drawing.Point(591, 379);
            this.btn_historical.Name = "btn_historical";
            this.btn_historical.Size = new System.Drawing.Size(95, 44);
            this.btn_historical.TabIndex = 8;
            this.btn_historical.Text = "Ei, minä going to hospital!";
            this.btn_historical.UseVisualStyleBackColor = true;
            this.btn_historical.Visible = false;
            this.btn_historical.Click += new System.EventHandler(this.btn_historical_Click);
            // 
            // lbl_othergame
            // 
            this.lbl_othergame.AutoSize = true;
            this.lbl_othergame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_othergame.Location = new System.Drawing.Point(487, 344);
            this.lbl_othergame.Name = "lbl_othergame";
            this.lbl_othergame.Size = new System.Drawing.Size(167, 13);
            this.lbl_othergame.TabIndex = 9;
            this.lbl_othergame.Text = " Do you continue a different fight?";
            this.lbl_othergame.Visible = false;
            // 
            // Suomenvoitto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.lbl_othergame);
            this.Controls.Add(this.btn_historical);
            this.Controls.Add(this.btn_beache);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ei);
            this.Controls.Add(this.btn_joo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 532);
            this.MinimumSize = new System.Drawing.Size(816, 532);
            this.Name = "Suomenvoitto";
            this.Text = "Elfin Voitto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Suomenvoitto_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_joo;
        private System.Windows.Forms.Button btn_ei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_beache;
        private System.Windows.Forms.Button btn_historical;
        private System.Windows.Forms.Label lbl_othergame;
    }
}