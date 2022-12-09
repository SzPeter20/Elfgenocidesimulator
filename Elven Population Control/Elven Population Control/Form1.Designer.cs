
namespace Elven_Population_Control
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rchtxtbx_lore = new System.Windows.Forms.RichTextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pctbx_start = new System.Windows.Forms.PictureBox();
            this.timer_crawl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_start)).BeginInit();
            this.SuspendLayout();
            // 
            // rchtxtbx_lore
            // 
            this.rchtxtbx_lore.Location = new System.Drawing.Point(115, 490);
            this.rchtxtbx_lore.Name = "rchtxtbx_lore";
            this.rchtxtbx_lore.Size = new System.Drawing.Size(284, 427);
            this.rchtxtbx_lore.TabIndex = 1;
            this.rchtxtbx_lore.Text = resources.GetString("rchtxtbx_lore.Text");
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title.Location = new System.Drawing.Point(67, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(611, 24);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "The Second Elven Civil War Has Begun! Gentleelves it\'s cleansing time!";
            this.lbl_title.Visible = false;
            // 
            // pctbx_start
            // 
            this.pctbx_start.Image = ((System.Drawing.Image)(resources.GetObject("pctbx_start.Image")));
            this.pctbx_start.Location = new System.Drawing.Point(303, 35);
            this.pctbx_start.Name = "pctbx_start";
            this.pctbx_start.Size = new System.Drawing.Size(547, 427);
            this.pctbx_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbx_start.TabIndex = 4;
            this.pctbx_start.TabStop = false;
            this.pctbx_start.Visible = false;
            this.pctbx_start.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer_crawl
            // 
            this.timer_crawl.Interval = 70;
            this.timer_crawl.Tick += new System.EventHandler(this.timer_crawl_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 477);
            this.Controls.Add(this.pctbx_start);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.rchtxtbx_lore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 516);
            this.MinimumSize = new System.Drawing.Size(480, 516);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deepest Lore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtbx_lore;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pctbx_start;
        private System.Windows.Forms.Timer timer_crawl;
    }
}

