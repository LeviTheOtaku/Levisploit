namespace Levisploit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MonacoTextbox = new System.Windows.Forms.WebBrowser();
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.attachButton = new System.Windows.Forms.Button();
            this.scriptListButton = new System.Windows.Forms.Button();
            this.scriptHubButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.executeFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openSettingsButton = new System.Windows.Forms.Button();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MonacoTextbox
            // 
            this.MonacoTextbox.Location = new System.Drawing.Point(10, 35);
            this.MonacoTextbox.MinimumSize = new System.Drawing.Size(20, 20);
            this.MonacoTextbox.Name = "MonacoTextbox";
            this.MonacoTextbox.Size = new System.Drawing.Size(642, 305);
            this.MonacoTextbox.TabIndex = 0;
            this.MonacoTextbox.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MonacoTextbox_DocumentCompleted);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.titleLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MaximumSize = new System.Drawing.Size(800, 25);
            this.titleLabel.MinimumSize = new System.Drawing.Size(800, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Levisploit";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
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
            this.minimizeButton.Location = new System.Drawing.Point(740, 0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 6;
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
            this.closeButton.Location = new System.Drawing.Point(775, 0);
            this.closeButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.closeButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(660, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 30);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.executeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.executeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.executeButton.FlatAppearance.BorderSize = 0;
            this.executeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.executeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.executeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.ForeColor = System.Drawing.Color.White;
            this.executeButton.Location = new System.Drawing.Point(660, 35);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(130, 30);
            this.executeButton.TabIndex = 7;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // attachButton
            // 
            this.attachButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.attachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.attachButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attachButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.attachButton.FlatAppearance.BorderSize = 0;
            this.attachButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.attachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachButton.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.attachButton.ForeColor = System.Drawing.Color.White;
            this.attachButton.Location = new System.Drawing.Point(660, 310);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(130, 30);
            this.attachButton.TabIndex = 14;
            this.attachButton.Text = "Attach";
            this.attachButton.UseVisualStyleBackColor = false;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // scriptListButton
            // 
            this.scriptListButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.scriptListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scriptListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scriptListButton.FlatAppearance.BorderSize = 0;
            this.scriptListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.scriptListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.scriptListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scriptListButton.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.scriptListButton.ForeColor = System.Drawing.Color.White;
            this.scriptListButton.Location = new System.Drawing.Point(658, 179);
            this.scriptListButton.Name = "scriptListButton";
            this.scriptListButton.Size = new System.Drawing.Size(130, 30);
            this.scriptListButton.TabIndex = 13;
            this.scriptListButton.Text = "Script List";
            this.scriptListButton.UseVisualStyleBackColor = false;
            this.scriptListButton.Click += new System.EventHandler(this.scriptListButton_Click);
            // 
            // scriptHubButton
            // 
            this.scriptHubButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.scriptHubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptHubButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scriptHubButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scriptHubButton.FlatAppearance.BorderSize = 0;
            this.scriptHubButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.scriptHubButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.scriptHubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scriptHubButton.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.scriptHubButton.ForeColor = System.Drawing.Color.White;
            this.scriptHubButton.Location = new System.Drawing.Point(658, 215);
            this.scriptHubButton.Name = "scriptHubButton";
            this.scriptHubButton.Size = new System.Drawing.Size(130, 30);
            this.scriptHubButton.TabIndex = 15;
            this.scriptHubButton.Text = "Script Hub";
            this.scriptHubButton.UseVisualStyleBackColor = false;
            this.scriptHubButton.Click += new System.EventHandler(this.scriptHubButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.openFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openFileButton.FlatAppearance.BorderSize = 0;
            this.openFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.Location = new System.Drawing.Point(632, 0);
            this.openFileButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.openFileButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(25, 25);
            this.openFileButton.TabIndex = 16;
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // executeFileButton
            // 
            this.executeFileButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.executeFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeFileButton.FlatAppearance.BorderSize = 0;
            this.executeFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeFileButton.Image = ((System.Drawing.Image)(resources.GetObject("executeFileButton.Image")));
            this.executeFileButton.Location = new System.Drawing.Point(663, 0);
            this.executeFileButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.executeFileButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.executeFileButton.Name = "executeFileButton";
            this.executeFileButton.Size = new System.Drawing.Size(25, 25);
            this.executeFileButton.TabIndex = 17;
            this.executeFileButton.UseVisualStyleBackColor = false;
            this.executeFileButton.Click += new System.EventHandler(this.executeFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.saveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveFileButton.FlatAppearance.BorderSize = 0;
            this.saveFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.Location = new System.Drawing.Point(694, 0);
            this.saveFileButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.saveFileButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(25, 25);
            this.saveFileButton.TabIndex = 18;
            this.saveFileButton.UseVisualStyleBackColor = false;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openSettingsButton
            // 
            this.openSettingsButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.openSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openSettingsButton.FlatAppearance.BorderSize = 0;
            this.openSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.openSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("openSettingsButton.Image")));
            this.openSettingsButton.Location = new System.Drawing.Point(600, 0);
            this.openSettingsButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.openSettingsButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.openSettingsButton.Name = "openSettingsButton";
            this.openSettingsButton.Size = new System.Drawing.Size(25, 25);
            this.openSettingsButton.TabIndex = 22;
            this.openSettingsButton.UseVisualStyleBackColor = false;
            this.openSettingsButton.Click += new System.EventHandler(this.openSettingsButton_Click);
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.openSettingsButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.executeFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.scriptHubButton);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.scriptListButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.MonacoTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levisploit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Button scriptListButton;
        public System.Windows.Forms.WebBrowser MonacoTextbox;
        private System.Windows.Forms.Button scriptHubButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button executeFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openSettingsButton;
        private System.Windows.Forms.Timer statusTimer;
    }
}

