namespace ComponentLibrary
{
    partial class GameTimer
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.display = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.yt_button0 = new ComponentLibrary.yt_button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(3, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(73, 20);
            this.display.TabIndex = 0;
            this.display.Text = "00:00:00";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // yt_button0
            // 
            this.yt_button0.BackColor = System.Drawing.Color.Pink;
            this.yt_button0.ForeColor = System.Drawing.Color.Black;
            this.yt_button0.Location = new System.Drawing.Point(549, 282);
            this.yt_button0.Name = "yt_button0";
            this.yt_button0.Size = new System.Drawing.Size(158, 57);
            this.yt_button0.TabIndex = 1;
            this.yt_button0.Text = "yt_button0";
            // 
            // GameTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yt_button0);
            this.Controls.Add(this.display);
            this.Name = "GameTimer";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Timer timer;
        private yt_button yt_button0;
    }
}
