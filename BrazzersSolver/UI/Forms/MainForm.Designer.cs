namespace BrazzersSolver.UI.Forms
{
    partial class MainForm
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
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGetRnKey = new System.Windows.Forms.Button();
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.tbRnKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetRnKey
            // 
            this.btnGetRnKey.Location = new System.Drawing.Point(12, 142);
            this.btnGetRnKey.Name = "btnGetRnKey";
            this.btnGetRnKey.Size = new System.Drawing.Size(307, 23);
            this.btnGetRnKey.TabIndex = 0;
            this.btnGetRnKey.Text = "Get RN Key";
            this.btnGetRnKey.UseVisualStyleBackColor = true;
            this.btnGetRnKey.Click += new System.EventHandler(this.btnGetRnKey_Click);
            // 
            // rtbSource
            // 
            this.rtbSource.Location = new System.Drawing.Point(12, 12);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(307, 124);
            this.rtbSource.TabIndex = 1;
            this.rtbSource.Text = resources.GetString("rtbSource.Text");
            // 
            // tbRnKey
            // 
            this.tbRnKey.Location = new System.Drawing.Point(13, 172);
            this.tbRnKey.Name = "tbRnKey";
            this.tbRnKey.Size = new System.Drawing.Size(306, 21);
            this.tbRnKey.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 204);
            this.Controls.Add(this.tbRnKey);
            this.Controls.Add(this.rtbSource);
            this.Controls.Add(this.btnGetRnKey);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRnKey;
        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.TextBox tbRnKey;
    }
}