
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
	public partial class Withdraw

	{
        ATMDataContext atm;
        public Withdraw()
		{
			InitializeComponent();
            atm = new ATMDataContext();
		}
		
#region Default Instance
		
		private static Withdraw defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Withdraw Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Withdraw();
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
		
		public void Withdraw_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
			lblaccno.Text = Mainmenu.Default.lblaccno.Text;
		}
		
		public void btnok_Click(System.Object sender, System.EventArgs e)
		{
            Withdraws withdraw = new Withdraws();
            Accounts accountTable = atm.Accounts.Single(e1 => e1.AccountNumber == lblaccno.Text);

            try
            {
                balance = accountTable.Balance;
                amount = decimal.Parse(txtamount.Text);

                if (amount > 25000)
                {
                    MessageBox.Show("You can Only Withdraw Php 25,000!");
                }
                else if (amount <= 0)
                {
                    MessageBox.Show("You can't make transaction with 0 or lest than 0 amount.");
                }
                else if (balance < amount)
                {
                    MessageBox.Show("Not enough Balance to make withdrawal transactions!");
                }
                else
                {
                    accountTable.Balance = balance - amount;
                    withdraw.AccountNumber = lblaccno.Text;
                    withdraw.Amount = amount;
                    withdraw.DateCreated = DateTime.Now;
                    atm.Withdraws.InsertOnSubmit(withdraw);
                    atm.SubmitChanges();

                    MessageBox.Show("Withdrawal Successful!");
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
	}
}
