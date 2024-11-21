namespace netflop
{
    partial class Upload
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.videoPathTxt = new System.Windows.Forms.TextBox();
            this.posterPathTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.ovwTxt = new System.Windows.Forms.RichTextBox();
            this.videoBrowseBtn = new System.Windows.Forms.Button();
            this.posterBrowseBtn = new System.Windows.Forms.Button();
            this.openVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPosterDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poster file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Overview:";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(291, 311);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(128, 54);
            this.uploadBtn.TabIndex = 4;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // videoPathTxt
            // 
            this.videoPathTxt.Location = new System.Drawing.Point(128, 32);
            this.videoPathTxt.Name = "videoPathTxt";
            this.videoPathTxt.Size = new System.Drawing.Size(503, 29);
            this.videoPathTxt.TabIndex = 5;
            // 
            // posterPathTxt
            // 
            this.posterPathTxt.Location = new System.Drawing.Point(128, 78);
            this.posterPathTxt.Name = "posterPathTxt";
            this.posterPathTxt.Size = new System.Drawing.Size(503, 29);
            this.posterPathTxt.TabIndex = 6;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(128, 119);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(503, 29);
            this.nameTxt.TabIndex = 7;
            // 
            // ovwTxt
            // 
            this.ovwTxt.Location = new System.Drawing.Point(128, 172);
            this.ovwTxt.Name = "ovwTxt";
            this.ovwTxt.Size = new System.Drawing.Size(503, 133);
            this.ovwTxt.TabIndex = 8;
            this.ovwTxt.Text = "";
            // 
            // videoBrowseBtn
            // 
            this.videoBrowseBtn.Location = new System.Drawing.Point(634, 34);
            this.videoBrowseBtn.Name = "videoBrowseBtn";
            this.videoBrowseBtn.Size = new System.Drawing.Size(31, 24);
            this.videoBrowseBtn.TabIndex = 9;
            this.videoBrowseBtn.Text = "...";
            this.videoBrowseBtn.UseVisualStyleBackColor = true;
            this.videoBrowseBtn.Click += new System.EventHandler(this.videoBrowseBtn_Click);
            // 
            // posterBrowseBtn
            // 
            this.posterBrowseBtn.Location = new System.Drawing.Point(634, 80);
            this.posterBrowseBtn.Name = "posterBrowseBtn";
            this.posterBrowseBtn.Size = new System.Drawing.Size(31, 24);
            this.posterBrowseBtn.TabIndex = 10;
            this.posterBrowseBtn.Text = "...";
            this.posterBrowseBtn.UseVisualStyleBackColor = true;
            this.posterBrowseBtn.Click += new System.EventHandler(this.posterBrowseBtn_Click);
            // 
            // openVideoDialog
            // 
            this.openVideoDialog.Filter = "Video|*.mp4";
            // 
            // openPosterDialog
            // 
            this.openPosterDialog.Filter = "Images files|*.png";
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 388);
            this.Controls.Add(this.posterBrowseBtn);
            this.Controls.Add(this.videoBrowseBtn);
            this.Controls.Add(this.ovwTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.posterPathTxt);
            this.Controls.Add(this.videoPathTxt);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Upload";
            this.Text = "Upload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox videoPathTxt;
        private System.Windows.Forms.TextBox posterPathTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.RichTextBox ovwTxt;
        private System.Windows.Forms.Button videoBrowseBtn;
        private System.Windows.Forms.Button posterBrowseBtn;
        private System.Windows.Forms.OpenFileDialog openVideoDialog;
        private System.Windows.Forms.OpenFileDialog openPosterDialog;
    }
}