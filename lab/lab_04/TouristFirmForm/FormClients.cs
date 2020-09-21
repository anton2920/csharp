using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristFirmForm
{
	public partial class FormClients : Form
	{
		private TouristFirm.Clients Client;

		public FormClients(ref TouristFirm.Clients client)
		{
			InitializeComponent();

			textBoxFirstName.Text = client.FirstName;
			textBoxLastName.Text = client.LastName;
			textBoxAddress.Text = client.Address;
			textBoxPhone.Text = client.Phone;
			
			Client = client;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var c = new TouristFirm.Clients(textBoxFirstName.Text, textBoxLastName.Text, 
				textBoxAddress.Text, textBoxPhone.Text);

			if (c.IsValid)
			{
				Client.FirstName = c.FirstName;
				Client.LastName = c.LastName;
				Client.Address = c.Address;
				Client.Phone = c.Phone;
			}
			else
			{
				MessageBox.Show("Some fields are not correctly filled!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
