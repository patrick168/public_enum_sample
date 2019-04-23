namespace public_enum_sample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResult = new System.Windows.Forms.Label();
            this.money5 = new System.Windows.Forms.Button();
            this.money10 = new System.Windows.Forms.Button();
            this.money1 = new System.Windows.Forms.Button();
            this.money0 = new System.Windows.Forms.Button();
            this.moneyDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbResult.Location = new System.Drawing.Point(211, 26);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(114, 42);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Result";
            // 
            // money5
            // 
            this.money5.Location = new System.Drawing.Point(124, 145);
            this.money5.Name = "money5";
            this.money5.Size = new System.Drawing.Size(75, 23);
            this.money5.TabIndex = 1;
            this.money5.Text = "5";
            this.money5.UseVisualStyleBackColor = true;
            this.money5.Click += new System.EventHandler(this.money5_Click);
            // 
            // money10
            // 
            this.money10.Location = new System.Drawing.Point(227, 145);
            this.money10.Name = "money10";
            this.money10.Size = new System.Drawing.Size(75, 23);
            this.money10.TabIndex = 2;
            this.money10.Text = "10";
            this.money10.UseVisualStyleBackColor = true;
            this.money10.Click += new System.EventHandler(this.money10_Click);
            // 
            // money1
            // 
            this.money1.Location = new System.Drawing.Point(19, 145);
            this.money1.Name = "money1";
            this.money1.Size = new System.Drawing.Size(75, 23);
            this.money1.TabIndex = 3;
            this.money1.Text = "1";
            this.money1.UseVisualStyleBackColor = true;
            this.money1.Click += new System.EventHandler(this.money1_Click);
            // 
            // money0
            // 
            this.money0.Location = new System.Drawing.Point(322, 145);
            this.money0.Name = "money0";
            this.money0.Size = new System.Drawing.Size(75, 23);
            this.money0.TabIndex = 2;
            this.money0.Text = "Reset";
            this.money0.UseVisualStyleBackColor = true;
            this.money0.Click += new System.EventHandler(this.money0_Click);
            // 
            // moneyDouble
            // 
            this.moneyDouble.Location = new System.Drawing.Point(426, 145);
            this.moneyDouble.Name = "moneyDouble";
            this.moneyDouble.Size = new System.Drawing.Size(75, 23);
            this.moneyDouble.TabIndex = 4;
            this.moneyDouble.Text = "Double";
            this.moneyDouble.UseVisualStyleBackColor = true;
            this.moneyDouble.Click += new System.EventHandler(this.moneyDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 203);
            this.Controls.Add(this.moneyDouble);
            this.Controls.Add(this.money1);
            this.Controls.Add(this.money0);
            this.Controls.Add(this.money10);
            this.Controls.Add(this.money5);
            this.Controls.Add(this.lbResult);
            this.Name = "Form1";
            this.Text = "enum and switch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button money5;
        private System.Windows.Forms.Button money10;
        private System.Windows.Forms.Button money1;
        private System.Windows.Forms.Button money0;
        private System.Windows.Forms.Button moneyDouble;
    }
}

