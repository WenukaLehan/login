namespace login
{
    partial class qrcode
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx = new System.Windows.Forms.TextBox();
            this.ptx = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QRCode";
            // 
            // tbx
            // 
            this.tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx.Location = new System.Drawing.Point(72, 284);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(164, 35);
            this.tbx.TabIndex = 1;
            // 
            // ptx
            // 
            this.ptx.Location = new System.Drawing.Point(17, 41);
            this.ptx.Name = "ptx";
            this.ptx.Size = new System.Drawing.Size(219, 237);
            this.ptx.TabIndex = 2;
            this.ptx.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(161, 340);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "genarate";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // qrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 386);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.ptx);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.label1);
            this.Name = "qrcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qrcode";
            ((System.ComponentModel.ISupportInitialize)(this.ptx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.PictureBox ptx;
        private System.Windows.Forms.Button btn;
    }
}