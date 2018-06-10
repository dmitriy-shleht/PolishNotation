namespace RPN
{
    partial class MainForm
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
            this.btnResult = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.tbRpn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(12, 90);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Результат";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbOut
            // 
            this.tbOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOut.Location = new System.Drawing.Point(12, 64);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(265, 20);
            this.tbOut.TabIndex = 1;
            // 
            // tbIn
            // 
            this.tbIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIn.Location = new System.Drawing.Point(12, 12);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(265, 20);
            this.tbIn.TabIndex = 2;
            // 
            // tbRpn
            // 
            this.tbRpn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRpn.Location = new System.Drawing.Point(12, 38);
            this.tbRpn.Name = "tbRpn";
            this.tbRpn.Size = new System.Drawing.Size(265, 20);
            this.tbRpn.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 120);
            this.Controls.Add(this.tbRpn);
            this.Controls.Add(this.tbIn);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.btnResult);
            this.Name = "MainForm";
            this.Text = "RPN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.TextBox tbRpn;
    }
}

