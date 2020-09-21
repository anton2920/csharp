namespace TouristFirmForm
{
	partial class FormRoutes
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelCountry = new System.Windows.Forms.Label();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.comboBoxClimate = new System.Windows.Forms.ComboBox();
			this.labelClimate = new System.Windows.Forms.Label();
			this.labelDuration = new System.Windows.Forms.Label();
			this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
			this.labelHotel = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.textBoxHotel = new System.Windows.Forms.TextBox();
			this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonSave.Location = new System.Drawing.Point(0, 103);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(448, 23);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// labelCountry
			// 
			this.labelCountry.AutoSize = true;
			this.labelCountry.Location = new System.Drawing.Point(12, 21);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new System.Drawing.Size(43, 13);
			this.labelCountry.TabIndex = 1;
			this.labelCountry.Text = "Country";
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Location = new System.Drawing.Point(61, 18);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(121, 20);
			this.textBoxCountry.TabIndex = 2;
			// 
			// comboBoxClimate
			// 
			this.comboBoxClimate.FormattingEnabled = true;
			this.comboBoxClimate.Items.AddRange(new object[] {
            "Tropical",
            "Dry",
            "Temperate",
            "Continental",
            "Polar"});
			this.comboBoxClimate.Location = new System.Drawing.Point(61, 44);
			this.comboBoxClimate.Name = "comboBoxClimate";
			this.comboBoxClimate.Size = new System.Drawing.Size(121, 21);
			this.comboBoxClimate.TabIndex = 3;
			// 
			// labelClimate
			// 
			this.labelClimate.AutoSize = true;
			this.labelClimate.Location = new System.Drawing.Point(12, 47);
			this.labelClimate.Name = "labelClimate";
			this.labelClimate.Size = new System.Drawing.Size(41, 13);
			this.labelClimate.TabIndex = 4;
			this.labelClimate.Text = "Climate";
			// 
			// labelDuration
			// 
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(12, 73);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(47, 13);
			this.labelDuration.TabIndex = 5;
			this.labelDuration.Text = "Duration";
			// 
			// numericUpDownDuration
			// 
			this.numericUpDownDuration.Location = new System.Drawing.Point(61, 71);
			this.numericUpDownDuration.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numericUpDownDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownDuration.Name = "numericUpDownDuration";
			this.numericUpDownDuration.Size = new System.Drawing.Size(121, 20);
			this.numericUpDownDuration.TabIndex = 6;
			this.numericUpDownDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelHotel
			// 
			this.labelHotel.AutoSize = true;
			this.labelHotel.Location = new System.Drawing.Point(249, 21);
			this.labelHotel.Name = "labelHotel";
			this.labelHotel.Size = new System.Drawing.Size(32, 13);
			this.labelHotel.TabIndex = 7;
			this.labelHotel.Text = "Hotel";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(250, 47);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(31, 13);
			this.labelPrice.TabIndex = 8;
			this.labelPrice.Text = "Price";
			// 
			// textBoxHotel
			// 
			this.textBoxHotel.Location = new System.Drawing.Point(287, 18);
			this.textBoxHotel.Name = "textBoxHotel";
			this.textBoxHotel.Size = new System.Drawing.Size(121, 20);
			this.textBoxHotel.TabIndex = 9;
			// 
			// numericUpDownPrice
			// 
			this.numericUpDownPrice.DecimalPlaces = 2;
			this.numericUpDownPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericUpDownPrice.Location = new System.Drawing.Point(287, 45);
			this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownPrice.Name = "numericUpDownPrice";
			this.numericUpDownPrice.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownPrice.TabIndex = 10;
			this.numericUpDownPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// FormRoutes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 126);
			this.Controls.Add(this.numericUpDownPrice);
			this.Controls.Add(this.textBoxHotel);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelHotel);
			this.Controls.Add(this.numericUpDownDuration);
			this.Controls.Add(this.labelDuration);
			this.Controls.Add(this.labelClimate);
			this.Controls.Add(this.comboBoxClimate);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.labelCountry);
			this.Controls.Add(this.buttonSave);
			this.MaximumSize = new System.Drawing.Size(464, 165);
			this.MinimumSize = new System.Drawing.Size(464, 165);
			this.Name = "FormRoutes";
			this.Text = "Routes";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelCountry;
		private System.Windows.Forms.TextBox textBoxCountry;
		private System.Windows.Forms.ComboBox comboBoxClimate;
		private System.Windows.Forms.Label labelClimate;
		private System.Windows.Forms.Label labelDuration;
		private System.Windows.Forms.NumericUpDown numericUpDownDuration;
		private System.Windows.Forms.Label labelHotel;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxHotel;
		private System.Windows.Forms.NumericUpDown numericUpDownPrice;
	}
}