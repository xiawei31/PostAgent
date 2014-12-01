namespace Parthas.PostAgent
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblPostUrlText = new System.Windows.Forms.Label();
            this.txtPostUrl = new System.Windows.Forms.TextBox();
            this.lblPostContent = new System.Windows.Forms.Label();
            this.txtPostContent = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResponse.Location = new System.Drawing.Point(0, 36);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(764, 323);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.WordWrap = false;
            // 
            // lblPostUrlText
            // 
            this.lblPostUrlText.AutoSize = true;
            this.lblPostUrlText.Location = new System.Drawing.Point(13, 13);
            this.lblPostUrlText.Name = "lblPostUrlText";
            this.lblPostUrlText.Size = new System.Drawing.Size(56, 13);
            this.lblPostUrlText.TabIndex = 1;
            this.lblPostUrlText.Text = "Post URL:";
            // 
            // txtPostUrl
            // 
            this.txtPostUrl.Location = new System.Drawing.Point(73, 10);
            this.txtPostUrl.Name = "txtPostUrl";
            this.txtPostUrl.Size = new System.Drawing.Size(220, 20);
            this.txtPostUrl.TabIndex = 2;
            this.txtPostUrl.Text = "http://xparthas.com/Pages/PostTest";
            // 
            // lblPostContent
            // 
            this.lblPostContent.AutoSize = true;
            this.lblPostContent.Location = new System.Drawing.Point(304, 13);
            this.lblPostContent.Name = "lblPostContent";
            this.lblPostContent.Size = new System.Drawing.Size(68, 13);
            this.lblPostContent.TabIndex = 3;
            this.lblPostContent.Text = "PostContent:";
            // 
            // txtPostContent
            // 
            this.txtPostContent.Location = new System.Drawing.Point(378, 10);
            this.txtPostContent.Name = "txtPostContent";
            this.txtPostContent.Size = new System.Drawing.Size(220, 20);
            this.txtPostContent.TabIndex = 4;
            this.txtPostContent.Text = "username=123&password=456";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(604, 8);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(685, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnPost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 359);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtPostContent);
            this.Controls.Add(this.lblPostContent);
            this.Controls.Add(this.txtPostUrl);
            this.Controls.Add(this.lblPostUrlText);
            this.Controls.Add(this.txtResponse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Post Agent";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblPostUrlText;
        private System.Windows.Forms.TextBox txtPostUrl;
        private System.Windows.Forms.Label lblPostContent;
        private System.Windows.Forms.TextBox txtPostContent;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnReset;
    }
}

