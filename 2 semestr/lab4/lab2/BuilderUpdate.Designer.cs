namespace lab2
{
    partial class BuilderUpdate
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
            this.Change = new System.Windows.Forms.Button();
            this.CashReset = new System.Windows.Forms.CheckBox();
            this.SmsReset = new System.Windows.Forms.CheckBox();
            this.AppReset = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(153, 153);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 5;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // CashReset
            // 
            this.CashReset.AutoSize = true;
            this.CashReset.Location = new System.Drawing.Point(92, 74);
            this.CashReset.Name = "CashReset";
            this.CashReset.Size = new System.Drawing.Size(136, 17);
            this.CashReset.TabIndex = 6;
            this.CashReset.Text = "Аннулировать баланс";
            this.CashReset.UseVisualStyleBackColor = true;
            // 
            // SmsReset
            // 
            this.SmsReset.AutoSize = true;
            this.SmsReset.Location = new System.Drawing.Point(92, 97);
            this.SmsReset.Name = "SmsReset";
            this.SmsReset.Size = new System.Drawing.Size(166, 17);
            this.SmsReset.TabIndex = 7;
            this.SmsReset.Text = "отключить sms-оповещения";
            this.SmsReset.UseVisualStyleBackColor = true;
            // 
            // AppReset
            // 
            this.AppReset.AutoSize = true;
            this.AppReset.Location = new System.Drawing.Point(92, 120);
            this.AppReset.Name = "AppReset";
            this.AppReset.Size = new System.Drawing.Size(174, 17);
            this.AppReset.TabIndex = 8;
            this.AppReset.Text = "Отключить интернет-банкинг";
            this.AppReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Изменение аккаунта пользователя";
            // 
            // BuilderUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppReset);
            this.Controls.Add(this.SmsReset);
            this.Controls.Add(this.CashReset);
            this.Controls.Add(this.Change);
            this.Name = "BuilderUpdate";
            this.Text = "Изменение аккаунта пользователя";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.CheckBox CashReset;
        private System.Windows.Forms.CheckBox SmsReset;
        private System.Windows.Forms.CheckBox AppReset;
        private System.Windows.Forms.Label label1;
    }
}