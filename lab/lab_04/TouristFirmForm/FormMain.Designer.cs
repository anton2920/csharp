namespace TouristFirmForm
{
	partial class FormMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItemRoutes = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItemRoutes = new System.Windows.Forms.ToolStripMenuItem();
			this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItemClients = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItemClients = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routesToolStripMenuItem,
            this.clientsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(396, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// routesToolStripMenuItem
			// 
			this.routesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItemRoutes,
            this.editToolStripMenuItemRoutes});
			this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
			this.routesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.routesToolStripMenuItem.Text = "Routes";
			// 
			// addToolStripMenuItemRoutes
			// 
			this.addToolStripMenuItemRoutes.Name = "addToolStripMenuItemRoutes";
			this.addToolStripMenuItemRoutes.Size = new System.Drawing.Size(180, 22);
			this.addToolStripMenuItemRoutes.Text = "Add";
			this.addToolStripMenuItemRoutes.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// editToolStripMenuItemRoutes
			// 
			this.editToolStripMenuItemRoutes.Name = "editToolStripMenuItemRoutes";
			this.editToolStripMenuItemRoutes.Size = new System.Drawing.Size(180, 22);
			this.editToolStripMenuItemRoutes.Text = "Edit";
			this.editToolStripMenuItemRoutes.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// clientsToolStripMenuItem
			// 
			this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItemClients,
            this.editToolStripMenuItemClients});
			this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
			this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.clientsToolStripMenuItem.Text = "Clients";
			// 
			// addToolStripMenuItemClients
			// 
			this.addToolStripMenuItemClients.Name = "addToolStripMenuItemClients";
			this.addToolStripMenuItemClients.Size = new System.Drawing.Size(180, 22);
			this.addToolStripMenuItemClients.Text = "Add";
			this.addToolStripMenuItemClients.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
			// 
			// editToolStripMenuItemClients
			// 
			this.editToolStripMenuItemClients.Name = "editToolStripMenuItemClients";
			this.editToolStripMenuItemClients.Size = new System.Drawing.Size(180, 22);
			this.editToolStripMenuItemClients.Text = "Edit";
			this.editToolStripMenuItemClients.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 217);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Main Window";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItemRoutes;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemRoutes;
		private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItemClients;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemClients;
	}
}

