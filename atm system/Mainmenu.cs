
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
	public partial class Mainmenu
	{
        ATMDataContext atm;
		public Mainmenu()
		{
			InitializeComponent();

		}
		
#region Default Instance
		
		private static Mainmenu defaultInstance;
		
	
		public static Mainmenu Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Mainmenu();
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

		public void Label4_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void Button4_Click(System.Object sender, System.EventArgs e)
		{
			Login_frm.Default.Show();
			this.Close();
		}
		
		public void Mainmenu_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
            
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
            atm = new ATMDataContext();
            Accounts accountTable = new Accounts();
            decimal balance;
            var accountResult = from data in atm.Accounts
                                where data.AccountNumber == lblaccno.Text
                                select data;

            if(accountResult.Any()) {
                foreach (var acct in accountResult)
                {
                    balance = acct.Balance;
                    Receipt.Default.Show();
                    Receipt.Default.lblname.Text = lblname.Text;
                    Receipt.Default.lblbal.Text = balance.ToString();
                    Receipt.Default.Label4.Hide();
                    Receipt.Default.Label3.Hide();
                    Receipt.Default.lbldep.Hide();
                    Receipt.Default.lblwith.Hide();
                    Receipt.Default.Label6.Hide();
                    Receipt.Default.lblnewbal.Hide();
                    this.Hide();
                }
            }
		}
		
		public void btnwith_Click(System.Object sender, System.EventArgs e)
		{
			Withdraw.Default.Show();
			this.Hide();
			
		}
		
		public void btndep_Click(System.Object sender, System.EventArgs e)
		{
			Deposit.Default.Show();
			this.Hide();
		}
		
		public void lblname_Click(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void GroupBox1_Enter(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void Button2_Click(System.Object sender, System.EventArgs e)
		{
            Transfer.Default.Show();
            this.Hide();
		}
	}
}
