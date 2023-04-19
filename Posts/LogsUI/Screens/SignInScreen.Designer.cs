namespace LogsUI.Screens
{
    partial class SignInScreen
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
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSignIn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPicture
            // 
            this.iconPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPicture.Image = global::LogsUI.Properties.Resources.user_icon;
            this.iconPicture.Location = new System.Drawing.Point(203, 24);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(192, 176);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicture.TabIndex = 0;
            this.iconPicture.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(171, 216);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(250, 50);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSignIn.AutoSize = false;
            this.btnSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSignIn.Depth = 0;
            this.btnSignIn.HighEmphasis = true;
            this.btnSignIn.Icon = null;
            this.btnSignIn.Location = new System.Drawing.Point(219, 288);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignIn.Size = new System.Drawing.Size(158, 32);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSignIn.UseAccentColor = false;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.iconPicture);
            this.Name = "SignInScreen";
            this.Size = new System.Drawing.Size(593, 360);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPicture;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialButton btnSignIn;
    }
}
