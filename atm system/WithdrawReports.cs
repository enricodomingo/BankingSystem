﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atmsystem
{
    public partial class WithdrawReports : Form
    {
        ATMDataContext atm;
        public WithdrawReports()
        {
            InitializeComponent();
        }

        #region Default Instance
        private static WithdrawReports defaultInstance;


        public static WithdrawReports Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new WithdrawReports();
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

        private void WithdrawReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet.Withdraws' table. You can move, or remove it, as needed.
            this.withdrawsTableAdapter.Fill(this.bankingDataSet.Withdraws);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
