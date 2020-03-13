using System;

namespace Levisploit
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topMostToggle = new System.Windows.Forms.CheckBox();
            this.opacityChange = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.opacityChange)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeButton.Location = new System.Drawing.Point(140, 0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(175, 0);
            this.closeButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.closeButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 8;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.titleLabel.Font = new System.Drawing.Font("Myanmar Text", 14F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MaximumSize = new System.Drawing.Size(200, 25);
            this.titleLabel.MinimumSize = new System.Drawing.Size(200, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 25);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Settings";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
            // 
            // topMostToggle
            // 
            this.topMostToggle.AutoSize = true;
            this.topMostToggle.ForeColor = System.Drawing.Color.White;
            this.topMostToggle.Location = new System.Drawing.Point(6, 30);
            this.topMostToggle.Name = "topMostToggle";
            this.topMostToggle.Size = new System.Drawing.Size(67, 17);
            this.topMostToggle.TabIndex = 21;
            this.topMostToggle.Text = "Topmost";
            this.topMostToggle.UseVisualStyleBackColor = true;
            this.topMostToggle.CheckedChanged += new System.EventHandler(this.topMostToggle_CheckedChanged);
            // 
            // opacityChange
            // 
            this.opacityChange.LargeChange = 20;
            this.opacityChange.Location = new System.Drawing.Point(6, 55);
            this.opacityChange.Maximum = 100;
            this.opacityChange.Name = "opacityChange";
            this.opacityChange.Size = new System.Drawing.Size(175, 45);
            this.opacityChange.SmallChange = 5;
            this.opacityChange.TabIndex = 22;
            this.opacityChange.TickFrequency = 10;
            this.opacityChange.Scroll += new System.EventHandler(this.opacityChange_Scroll);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(200, 98);
            this.Controls.Add(this.opacityChange);
            this.Controls.Add(this.topMostToggle);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levisploit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opacityChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox topMostToggle;
        private System.Windows.Forms.TrackBar opacityChange;
    }
}