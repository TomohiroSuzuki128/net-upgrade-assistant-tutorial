namespace WinFormsAppNetFramework.Views
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelPrefecture = new System.Windows.Forms.Label();
            this.comboBoxPrefectures = new System.Windows.Forms.ComboBox();
            this.buttonGetAddress = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxZipCode.Location = new System.Drawing.Point(228, 36);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(146, 30);
            this.textBoxZipCode.TabIndex = 0;
            this.textBoxZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelZipCode.Location = new System.Drawing.Point(48, 42);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(129, 20);
            this.labelZipCode.TabIndex = 1;
            this.labelZipCode.Text = "labelZipCode";
            this.labelZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrefecture
            // 
            this.labelPrefecture.AutoSize = true;
            this.labelPrefecture.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPrefecture.Location = new System.Drawing.Point(48, 96);
            this.labelPrefecture.Name = "labelPrefecture";
            this.labelPrefecture.Size = new System.Drawing.Size(159, 20);
            this.labelPrefecture.TabIndex = 2;
            this.labelPrefecture.Text = "labelPrefecture";
            this.labelPrefecture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPrefectures
            // 
            this.comboBoxPrefectures.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxPrefectures.FormattingEnabled = true;
            this.comboBoxPrefectures.Location = new System.Drawing.Point(228, 90);
            this.comboBoxPrefectures.Name = "comboBoxPrefectures";
            this.comboBoxPrefectures.Size = new System.Drawing.Size(225, 31);
            this.comboBoxPrefectures.TabIndex = 3;
            // 
            // buttonGetAddress
            // 
            this.buttonGetAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGetAddress.Location = new System.Drawing.Point(391, 29);
            this.buttonGetAddress.Name = "buttonGetAddress";
            this.buttonGetAddress.Size = new System.Drawing.Size(225, 46);
            this.buttonGetAddress.TabIndex = 4;
            this.buttonGetAddress.Text = "buttonGetAddress";
            this.buttonGetAddress.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAddress.Location = new System.Drawing.Point(48, 148);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(129, 20);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "labelAddress";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddress.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAddress.Location = new System.Drawing.Point(228, 142);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(522, 30);
            this.textBoxAddress.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.buttonGetAddress);
            this.Controls.Add(this.comboBoxPrefectures);
            this.Controls.Add(this.labelPrefecture);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.textBoxZipCode);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelPrefecture;
        private System.Windows.Forms.ComboBox comboBoxPrefectures;
        private System.Windows.Forms.Button buttonGetAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}

