
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
	public partial class Login_frm
	{
        ATMDataContext atm;
		public Login_frm()
		{
			InitializeComponent();
            
		}
		
#region Default Instance
		
		private static Login_frm defaultInstance;
		

		public static Login_frm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Login_frm();
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


		public void btnlogin_Click(System.Object sender, System.EventArgs e)
		{
            atm = new ATMDataContext();
            Accounts accountTable = new Accounts();
            var accountResult = from data in atm.Accounts
                        where data.AccountNumber == txtAccountNo.Text &&
                        data.Password == txtpin.Text
                        select data;
            try
            {
                if (accountResult.Any())
                {
                    foreach (var acct in accountResult)
                    {
                        MessageBox.Show("Welcome " + acct.AccountName.ToString());
                        Mainmenu.Default.lblname.Text = acct.AccountName.ToString();
                        Mainmenu.Default.lblaccno.Text = acct.AccountNumber;
                    }
                    Mainmenu.Default.Show();
                    txtAccountNo.Clear();
                    txtpin.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Account Number/Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
		
		public void llblreg_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Regs_frm.Default.Show();
		}

	}
	
}
