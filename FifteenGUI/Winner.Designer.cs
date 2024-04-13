
namespace FifteenGUI
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.again = new System.Windows.Forms.Button();
            this.It_s_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // again
            // 
            this.again.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.again.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.again.Location = new System.Drawing.Point(65, 479);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(183, 45);
            this.again.TabIndex = 1;
            this.again.Text = "Ещё раз";
            this.again.UseVisualStyleBackColor = false;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // It_s_All
            // 
            this.It_s_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.It_s_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.It_s_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.It_s_All.Location = new System.Drawing.Point(344, 479);
            this.It_s_All.Name = "It_s_All";
            this.It_s_All.Size = new System.Drawing.Size(199, 44);
            this.It_s_All.TabIndex = 2;
            this.It_s_All.Text = "Хватит";
            this.It_s_All.UseVisualStyleBackColor = false;
            this.It_s_All.Click += new System.EventHandler(this.It_s_All_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 546);
            this.Controls.Add(this.It_s_All);
            this.Controls.Add(this.again);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Чемпион";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button again;
        private System.Windows.Forms.Button It_s_All;
    }
}