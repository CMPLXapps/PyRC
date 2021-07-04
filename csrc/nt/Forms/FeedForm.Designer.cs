
namespace xIPC.Forms
{
	partial class FeedForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedForm));
			this.Feed = new System.Windows.Forms.TextBox();
			this.InputBox = new System.Windows.Forms.TextBox();
			this.SendButton = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.SendButton)).BeginInit();
			this.SuspendLayout();
			// 
			// Feed
			// 
			this.Feed.AllowDrop = true;
			this.Feed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.Feed.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Feed.ForeColor = System.Drawing.Color.White;
			this.Feed.Location = new System.Drawing.Point(12, 12);
			this.Feed.Multiline = true;
			this.Feed.Name = "Feed";
			this.Feed.ReadOnly = true;
			this.Feed.Size = new System.Drawing.Size(743, 505);
			this.Feed.TabIndex = 0;
			// 
			// InputBox
			// 
			this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InputBox.ForeColor = System.Drawing.Color.White;
			this.InputBox.Location = new System.Drawing.Point(12, 523);
			this.InputBox.Multiline = true;
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(717, 20);
			this.InputBox.TabIndex = 1;
			// 
			// SendButton
			// 
			this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SendButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SendButton.ErrorImage")));
			this.SendButton.Image = global::xIPC.Properties.Resources.sendbuttondisabled;
			this.SendButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("SendButton.InitialImage")));
			this.SendButton.Location = new System.Drawing.Point(735, 523);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(20, 20);
			this.SendButton.TabIndex = 2;
			this.SendButton.TabStop = false;
			this.SendButton.Click += new System.EventHandler(this.sendButton_clicked);
			// 
			// FeedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			this.ClientSize = new System.Drawing.Size(767, 555);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.InputBox);
			this.Controls.Add(this.Feed);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "FeedForm";
			this.Text = "xIPC";
			((System.ComponentModel.ISupportInitialize)(this.SendButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Feed;
		private System.Windows.Forms.TextBox InputBox;
		private System.Windows.Forms.PictureBox SendButton;
	}
}