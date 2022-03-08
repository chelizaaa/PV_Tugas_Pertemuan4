/*
 * Created by SharpDevelop.
 * User: Cheliza Sriayu
 * Date: 3/8/2022
 * Time: 7:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Tugas4._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void ButtonKirimClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Nama Anda " + this.TextboxNama.Text + " dengan NIM " + this.TextboxNIM.Text + "\nAnda berada di kelas " + this.TextboxKelas.Text);
		}
	}
}
