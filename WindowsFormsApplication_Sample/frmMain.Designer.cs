namespace WindowsFormsApplication_Sample
{
    partial class frmMain
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
            this.btn_faceidentify = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_detectface = new System.Windows.Forms.Button();
            this.btn_facecompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_faceidentify
            // 
            this.btn_faceidentify.Location = new System.Drawing.Point(12, 12);
            this.btn_faceidentify.Name = "btn_faceidentify";
            this.btn_faceidentify.Size = new System.Drawing.Size(75, 23);
            this.btn_faceidentify.TabIndex = 2;
            this.btn_faceidentify.Text = "五官定位";
            this.btn_faceidentify.UseVisualStyleBackColor = true;
            this.btn_faceidentify.Click += new System.EventHandler(this.btn_faceidentify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 533);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_detectface
            // 
            this.btn_detectface.Location = new System.Drawing.Point(103, 12);
            this.btn_detectface.Name = "btn_detectface";
            this.btn_detectface.Size = new System.Drawing.Size(75, 23);
            this.btn_detectface.TabIndex = 2;
            this.btn_detectface.Text = "人脸检测";
            this.btn_detectface.UseVisualStyleBackColor = true;
            this.btn_detectface.Click += new System.EventHandler(this.btn_detectface_Click);
            // 
            // btn_facecompare
            // 
            this.btn_facecompare.Location = new System.Drawing.Point(194, 12);
            this.btn_facecompare.Name = "btn_facecompare";
            this.btn_facecompare.Size = new System.Drawing.Size(75, 23);
            this.btn_facecompare.TabIndex = 2;
            this.btn_facecompare.Text = "人脸识别";
            this.btn_facecompare.UseVisualStyleBackColor = true;
            this.btn_facecompare.Click += new System.EventHandler(this.btn_facecompare_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_facecompare);
            this.Controls.Add(this.btn_detectface);
            this.Controls.Add(this.btn_faceidentify);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 620);
            this.MinimumSize = new System.Drawing.Size(520, 620);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "腾讯优图 C# SDK演示";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_faceidentify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_detectface;
        private System.Windows.Forms.Button btn_facecompare;
    }
}