namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.topPanel = new System.Windows.Forms.Panel();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.leftPanel = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.leftSplitter = new System.Windows.Forms.Splitter();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.emailBodyTextBox = new System.Windows.Forms.TextBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.emailsListBox = new System.Windows.Forms.ListBox();
			this.leftPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(570, 74);
			this.topPanel.TabIndex = 0;
			// 
			// bottomPanel
			// 
			this.bottomPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 394);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(570, 32);
			this.bottomPanel.TabIndex = 1;
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.leftPanel.Controls.Add(this.button3);
			this.leftPanel.Controls.Add(this.button2);
			this.leftPanel.Controls.Add(this.button1);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 74);
			this.leftPanel.MinimumSize = new System.Drawing.Size(10, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(200, 320);
			this.leftPanel.TabIndex = 2;
			this.leftPanel.DoubleClick += new System.EventHandler(this.LeftPanel_DoubleClick);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.Khaki;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(3, 114);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(194, 48);
			this.button3.TabIndex = 2;
			this.button3.Text = "&Sent Items";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.Khaki;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(3, 60);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(194, 48);
			this.button2.TabIndex = 1;
			this.button2.Text = "&Outbox";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Khaki;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(3, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(194, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "&Inbox";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// leftSplitter
			// 
			this.leftSplitter.BackColor = System.Drawing.Color.LightGray;
			this.leftSplitter.Location = new System.Drawing.Point(200, 74);
			this.leftSplitter.Name = "leftSplitter";
			this.leftSplitter.Size = new System.Drawing.Size(10, 320);
			this.leftSplitter.TabIndex = 3;
			this.leftSplitter.TabStop = false;
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Silver;
			this.mainPanel.Controls.Add(this.emailBodyTextBox);
			this.mainPanel.Controls.Add(this.splitter1);
			this.mainPanel.Controls.Add(this.emailsListBox);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(210, 74);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(360, 320);
			this.mainPanel.TabIndex = 4;
			// 
			// emailBodyTextBox
			// 
			this.emailBodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.emailBodyTextBox.Location = new System.Drawing.Point(0, 142);
			this.emailBodyTextBox.Multiline = true;
			this.emailBodyTextBox.Name = "emailBodyTextBox";
			this.emailBodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.emailBodyTextBox.Size = new System.Drawing.Size(360, 178);
			this.emailBodyTextBox.TabIndex = 2;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.LightGray;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 132);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(360, 10);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// emailsListBox
			// 
			this.emailsListBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.emailsListBox.FormattingEnabled = true;
			this.emailsListBox.ItemHeight = 16;
			this.emailsListBox.Location = new System.Drawing.Point(0, 0);
			this.emailsListBox.Name = "emailsListBox";
			this.emailsListBox.Size = new System.Drawing.Size(360, 132);
			this.emailsListBox.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(570, 426);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.leftSplitter);
			this.Controls.Add(this.leftPanel);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.leftPanel.ResumeLayout(false);
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Splitter leftSplitter;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox emailBodyTextBox;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListBox emailsListBox;
	}
}
