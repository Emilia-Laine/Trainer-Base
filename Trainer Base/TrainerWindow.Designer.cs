
namespace Trainer_Base
{
    partial class TrainerWindow
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
            this.netSealBackground = new NSTheme();
            this.minimizeButton = new NSControlButton();
            this.closeButton = new NSControlButton();
            this.hackGroupBox = new NSGroupBox();
            this.hackButton = new NSButton();
            this.netSealBackground.SuspendLayout();
            this.hackGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // netSealBackground
            // 
            this.netSealBackground.AccentOffset = 0;
            this.netSealBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.netSealBackground.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.netSealBackground.Colors = new Bloom[0];
            this.netSealBackground.Controls.Add(this.hackGroupBox);
            this.netSealBackground.Controls.Add(this.minimizeButton);
            this.netSealBackground.Controls.Add(this.closeButton);
            this.netSealBackground.Customization = "";
            this.netSealBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netSealBackground.Font = new System.Drawing.Font("Verdana", 8F);
            this.netSealBackground.Image = null;
            this.netSealBackground.Location = new System.Drawing.Point(0, 0);
            this.netSealBackground.Movable = true;
            this.netSealBackground.Name = "netSealBackground";
            this.netSealBackground.NoRounding = false;
            this.netSealBackground.Sizable = false;
            this.netSealBackground.Size = new System.Drawing.Size(494, 199);
            this.netSealBackground.SmartBounds = true;
            this.netSealBackground.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.netSealBackground.TabIndex = 0;
            this.netSealBackground.Text = "Trainer Base";
            this.netSealBackground.TransparencyKey = System.Drawing.Color.Empty;
            this.netSealBackground.Transparent = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.ControlButton = NSControlButton.Button.Minimize;
            this.minimizeButton.Location = new System.Drawing.Point(447, 3);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(18, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "minimizeButton";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ControlButton = NSControlButton.Button.Close;
            this.closeButton.Location = new System.Drawing.Point(472, 3);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.closeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "closeButton";
            // 
            // hackGroupBox
            // 
            this.hackGroupBox.Controls.Add(this.hackButton);
            this.hackGroupBox.DrawSeperator = false;
            this.hackGroupBox.Location = new System.Drawing.Point(12, 41);
            this.hackGroupBox.Name = "hackGroupBox";
            this.hackGroupBox.Size = new System.Drawing.Size(142, 80);
            this.hackGroupBox.SubTitle = "Your hacks here!";
            this.hackGroupBox.TabIndex = 2;
            this.hackGroupBox.Title = "Hacks";
            // 
            // hackButton
            // 
            this.hackButton.Location = new System.Drawing.Point(19, 43);
            this.hackButton.Name = "hackButton";
            this.hackButton.Size = new System.Drawing.Size(105, 23);
            this.hackButton.TabIndex = 3;
            this.hackButton.Text = "Hack button!";
            this.hackButton.Click += new System.EventHandler(this.hackButton_Click);
            // 
            // TrainerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 199);
            this.Controls.Add(this.netSealBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TrainerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer Base";
            this.Load += new System.EventHandler(this.TrainerWindow_Load);
            this.netSealBackground.ResumeLayout(false);
            this.hackGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme netSealBackground;
        private NSControlButton closeButton;
        private NSControlButton minimizeButton;
        private NSGroupBox hackGroupBox;
        private NSButton hackButton;
    }
}

