namespace LogsUI.Controls
{
    partial class LogCard
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
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimestamp = new MaterialSkin.Controls.MaterialLabel();
            this.lblAction = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.Location = new System.Drawing.Point(72, 8);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(424, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Depth = 0;
            this.lblTimestamp.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTimestamp.Location = new System.Drawing.Point(64, 40);
            this.lblTimestamp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(432, 24);
            this.lblTimestamp.TabIndex = 1;
            this.lblTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAction
            // 
            this.lblAction.Depth = 0;
            this.lblAction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAction.Location = new System.Drawing.Point(64, 72);
            this.lblAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(424, 24);
            this.lblAction.TabIndex = 2;
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblUsername);
            this.Name = "LogCard";
            this.Size = new System.Drawing.Size(508, 108);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblTimestamp;
        private MaterialSkin.Controls.MaterialLabel lblAction;
    }
}
