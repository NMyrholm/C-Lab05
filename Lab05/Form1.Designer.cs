namespace Lab05
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.labelMatches = new System.Windows.Forms.Label();
            this.buttonSaveImages = new System.Windows.Forms.Button();
            this.textBoxImages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(12, 21);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(695, 20);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtract.Enabled = false;
            this.buttonExtract.Location = new System.Drawing.Point(713, 21);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(75, 23);
            this.buttonExtract.TabIndex = 2;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // labelMatches
            // 
            this.labelMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMatches.AutoSize = true;
            this.labelMatches.Location = new System.Drawing.Point(12, 425);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(85, 13);
            this.labelMatches.TabIndex = 3;
            this.labelMatches.Text = "Found 0 images.";
            // 
            // buttonSaveImages
            // 
            this.buttonSaveImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveImages.Enabled = false;
            this.buttonSaveImages.Location = new System.Drawing.Point(701, 414);
            this.buttonSaveImages.Name = "buttonSaveImages";
            this.buttonSaveImages.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveImages.TabIndex = 4;
            this.buttonSaveImages.Text = "Save Images";
            this.buttonSaveImages.UseVisualStyleBackColor = true;
            this.buttonSaveImages.Click += new System.EventHandler(this.buttonSaveImages_Click);
            // 
            // textBoxImages
            // 
            this.textBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImages.Location = new System.Drawing.Point(12, 50);
            this.textBoxImages.Multiline = true;
            this.textBoxImages.Name = "textBoxImages";
            this.textBoxImages.ReadOnly = true;
            this.textBoxImages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxImages.Size = new System.Drawing.Size(775, 337);
            this.textBoxImages.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonExtract;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxImages);
            this.Controls.Add(this.buttonSaveImages);
            this.Controls.Add(this.labelMatches);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.textBoxUrl);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Button buttonSaveImages;
        private System.Windows.Forms.TextBox textBoxImages;
    }
}

