
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
	public partial class Transfer
	{
        ATMDataContext atm;
        public Transfer()
		{
			InitializeComponent();
            atm = new ATMDataContext();
		}
		
#region Default Instance
		
		private static Transfer defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Transfer Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Transfer();
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
	
		decimal balance, balance2;
		decimal amount;
		
		public void Withdraw_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
			lblaccno.Text = Mainmenu.Default.lblaccno.Text;
		}
		
		public void btnok_Click(System.Object sender, System.EventArgs e)
		{
            Transfers transfer = new Transfers();
            Accounts accountTable = atm.Accounts.Single(e1 => e1.AccountNumber == lblaccno.Text);

            Accounts accountTable2 = atm.Accounts.Single(e2 => e2.AccountNumber == txtaccount2.Text);

            try
            {

                balance = accountTable.Balance;
                balance2 = accountTable2.Balance;
                amount = decimal.Parse(txtamount.Text);

                if (accountTable2.AccountNumber == null)
                {
                    MessageBox.Show("Account number to transfer does not exist!");
                }
                else if (amount > 25000)
                {
                    MessageBox.Show("You can Only Withdraw Php 25,000!");
                }
                else if (amount <= 0)
                {
                    MessageBox.Show("You can't make transaction with 0 or lest than 0 amount.");
                }
                else if (balance < amount)
                {
                    MessageBox.Show("Not enough Balance to make transfer transactions!");
                }
                else
                {
                    accountTable.Balance = balance - amount;
                    accountTable2.Balance = balance2 + amount;
                    transfer.TransferFrom = lblaccno.Text;
                    transfer.TransferTo = txtaccount2.Text;
                    transfer.Amount = amount;
                    transfer.DateCreated = DateTime.Now;
                    atm.Transfers.InsertOnSubmit(transfer);
                    atm.SubmitChanges();

                    MessageBox.Show("Transfer Successful!");
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
