using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristFirm;

namespace TouristFirmForm
{
	public partial class FormMain : Form
	{
		private FormRoutes formRoutes;
		private FormClients formClients;

		private Routes route;
		private Clients client;

		public FormMain()
		{
			InitializeComponent();

			route = new Routes();
			client = new Clients();
		}

		private void callRouteForm(object sender, EventArgs e)
		{
			formRoutes = new FormRoutes(ref route);

			formRoutes.Show(this);
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			callRouteForm(sender, e);
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			callRouteForm(sender, e);
		}

		private void callClientsForm(object sender, EventArgs e)
		{
			formClients = new FormClients(ref client);

			formClients.Show();
		}

		private void addToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			callClientsForm(sender, e);
		}

		private void editToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			callClientsForm(sender, e);
		}
	}
}
