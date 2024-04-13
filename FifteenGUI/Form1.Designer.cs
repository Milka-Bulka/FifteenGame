
namespace FifteenGUI
{
    partial class Fifteen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fifteen));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer1 = new ComponentLibrary.GameTimer();
            this.yt_button15 = new ComponentLibrary.yt_button();
            this.yt_button14 = new ComponentLibrary.yt_button();
            this.yt_button13 = new ComponentLibrary.yt_button();
            this.yt_button12 = new ComponentLibrary.yt_button();
            this.yt_button11 = new ComponentLibrary.yt_button();
            this.yt_button10 = new ComponentLibrary.yt_button();
            this.yt_button9 = new ComponentLibrary.yt_button();
            this.yt_button8 = new ComponentLibrary.yt_button();
            this.yt_button7 = new ComponentLibrary.yt_button();
            this.yt_button6 = new ComponentLibrary.yt_button();
            this.yt_button5 = new ComponentLibrary.yt_button();
            this.yt_button4 = new ComponentLibrary.yt_button();
            this.yt_button3 = new ComponentLibrary.yt_button();
            this.yt_button2 = new ComponentLibrary.yt_button();
            this.yt_button0 = new ComponentLibrary.yt_button();
            this.yt_button1 = new ComponentLibrary.yt_button();
            this.otmena = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "начать игру";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // startMenu
            // 
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(107, 24);
            this.startMenu.Text = "Начать игру";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.yt_button15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.yt_button14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.yt_button13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.yt_button12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.yt_button11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.yt_button10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.yt_button9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.yt_button8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.yt_button7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.yt_button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.yt_button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yt_button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.yt_button3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.yt_button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.yt_button0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.yt_button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число ходов: 0";
            // 
            // gameTimer1
            // 
            this.gameTimer1.Location = new System.Drawing.Point(682, 2);
            this.gameTimer1.Name = "gameTimer1";
            this.gameTimer1.Size = new System.Drawing.Size(97, 28);
            this.gameTimer1.TabIndex = 2;
            // 
            // yt_button15
            // 
            this.yt_button15.BackColor = System.Drawing.Color.Pink;
            this.yt_button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button15.ForeColor = System.Drawing.Color.Black;
            this.yt_button15.Location = new System.Drawing.Point(603, 318);
            this.yt_button15.Name = "yt_button15";
            this.yt_button15.Size = new System.Drawing.Size(194, 101);
            this.yt_button15.TabIndex = 33;
            this.yt_button15.Tag = "15";
            this.yt_button15.Text = "*";
            this.yt_button15.Click += new System.EventHandler(this.yt_button15_Click);
            // 
            // yt_button14
            // 
            this.yt_button14.BackColor = System.Drawing.Color.Pink;
            this.yt_button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button14.ForeColor = System.Drawing.Color.Black;
            this.yt_button14.Location = new System.Drawing.Point(403, 318);
            this.yt_button14.Name = "yt_button14";
            this.yt_button14.Size = new System.Drawing.Size(194, 101);
            this.yt_button14.TabIndex = 32;
            this.yt_button14.Tag = "14";
            this.yt_button14.Text = "*";
            this.yt_button14.Click += new System.EventHandler(this.yt_button14_Click);
            // 
            // yt_button13
            // 
            this.yt_button13.BackColor = System.Drawing.Color.Pink;
            this.yt_button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button13.ForeColor = System.Drawing.Color.Black;
            this.yt_button13.Location = new System.Drawing.Point(203, 318);
            this.yt_button13.Name = "yt_button13";
            this.yt_button13.Size = new System.Drawing.Size(194, 101);
            this.yt_button13.TabIndex = 31;
            this.yt_button13.Tag = "13";
            this.yt_button13.Text = "*";
            this.yt_button13.Click += new System.EventHandler(this.yt_button13_Click);
            // 
            // yt_button12
            // 
            this.yt_button12.BackColor = System.Drawing.Color.Pink;
            this.yt_button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button12.ForeColor = System.Drawing.Color.Black;
            this.yt_button12.Location = new System.Drawing.Point(3, 318);
            this.yt_button12.Name = "yt_button12";
            this.yt_button12.Size = new System.Drawing.Size(194, 101);
            this.yt_button12.TabIndex = 30;
            this.yt_button12.Tag = "12";
            this.yt_button12.Text = "*";
            this.yt_button12.Click += new System.EventHandler(this.yt_button12_Click);
            // 
            // yt_button11
            // 
            this.yt_button11.BackColor = System.Drawing.Color.Pink;
            this.yt_button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button11.ForeColor = System.Drawing.Color.Black;
            this.yt_button11.Location = new System.Drawing.Point(603, 213);
            this.yt_button11.Name = "yt_button11";
            this.yt_button11.Size = new System.Drawing.Size(194, 99);
            this.yt_button11.TabIndex = 29;
            this.yt_button11.Tag = "11";
            this.yt_button11.Text = "*";
            this.yt_button11.Click += new System.EventHandler(this.yt_button11_Click);
            // 
            // yt_button10
            // 
            this.yt_button10.BackColor = System.Drawing.Color.Pink;
            this.yt_button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button10.ForeColor = System.Drawing.Color.Black;
            this.yt_button10.Location = new System.Drawing.Point(403, 213);
            this.yt_button10.Name = "yt_button10";
            this.yt_button10.Size = new System.Drawing.Size(194, 99);
            this.yt_button10.TabIndex = 28;
            this.yt_button10.Tag = "10";
            this.yt_button10.Text = "*";
            this.yt_button10.Click += new System.EventHandler(this.yt_button10_Click);
            // 
            // yt_button9
            // 
            this.yt_button9.BackColor = System.Drawing.Color.Pink;
            this.yt_button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button9.ForeColor = System.Drawing.Color.Black;
            this.yt_button9.Location = new System.Drawing.Point(203, 213);
            this.yt_button9.Name = "yt_button9";
            this.yt_button9.Size = new System.Drawing.Size(194, 99);
            this.yt_button9.TabIndex = 27;
            this.yt_button9.Tag = "9";
            this.yt_button9.Text = "*";
            this.yt_button9.Click += new System.EventHandler(this.yt_button9_Click);
            // 
            // yt_button8
            // 
            this.yt_button8.BackColor = System.Drawing.Color.Pink;
            this.yt_button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button8.ForeColor = System.Drawing.Color.Black;
            this.yt_button8.Location = new System.Drawing.Point(3, 213);
            this.yt_button8.Name = "yt_button8";
            this.yt_button8.Size = new System.Drawing.Size(194, 99);
            this.yt_button8.TabIndex = 26;
            this.yt_button8.Tag = "8";
            this.yt_button8.Text = "*";
            this.yt_button8.Click += new System.EventHandler(this.yt_button8_Click);
            // 
            // yt_button7
            // 
            this.yt_button7.BackColor = System.Drawing.Color.Pink;
            this.yt_button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button7.ForeColor = System.Drawing.Color.Black;
            this.yt_button7.Location = new System.Drawing.Point(603, 108);
            this.yt_button7.Name = "yt_button7";
            this.yt_button7.Size = new System.Drawing.Size(194, 99);
            this.yt_button7.TabIndex = 25;
            this.yt_button7.Tag = "7";
            this.yt_button7.Text = "*";
            this.yt_button7.Click += new System.EventHandler(this.yt_button7_Click);
            // 
            // yt_button6
            // 
            this.yt_button6.BackColor = System.Drawing.Color.Pink;
            this.yt_button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button6.ForeColor = System.Drawing.Color.Black;
            this.yt_button6.Location = new System.Drawing.Point(403, 108);
            this.yt_button6.Name = "yt_button6";
            this.yt_button6.Size = new System.Drawing.Size(194, 99);
            this.yt_button6.TabIndex = 24;
            this.yt_button6.Tag = "6";
            this.yt_button6.Text = "*";
            this.yt_button6.Click += new System.EventHandler(this.yt_button6_Click);
            // 
            // yt_button5
            // 
            this.yt_button5.BackColor = System.Drawing.Color.Pink;
            this.yt_button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button5.ForeColor = System.Drawing.Color.Black;
            this.yt_button5.Location = new System.Drawing.Point(203, 108);
            this.yt_button5.Name = "yt_button5";
            this.yt_button5.Size = new System.Drawing.Size(194, 99);
            this.yt_button5.TabIndex = 23;
            this.yt_button5.Tag = "5";
            this.yt_button5.Text = "*";
            this.yt_button5.Click += new System.EventHandler(this.yt_button5_Click);
            // 
            // yt_button4
            // 
            this.yt_button4.BackColor = System.Drawing.Color.Pink;
            this.yt_button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button4.ForeColor = System.Drawing.Color.Black;
            this.yt_button4.Location = new System.Drawing.Point(3, 108);
            this.yt_button4.Name = "yt_button4";
            this.yt_button4.Size = new System.Drawing.Size(194, 99);
            this.yt_button4.TabIndex = 22;
            this.yt_button4.Tag = "4";
            this.yt_button4.Text = "*";
            this.yt_button4.Click += new System.EventHandler(this.yt_button4_Click);
            // 
            // yt_button3
            // 
            this.yt_button3.BackColor = System.Drawing.Color.Pink;
            this.yt_button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button3.ForeColor = System.Drawing.Color.Black;
            this.yt_button3.Location = new System.Drawing.Point(603, 3);
            this.yt_button3.Name = "yt_button3";
            this.yt_button3.Size = new System.Drawing.Size(194, 99);
            this.yt_button3.TabIndex = 21;
            this.yt_button3.Tag = "3";
            this.yt_button3.Text = "*";
            this.yt_button3.Click += new System.EventHandler(this.yt_button3_Click);
            // 
            // yt_button2
            // 
            this.yt_button2.BackColor = System.Drawing.Color.Pink;
            this.yt_button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button2.ForeColor = System.Drawing.Color.Black;
            this.yt_button2.Location = new System.Drawing.Point(403, 3);
            this.yt_button2.Name = "yt_button2";
            this.yt_button2.Size = new System.Drawing.Size(194, 99);
            this.yt_button2.TabIndex = 20;
            this.yt_button2.Tag = "2";
            this.yt_button2.Text = "*";
            this.yt_button2.Click += new System.EventHandler(this.yt_button2_Click);
            // 
            // yt_button0
            // 
            this.yt_button0.BackColor = System.Drawing.Color.Pink;
            this.yt_button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button0.ForeColor = System.Drawing.Color.Black;
            this.yt_button0.Location = new System.Drawing.Point(3, 3);
            this.yt_button0.Name = "yt_button0";
            this.yt_button0.Size = new System.Drawing.Size(194, 99);
            this.yt_button0.TabIndex = 18;
            this.yt_button0.Tag = "0";
            this.yt_button0.Text = "*";
            this.yt_button0.Click += new System.EventHandler(this.yt_button0_Click);
            // 
            // yt_button1
            // 
            this.yt_button1.BackColor = System.Drawing.Color.Pink;
            this.yt_button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yt_button1.ForeColor = System.Drawing.Color.Black;
            this.yt_button1.Location = new System.Drawing.Point(203, 3);
            this.yt_button1.Name = "yt_button1";
            this.yt_button1.Size = new System.Drawing.Size(194, 99);
            this.yt_button1.TabIndex = 19;
            this.yt_button1.Tag = "1";
            this.yt_button1.Text = "*";
            this.yt_button1.Click += new System.EventHandler(this.yt_button1_Click);
            // 
            // otmena
            // 
            this.otmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otmena.Location = new System.Drawing.Point(289, -4);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(132, 32);
            this.otmena.TabIndex = 4;
            this.otmena.Text = "отмена хода";
            this.otmena.UseVisualStyleBackColor = true;
            this.otmena.Click += new System.EventHandler(this.otmena_Click);
            // 
            // Fifteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameTimer1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Fifteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Fifteen_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem startMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentLibrary.GameTimer gameTimer1;
        private ComponentLibrary.yt_button yt_button0;
        private ComponentLibrary.yt_button yt_button1;
        private ComponentLibrary.yt_button yt_button15;
        private ComponentLibrary.yt_button yt_button14;
        private ComponentLibrary.yt_button yt_button13;
        private ComponentLibrary.yt_button yt_button12;
        private ComponentLibrary.yt_button yt_button11;
        private ComponentLibrary.yt_button yt_button10;
        private ComponentLibrary.yt_button yt_button9;
        private ComponentLibrary.yt_button yt_button8;
        private ComponentLibrary.yt_button yt_button7;
        private ComponentLibrary.yt_button yt_button6;
        private ComponentLibrary.yt_button yt_button5;
        private ComponentLibrary.yt_button yt_button4;
        private ComponentLibrary.yt_button yt_button3;
        private ComponentLibrary.yt_button yt_button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button otmena;
    }
}

