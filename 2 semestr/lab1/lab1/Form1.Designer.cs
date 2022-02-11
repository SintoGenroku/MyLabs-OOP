using System.Windows.Forms;

namespace lab1
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
            this.CubeSqrButton = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonTen = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SqrButton = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.CtgButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SecDegButton = new System.Windows.Forms.Button();
            this.ThirdDegButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CubeSqrButton
            // 
            this.CubeSqrButton.BackColor = System.Drawing.Color.Moccasin;
            this.CubeSqrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CubeSqrButton.Location = new System.Drawing.Point(251, 276);
            this.CubeSqrButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CubeSqrButton.Name = "CubeSqrButton";
            this.CubeSqrButton.Size = new System.Drawing.Size(75, 33);
            this.CubeSqrButton.TabIndex = 0;
            this.CubeSqrButton.Text = "∛";
            this.CubeSqrButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CubeSqrButton.UseVisualStyleBackColor = false;
            this.CubeSqrButton.Click += new System.EventHandler(this.PreOperation_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOne.Location = new System.Drawing.Point(7, 153);
            this.ButtonOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(75, 75);
            this.ButtonOne.TabIndex = 1;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTwo.Location = new System.Drawing.Point(88, 153);
            this.ButtonTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(75, 75);
            this.ButtonTwo.TabIndex = 2;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonThree.Location = new System.Drawing.Point(169, 153);
            this.ButtonThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(75, 75);
            this.ButtonThree.TabIndex = 3;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFour.Location = new System.Drawing.Point(7, 234);
            this.ButtonFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(75, 75);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFive.Location = new System.Drawing.Point(88, 234);
            this.ButtonFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(75, 75);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSix.Location = new System.Drawing.Point(169, 234);
            this.ButtonSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(75, 75);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSeven.Location = new System.Drawing.Point(7, 315);
            this.ButtonSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(75, 75);
            this.ButtonSeven.TabIndex = 7;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = false;
            this.ButtonSeven.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEight.Location = new System.Drawing.Point(88, 315);
            this.ButtonEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(75, 75);
            this.ButtonEight.TabIndex = 8;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonTen
            // 
            this.ButtonTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTen.Location = new System.Drawing.Point(169, 315);
            this.ButtonTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTen.Name = "ButtonTen";
            this.ButtonTen.Size = new System.Drawing.Size(75, 75);
            this.ButtonTen.TabIndex = 9;
            this.ButtonTen.Text = "9";
            this.ButtonTen.UseVisualStyleBackColor = false;
            this.ButtonTen.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZero.Location = new System.Drawing.Point(7, 396);
            this.ButtonZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(156, 75);
            this.ButtonZero.TabIndex = 10;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.NumberButtons_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 50);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            // 
            // SqrButton
            // 
            this.SqrButton.BackColor = System.Drawing.Color.Moccasin;
            this.SqrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SqrButton.Location = new System.Drawing.Point(251, 234);
            this.SqrButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SqrButton.Name = "SqrButton";
            this.SqrButton.Size = new System.Drawing.Size(75, 32);
            this.SqrButton.TabIndex = 13;
            this.SqrButton.Text = "√";
            this.SqrButton.UseVisualStyleBackColor = false;
            this.SqrButton.Click += new System.EventHandler(this.PreOperation_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.IndianRed;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(251, 153);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 75);
            this.button14.TabIndex = 14;
            this.button14.Text = "CE";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CtgButton
            // 
            this.CtgButton.BackColor = System.Drawing.Color.Moccasin;
            this.CtgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CtgButton.Location = new System.Drawing.Point(251, 71);
            this.CtgButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CtgButton.Name = "CtgButton";
            this.CtgButton.Size = new System.Drawing.Size(75, 75);
            this.CtgButton.TabIndex = 15;
            this.CtgButton.Text = "ctg";
            this.CtgButton.UseVisualStyleBackColor = false;
            this.CtgButton.Click += new System.EventHandler(this.PreOperation_Click);
            // 
            // TanButton
            // 
            this.TanButton.BackColor = System.Drawing.Color.Moccasin;
            this.TanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TanButton.Location = new System.Drawing.Point(169, 71);
            this.TanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(75, 75);
            this.TanButton.TabIndex = 16;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = false;
            this.TanButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // CosButton
            // 
            this.CosButton.BackColor = System.Drawing.Color.Moccasin;
            this.CosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosButton.Location = new System.Drawing.Point(88, 71);
            this.CosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(75, 75);
            this.CosButton.TabIndex = 17;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = false;
            this.CosButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.BackColor = System.Drawing.Color.Moccasin;
            this.SinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinButton.Location = new System.Drawing.Point(7, 71);
            this.SinButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(75, 75);
            this.SinButton.TabIndex = 18;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = false;
            this.SinButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(169, 398);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 75);
            this.button19.TabIndex = 19;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(251, 398);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 75);
            this.button20.TabIndex = 20;
            this.button20.Text = "-";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.MinusButton_Click);
            this.button20.DoubleClick += new System.EventHandler(this.Button1_DoubleClick);

            // 
            // SecDegButton
            // 
            this.SecDegButton.BackColor = System.Drawing.Color.Moccasin;
            this.SecDegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecDegButton.Location = new System.Drawing.Point(251, 315);
            this.SecDegButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecDegButton.Name = "SecDegButton";
            this.SecDegButton.Size = new System.Drawing.Size(75, 33);
            this.SecDegButton.TabIndex = 21;
            this.SecDegButton.Text = "^2";
            this.SecDegButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SecDegButton.UseVisualStyleBackColor = false;
            this.SecDegButton.Click += new System.EventHandler(this.PostOperation_Click);
            // 
            // ThirdDegButton
            // 
            this.ThirdDegButton.BackColor = System.Drawing.Color.Moccasin;
            this.ThirdDegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdDegButton.Location = new System.Drawing.Point(251, 357);
            this.ThirdDegButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThirdDegButton.Name = "ThirdDegButton";
            this.ThirdDegButton.Size = new System.Drawing.Size(75, 33);
            this.ThirdDegButton.TabIndex = 22;
            this.ThirdDegButton.Text = "^3";
            this.ThirdDegButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ThirdDegButton.UseVisualStyleBackColor = false;
            this.ThirdDegButton.Click += new System.EventHandler(this.PostOperation_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(13, 478);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(149, 42);
            this.Save.TabIndex = 23;
            this.Save.Text = "Сохранить результат вычислений";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download.Location = new System.Drawing.Point(169, 478);
            this.Download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(149, 42);
            this.Download.TabIndex = 24;
            this.Download.Text = "Загрузить число из файла";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Double Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.DoubleClick += new System.EventHandler(this.Button1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ThirdDegButton);
            this.Controls.Add(this.SecDegButton);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.CtgButton);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.SqrButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonTen);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.CubeSqrButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Button CubeSqrButton;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonTen;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SqrButton;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button CtgButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button SecDegButton;
        private System.Windows.Forms.Button ThirdDegButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button button1;
    }
}

