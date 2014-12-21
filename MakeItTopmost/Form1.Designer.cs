namespace MakeItTopmost
{
	sealed partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.lb_titles = new System.Windows.Forms.ListBox();
			this.lb_hwnds = new System.Windows.Forms.ListBox();
			this.t_updater = new System.Windows.Forms.Timer(this.components);
			this.lb_pids = new System.Windows.Forms.ListBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// lb_titles
			// 
			this.lb_titles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_titles.FormattingEnabled = true;
			this.lb_titles.Location = new System.Drawing.Point(204, 13);
			this.lb_titles.Name = "lb_titles";
			this.lb_titles.Size = new System.Drawing.Size(323, 498);
			this.lb_titles.TabIndex = 0;
			this.toolTip1.SetToolTip(this.lb_titles, "DoubleClick to make the window Topmost");
			this.lb_titles.SelectedIndexChanged += new System.EventHandler(this.lb_titles_SelectedIndexChanged);
			this.lb_titles.DoubleClick += new System.EventHandler(this.lb_titles_DoubleClick);
			// 
			// lb_hwnds
			// 
			this.lb_hwnds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_hwnds.FormattingEnabled = true;
			this.lb_hwnds.Location = new System.Drawing.Point(108, 12);
			this.lb_hwnds.Name = "lb_hwnds";
			this.lb_hwnds.Size = new System.Drawing.Size(90, 498);
			this.lb_hwnds.TabIndex = 1;
			this.toolTip1.SetToolTip(this.lb_hwnds, "DoubleClick to make the window no-topmost");
			this.lb_hwnds.SelectedIndexChanged += new System.EventHandler(this.lb_hwnds_SelectedIndexChanged);
			this.lb_hwnds.DoubleClick += new System.EventHandler(this.lb_hwnds_DoubleClick);
			// 
			// t_updater
			// 
			this.t_updater.Enabled = true;
			this.t_updater.Interval = 5000;
			this.t_updater.Tick += new System.EventHandler(this.t_updater_Tick);
			// 
			// lb_pids
			// 
			this.lb_pids.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_pids.FormattingEnabled = true;
			this.lb_pids.Location = new System.Drawing.Point(12, 12);
			this.lb_pids.Name = "lb_pids";
			this.lb_pids.Size = new System.Drawing.Size(90, 498);
			this.lb_pids.TabIndex = 2;
			this.toolTip1.SetToolTip(this.lb_pids, "That\'s a PID of a window maker");
			this.lb_pids.SelectedIndexChanged += new System.EventHandler(this.lb_pids_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 523);
			this.Controls.Add(this.lb_pids);
			this.Controls.Add(this.lb_hwnds);
			this.Controls.Add(this.lb_titles);
			this.Name = "Form1";
			this.Text = "MakeItTopmost";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lb_titles;
		private System.Windows.Forms.ListBox lb_hwnds;
		private System.Windows.Forms.Timer t_updater;
		private System.Windows.Forms.ListBox lb_pids;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

