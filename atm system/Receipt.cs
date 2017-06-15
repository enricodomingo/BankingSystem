
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace atmsystem
{
	public partial class Receipt
	{
		public Receipt()
		{
			InitializeComponent();
			
		
		}
		
#region Default Instance
		
		private static Receipt defaultInstance;
		
		
		public static Receipt Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Receipt();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion


		public void Receipt_Load(System.Object sender, System.EventArgs e)
		{

		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			
		}
	}
}
