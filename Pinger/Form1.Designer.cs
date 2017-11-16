﻿namespace Pinger
{
    partial class Pinger
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
            this.IPBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.PingDelayBox = new System.Windows.Forms.TextBox();
            this.PingDelayLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.isLive = new System.Windows.Forms.CheckBox();
            this.LiveLabel = new System.Windows.Forms.Label();
            this.RespondingLabel = new System.Windows.Forms.Label();
            this.IsResponding = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(15, 45);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(245, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "127.0.0.1";
            this.IPBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 19);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(55, 13);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP-Adress:";
            // 
            // PingDelayBox
            // 
            this.PingDelayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PingDelayBox.Location = new System.Drawing.Point(15, 102);
            this.PingDelayBox.Name = "PingDelayBox";
            this.PingDelayBox.Size = new System.Drawing.Size(52, 20);
            this.PingDelayBox.TabIndex = 2;
            this.PingDelayBox.Text = "2";
            this.PingDelayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PingDelayBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // PingDelayLabel
            // 
            this.PingDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PingDelayLabel.AutoSize = true;
            this.PingDelayLabel.Location = new System.Drawing.Point(12, 76);
            this.PingDelayLabel.Name = "PingDelayLabel";
            this.PingDelayLabel.Size = new System.Drawing.Size(87, 13);
            this.PingDelayLabel.TabIndex = 3;
            this.PingDelayLabel.Text = "Ping Delay (sec):";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(267, 99);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(70, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelayBox
            // 
            this.DelayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayBox.Location = new System.Drawing.Point(267, 45);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.ReadOnly = true;
            this.DelayBox.Size = new System.Drawing.Size(70, 20);
            this.DelayBox.TabIndex = 5;
            this.DelayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelayLabel
            // 
            this.DelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(264, 19);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(59, 13);
            this.DelayLabel.TabIndex = 6;
            this.DelayLabel.Text = "Delay (ms):";
            // 
            // isLive
            // 
            this.isLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.isLive.AutoSize = true;
            this.isLive.Enabled = false;
            this.isLive.Location = new System.Drawing.Point(241, 104);
            this.isLive.Name = "isLive";
            this.isLive.Size = new System.Drawing.Size(15, 14);
            this.isLive.TabIndex = 7;
            this.isLive.UseVisualStyleBackColor = true;
            // 
            // LiveLabel
            // 
            this.LiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveLabel.AutoSize = true;
            this.LiveLabel.Location = new System.Drawing.Point(205, 104);
            this.LiveLabel.Name = "LiveLabel";
            this.LiveLabel.Size = new System.Drawing.Size(30, 13);
            this.LiveLabel.TabIndex = 8;
            this.LiveLabel.Text = "Live:";
            // 
            // RespondingLabel
            // 
            this.RespondingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RespondingLabel.AutoSize = true;
            this.RespondingLabel.Location = new System.Drawing.Point(176, 19);
            this.RespondingLabel.Name = "RespondingLabel";
            this.RespondingLabel.Size = new System.Drawing.Size(67, 13);
            this.RespondingLabel.TabIndex = 10;
            this.RespondingLabel.Text = "Responding:";
            // 
            // IsResponding
            // 
            this.IsResponding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IsResponding.AutoSize = true;
            this.IsResponding.Enabled = false;
            this.IsResponding.Location = new System.Drawing.Point(245, 19);
            this.IsResponding.Name = "IsResponding";
            this.IsResponding.Size = new System.Drawing.Size(15, 14);
            this.IsResponding.TabIndex = 9;
            this.IsResponding.UseVisualStyleBackColor = true;
            // 
            // Pinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 138);
            this.Controls.Add(this.RespondingLabel);
            this.Controls.Add(this.IsResponding);
            this.Controls.Add(this.LiveLabel);
            this.Controls.Add(this.isLive);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PingDelayLabel);
            this.Controls.Add(this.PingDelayBox);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.IPBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 177);
            this.MinimumSize = new System.Drawing.Size(371, 177);
            this.Name = "Pinger";
            this.ShowIcon = false;
            this.Text = "Pinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox PingDelayBox;
        private System.Windows.Forms.Label PingDelayLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.CheckBox isLive;
        private System.Windows.Forms.Label LiveLabel;
        private System.Windows.Forms.Label RespondingLabel;
        private System.Windows.Forms.CheckBox IsResponding;
    }
}
