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
	public partial class FormRoutes : Form
	{
		private TouristFirm.Routes Route;

		public FormRoutes(ref TouristFirm.Routes route)
		{
			InitializeComponent();

			textBoxCountry.Text = route.Country;
			setClimate(route.ClimateType);
			numericUpDownDuration.Value = (route.Duration == 0) ? 1 : route.Duration;
			textBoxHotel.Text = route.Hotel;
			numericUpDownPrice.Value = Convert.ToDecimal((route.Price < 100.0) ? 100.0 : route.Price);

			Route = route;
		}

		private void setClimate(TouristFirm.ClimateEnum climate)
		{

			/* Initializing variables */
			var c = new TouristFirm.ClimateEnum[5];
			c[0] = ClimateEnum.Tropical;
			c[1] = ClimateEnum.Dry;
			c[2] = ClimateEnum.Temperate;
			c[3] = ClimateEnum.Continental;
			c[4] = ClimateEnum.Polar;

			int i = 0;

			/* VarCheck */
			if (climate == ClimateEnum.ClimateNone)
			{
				return;
			}

			/* Main part */
			foreach (var clim in c)
			{
				if (clim == climate)
				{
					break;
				}

				++i;
			}

			comboBoxClimate.SelectedItem = comboBoxClimate.Items[i];
		}

		private TouristFirm.ClimateEnum getClimate()
		{

			/* Initializing variables */
			var c = new TouristFirm.ClimateEnum[5];
			c[0] = ClimateEnum.Tropical;
			c[1] = ClimateEnum.Dry;
			c[2] = ClimateEnum.Temperate;
			c[3] = ClimateEnum.Continental;
			c[4] = ClimateEnum.Polar;

			int index = comboBoxClimate.SelectedIndex;

			/* Returning value */
			return (index > 4 || index < 0) ? ClimateEnum.ClimateNone : c[comboBoxClimate.SelectedIndex];
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{

			/* Initializing varialbes */
			decimal duration = numericUpDownDuration.Value;
			UInt32 UIntDuration = Convert.ToUInt32(duration);

			TouristFirm.Routes r = new Routes(textBoxCountry.Text, getClimate(),
				UIntDuration, textBoxHotel.Text, Convert.ToDouble(numericUpDownPrice.Value));

			/* VarCheck */
			if (r.IsValid)
			{
				Route.Country = r.Country;
				Route.ClimateType = r.ClimateType;
				Route.Duration = r.Duration;
				Route.Hotel = r.Hotel;
				Route.Price = r.Price;
			}
			else
			{
				MessageBox.Show("Some fields are not correctly filled!", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
