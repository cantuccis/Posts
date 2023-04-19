namespace LogsUI.Screens
{
    partial class LogsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogsTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnGoBack = new MaterialSkin.Controls.MaterialButton();
            this.logsList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblLogsTitle
            // 
            this.lblLogsTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogsTitle.Depth = 0;
            this.lblLogsTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblLogsTitle.HighEmphasis = true;
            this.lblLogsTitle.Location = new System.Drawing.Point(176, 8);
            this.lblLogsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogsTitle.Name = "lblLogsTitle";
            this.lblLogsTitle.Size = new System.Drawing.Size(248, 40);
            this.lblLogsTitle.TabIndex = 0;
            this.lblLogsTitle.Text = "Logs";
            this.lblLogsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoBack
            // 
            this.btnGoBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGoBack.Depth = 0;
            this.btnGoBack.HighEmphasis = false;
            this.btnGoBack.Icon = null;
            this.btnGoBack.Location = new System.Drawing.Point(8, 8);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGoBack.Size = new System.Drawing.Size(83, 36);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnGoBack.UseAccentColor = true;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // logsList
            // 
            this.logsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logsList.AutoScroll = true;
            this.logsList.Location = new System.Drawing.Point(24, 72);
            this.logsList.Name = "logsList";
            this.logsList.Size = new System.Drawing.Size(552, 376);
            this.logsList.TabIndex = 2;
            // 
            // LogsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logsList);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblLogsTitle);
            this.Name = "LogsScreen";
            this.Size = new System.Drawing.Size(593, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblLogsTitle;
        private MaterialSkin.Controls.MaterialButton btnGoBack;
        private System.Windows.Forms.FlowLayoutPanel logsList;
    }
}
