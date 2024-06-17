namespace SteamConnectionBlocker
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.switch_blockConnection = new MaterialSkin.Controls.MaterialSwitch();
            this.btn_about = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // switch_blockConnection
            // 
            this.switch_blockConnection.AutoSize = true;
            this.switch_blockConnection.Depth = 0;
            this.switch_blockConnection.Location = new System.Drawing.Point(44, 145);
            this.switch_blockConnection.Margin = new System.Windows.Forms.Padding(0);
            this.switch_blockConnection.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_blockConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_blockConnection.Name = "switch_blockConnection";
            this.switch_blockConnection.Ripple = true;
            this.switch_blockConnection.Size = new System.Drawing.Size(181, 37);
            this.switch_blockConnection.TabIndex = 0;
            this.switch_blockConnection.Text = "Block Connection";
            this.switch_blockConnection.UseVisualStyleBackColor = true;
            this.switch_blockConnection.CheckedChanged += new System.EventHandler(this.switch_blockConnection_CheckedChanged);
            // 
            // btn_about
            // 
            this.btn_about.AutoSize = false;
            this.btn_about.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_about.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_about.Depth = 0;
            this.btn_about.HighEmphasis = true;
            this.btn_about.Icon = null;
            this.btn_about.Location = new System.Drawing.Point(205, 241);
            this.btn_about.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_about.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_about.Name = "btn_about";
            this.btn_about.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_about.Size = new System.Drawing.Size(70, 28);
            this.btn_about.TabIndex = 1;
            this.btn_about.Text = "About";
            this.btn_about.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_about.UseAccentColor = false;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 278);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.switch_blockConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Steam Connection Blocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch switch_blockConnection;
        private MaterialSkin.Controls.MaterialButton btn_about;
    }
}

