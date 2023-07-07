namespace Work_Windows_Forms_Tags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_new_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 122);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 122);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 122);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 122);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(168, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 122);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(308, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 122);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(28, 285);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 122);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(168, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 122);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(308, 285);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 122);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button_new_game
            // 
            this.button_new_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new_game.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_new_game.Image = ((System.Drawing.Image)(resources.GetObject("button_new_game.Image")));
            this.button_new_game.Location = new System.Drawing.Point(483, 188);
            this.button_new_game.Name = "button_new_game";
            this.button_new_game.Size = new System.Drawing.Size(133, 54);
            this.button_new_game.TabIndex = 9;
            this.button_new_game.Text = "Новая игра";
            this.button_new_game.UseVisualStyleBackColor = true;
            this.button_new_game.Click += new System.EventHandler(this.button_new_game_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 434);
            this.Controls.Add(this.button_new_game);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_new_game;
    }
}

