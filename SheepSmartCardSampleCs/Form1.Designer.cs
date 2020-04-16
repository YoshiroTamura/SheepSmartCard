namespace SheepSmartCardSampleCs
{
    partial class Form1
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
            this.txtSCardIDm = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadIDm = new System.Windows.Forms.Button();
            this.txtErrMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSCardIDm
            // 
            this.txtSCardIDm.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSCardIDm.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSCardIDm.Location = new System.Drawing.Point(199, 122);
            this.txtSCardIDm.Name = "txtSCardIDm";
            this.txtSCardIDm.Size = new System.Drawing.Size(280, 34);
            this.txtSCardIDm.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label2.Location = new System.Drawing.Point(34, 30);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(454, 40);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "SheepSmartCard Sample";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(84, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card ID";
            // 
            // btnReadIDm
            // 
            this.btnReadIDm.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReadIDm.ForeColor = System.Drawing.Color.Black;
            this.btnReadIDm.Location = new System.Drawing.Point(507, 117);
            this.btnReadIDm.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadIDm.Name = "btnReadIDm";
            this.btnReadIDm.Size = new System.Drawing.Size(100, 44);
            this.btnReadIDm.TabIndex = 8;
            this.btnReadIDm.Text = "Scan";
            this.btnReadIDm.UseVisualStyleBackColor = true;
            this.btnReadIDm.Click += new System.EventHandler(this.btnReadIDm_Click);
            // 
            // txtErrMsg
            // 
            this.txtErrMsg.BackColor = System.Drawing.Color.Honeydew;
            this.txtErrMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtErrMsg.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtErrMsg.ForeColor = System.Drawing.Color.Red;
            this.txtErrMsg.Location = new System.Drawing.Point(199, 182);
            this.txtErrMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrMsg.Multiline = true;
            this.txtErrMsg.Name = "txtErrMsg";
            this.txtErrMsg.ReadOnly = true;
            this.txtErrMsg.Size = new System.Drawing.Size(467, 100);
            this.txtErrMsg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(732, 333);
            this.Controls.Add(this.txtErrMsg);
            this.Controls.Add(this.btnReadIDm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtSCardIDm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSCardIDm;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnReadIDm;
        internal System.Windows.Forms.TextBox txtErrMsg;
    }
}

