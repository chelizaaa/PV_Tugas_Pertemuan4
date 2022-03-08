/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3/8/2022
 * Time: 7:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Tugas4._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextboxNama = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonKirim = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TextboxNIM = new System.Windows.Forms.TextBox();
			this.TextboxKelas = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TextboxNama
			// 
			this.TextboxNama.Location = new System.Drawing.Point(104, 37);
			this.TextboxNama.Name = "TextboxNama";
			this.TextboxNama.Size = new System.Drawing.Size(100, 20);
			this.TextboxNama.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nama";
			// 
			// ButtonKirim
			// 
			this.ButtonKirim.Location = new System.Drawing.Point(104, 126);
			this.ButtonKirim.Name = "ButtonKirim";
			this.ButtonKirim.Size = new System.Drawing.Size(75, 23);
			this.ButtonKirim.TabIndex = 2;
			this.ButtonKirim.Text = "Kirim";
			this.ButtonKirim.UseVisualStyleBackColor = true;
			this.ButtonKirim.Click += new System.EventHandler(this.ButtonKirimClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "NIM";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kelas";
			// 
			// TextboxNIM
			// 
			this.TextboxNIM.Location = new System.Drawing.Point(104, 63);
			this.TextboxNIM.Name = "TextboxNIM";
			this.TextboxNIM.Size = new System.Drawing.Size(100, 20);
			this.TextboxNIM.TabIndex = 5;
			// 
			// TextboxKelas
			// 
			this.TextboxKelas.Location = new System.Drawing.Point(104, 89);
			this.TextboxKelas.Name = "TextboxKelas";
			this.TextboxKelas.Size = new System.Drawing.Size(100, 20);
			this.TextboxKelas.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.TextboxKelas);
			this.Controls.Add(this.TextboxNIM);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ButtonKirim);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextboxNama);
			this.Name = "MainForm";
			this.Text = "PV_Tugas4.2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox TextboxKelas;
		private System.Windows.Forms.TextBox TextboxNIM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ButtonKirim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextboxNama;
	}
}
