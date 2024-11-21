namespace HLS_GUI
{
    partial class player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.play_btn = new System.Windows.Forms.Button();
            this.replay_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.set_quality = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(491, 618);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(179, 42);
            this.play_btn.TabIndex = 8;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click_1);
            // 
            // replay_btn
            // 
            this.replay_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay_btn.Location = new System.Drawing.Point(775, 618);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(179, 42);
            this.replay_btn.TabIndex = 7;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = true;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click_1);
            // 
            // pause_btn
            // 
            this.pause_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_btn.Location = new System.Drawing.Point(194, 618);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(179, 42);
            this.pause_btn.TabIndex = 6;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(86, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 501);
            this.panel1.TabIndex = 5;
            // 
            // set_quality
            // 
            this.set_quality.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_quality.FormattingEnabled = true;
            this.set_quality.Location = new System.Drawing.Point(1040, 618);
            this.set_quality.Name = "set_quality";
            this.set_quality.Size = new System.Drawing.Size(138, 39);
            this.set_quality.TabIndex = 9;
            this.set_quality.Text = "Resolution";
            this.set_quality.SelectedIndexChanged += new System.EventHandler(this.set_quality_SelectedIndexChanged);
           
            // 
            // player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 705);
            this.Controls.Add(this.set_quality);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.replay_btn);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.panel1);
            this.Name = "player";
            this.Text = "player";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox set_quality;
    }
}