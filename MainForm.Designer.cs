/*
 * Created by SharpDevelop.
 * User: benoit le guern
 * Date: 09/06/2008
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Support
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
			this.groupBoxInformation = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxInformation
			// 
			this.groupBoxInformation.Controls.Add(this.label4);
			this.groupBoxInformation.Controls.Add(this.label3);
			this.groupBoxInformation.Controls.Add(this.label2);
			this.groupBoxInformation.Controls.Add(this.label1);
			this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
			this.groupBoxInformation.Name = "groupBoxInformation";
			this.groupBoxInformation.Size = new System.Drawing.Size(614, 190);
			this.groupBoxInformation.TabIndex = 0;
			this.groupBoxInformation.TabStop = false;
			this.groupBoxInformation.Text = "Information";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(149, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(390, 120);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(149, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 394);
			this.Controls.Add(this.groupBoxInformation);
			this.Name = "MainForm";
			this.Text = "Support Modling";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBoxInformation.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBoxInformation;
	}
}
