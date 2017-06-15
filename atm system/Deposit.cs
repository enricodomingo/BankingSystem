
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
	public partial class Deposit
	{
        ATMDataContext atm;
		public Deposit()
		{
            atm = new ATMDataContext();
			InitializeComponent();
		}
		
#region Default Instance
		
		private static Deposit defaultInstance;
		
		
		public static Deposit Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Deposit();
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
	
		decimal balance;
		decimal amount;
		int total;
		
		public void Deposit_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
			lblaccno.Text = Mainmenu.Default.lblaccno.Text;
		}
		
		public void btnok_Click(System.Object sender, System.EventArgs e)
		{
            
            Deposits deposits = new Deposits();
            Accounts accountTable = atm.Accounts.Single(e1 => e1.AccountNumber == lblaccno.Text);

			try
			{
                balance = accountTable.Balance;
                amount = decimal.Parse(txtamount.Text);

                if (amount > 25000)
                {
                    MessageBox.Show("You can Only Deposit Php 25,000!");
                }
                else if (amount <= 0)
                {
                    MessageBox.Show("You can't make transaction with 0 or lest than 0 amount.");
                }
                else
                {
                    accountTable.Balance = balance + amount;
                    deposits.AccountNumber = lblaccno.Text;
                    deposits.Amount = amount;
                    deposits.DateCreated = DateTime.Now;
                    atm.Deposits.InsertOnSubmit(deposits);
                    atm.SubmitChanges();

                    MessageBox.Show("Deposit Successful!");
                    Login_frm.Default.Show();
                    atm = null;
                    this.Close();
                }	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			txtamount.Text = "";
		}
		
		public void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Mainmenu.Default.Show();
			this.Close();
		}
		
		public void txtamount_TextChanged(System.Object sender, System.EventArgs e)
		{
			
		}
		
		public void lbldate_Click(System.Object sender, System.EventArgs e)
		{
			
		}
	}
	
}
