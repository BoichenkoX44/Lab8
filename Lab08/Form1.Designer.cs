namespace Lab08
{
    partial class fMain
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
            this.tbPhonesInfo = new System.Windows.Forms.TextBox();
            this.btnAddLitak = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // tbPhonesInfo
            // 
            this.tbPhonesInfo.Location = new System.Drawing.Point(12, 12);
            this.tbPhonesInfo.Multiline = true;
            this.tbPhonesInfo.Name = "tbPhonesInfo";
            this.tbPhonesInfo.ReadOnly = true;
            this.tbPhonesInfo.Size = new System.Drawing.Size(588, 409);
            this.tbPhonesInfo.TabIndex = 0;
            this.tbPhonesInfo.TextChanged += new System.EventHandler(this.tbPhonesInfo_TextChanged);
            // 
            // btnAddLitak
            // 
            this.btnAddLitak.Location = new System.Drawing.Point(640, 29);
            this.btnAddLitak.Name = "btnAddLitak";
            this.btnAddLitak.Size = new System.Drawing.Size(148, 31);
            this.btnAddLitak.TabIndex = 1;
            this.btnAddLitak.Text = "Додати  літак";
            this.btnAddLitak.UseVisualStyleBackColor = true;
            this.btnAddLitak.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(640, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddLitak);
            this.Controls.Add(this.tbPhonesInfo);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Лабораторна робота №8\"";
            this.Click += new System.EventHandler(this.fMain_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhonesInfo;
        private System.Windows.Forms.Button btnAddLitak;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

