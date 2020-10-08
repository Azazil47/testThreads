namespace ThreadTest2
{
    partial class Form1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonProgressStart = new System.Windows.Forms.Button();
            this.buttonProgresStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(421, 401);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 342);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 82);
            this.textBox1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(189, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(349, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // buttonProgressStart
            // 
            this.buttonProgressStart.Location = new System.Drawing.Point(254, 92);
            this.buttonProgressStart.Name = "buttonProgressStart";
            this.buttonProgressStart.Size = new System.Drawing.Size(75, 23);
            this.buttonProgressStart.TabIndex = 3;
            this.buttonProgressStart.Text = "Старт";
            this.buttonProgressStart.UseVisualStyleBackColor = true;
            this.buttonProgressStart.Click += new System.EventHandler(this.buttonProgressStart_Click);
            // 
            // buttonProgresStop
            // 
            this.buttonProgresStop.Location = new System.Drawing.Point(395, 91);
            this.buttonProgresStop.Name = "buttonProgresStop";
            this.buttonProgresStop.Size = new System.Drawing.Size(75, 23);
            this.buttonProgresStop.TabIndex = 4;
            this.buttonProgresStop.Text = "Стоп";
            this.buttonProgresStop.UseVisualStyleBackColor = true;
            this.buttonProgresStop.Click += new System.EventHandler(this.buttonProgresStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProgresStop);
            this.Controls.Add(this.buttonProgressStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonProgressStart;
        private System.Windows.Forms.Button buttonProgresStop;
    }
}

