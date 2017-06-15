
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
	public partial class Regs_frm
	{
        ATMDataContext atm;
		public Regs_frm()
		{
            atm = new ATMDataContext();
			InitializeComponent();
		}
		
#region Default Instance
		
		private static Regs_frm defaultInstance;
		
		
		public static Regs_frm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Regs_frm();
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

		
		public void btnRegister_Click(System.Object sender, System.EventArgs e)
		{
			if (txtAcctNo.Text == "" && txtPincode.Text == "" && txtAccountName.Text == "")
			{
				MessageBox.Show("Enter All Fields");
				
			}
			else if (txtAcctNo.Text == "" || txtPincode.Text == "" || txtAccountName.Text == "")
			{
				MessageBox.Show("Pls Complete all Fields");
				
			}
			else
			{
                Accounts accountTable = new Accounts();

                var accountNo = from data in atm.Accounts
                                where data.AccountNumber == txtAcctNo.Text
                                select data;

                if (!accountNo.Any())
                {
                    accountTable.AccountNumber = txtAcctNo.Text;
                    accountTable.AccountName = txtAccountName.Text;
                    accountTable.Password = txtPincode.Text;
                    atm.Accounts.InsertOnSubmit(accountTable);
                    atm.SubmitChanges();
                    MessageBox.Show("Record Inserted Successfully!");
                    Login_frm.Default.Show();
                }
                else MessageBox.Show("Record already exist!");
			}
		}
		
		public void Regs_frm_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			Login_frm.Default.Show();
		}
	}
}
