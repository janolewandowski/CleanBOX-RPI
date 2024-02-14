
namespace PrototypeRasbianV1._1
{
    partial class Cleanbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleanbox));
            this.LightButton = new System.Windows.Forms.Button();
            this.UvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LightButton
            // 
            this.LightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.LightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LightButton.BackgroundImage")));
            this.LightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightButton.ForeColor = System.Drawing.Color.Snow;
            this.LightButton.Location = new System.Drawing.Point(26, 12);
            this.LightButton.Name = "LightButton";
            this.LightButton.Size = new System.Drawing.Size(217, 198);
            this.LightButton.TabIndex = 0;
            this.LightButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LightButton.UseVisualStyleBackColor = false;
            this.LightButton.Click += new System.EventHandler(this.LightButton_Click);
            // 
            // UvButton
            // 
            this.UvButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.UvButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UvButton.BackgroundImage")));
            this.UvButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UvButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UvButton.ForeColor = System.Drawing.Color.Snow;
            this.UvButton.Location = new System.Drawing.Point(26, 269);
            this.UvButton.Name = "UvButton";
            this.UvButton.Size = new System.Drawing.Size(217, 198);
            this.UvButton.TabIndex = 1;
            this.UvButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UvButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UvButton.UseVisualStyleBackColor = false;
            this.UvButton.Click += new System.EventHandler(this.UvButton_Click);
            // 
            // Cleanbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 513);
            this.Controls.Add(this.UvButton);
            this.Controls.Add(this.LightButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cleanbox";
            this.Text = "Cleanbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LightButton;
        private System.Windows.Forms.Button UvButton;
    }
}