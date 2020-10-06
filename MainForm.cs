/*
 * Created by SharpDevelop.
 * User: benoit le guern
 * Date: 09/06/2008
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Text;


namespace Support
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			PingPasserelle();
		}
		
		
		void PingPasserelle()
		{
			Ping pingSender = new Ping ();
            PingOptions options = new PingOptions ();

			string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            
			byte[] buffer = Encoding.ASCII.GetBytes (data);
			
            int timeout = 120;
            
            PingReply reply = pingSender.Send ("192.168.1.12", timeout, buffer, options);
            
            if (reply.Status == IPStatus.Success)
            {
            	label4.Text = "";
                label4.Text += "Address: " + reply.Address.ToString() + "\n";
                label4.Text += "RoundTrip time: " + reply.RoundtripTime + "\n";
                label4.Text += "Time to live: " + reply.Options.Ttl + "\n";
                label4.Text += "Don't fragment: " + reply.Options.DontFragment + "\n";
                label4.Text += "Buffer size: " + reply.Buffer.Length;
            }
            else
            {
            	label4.Text = "ERREUR!";
            }
			
		}
		
		
		
	}
}
