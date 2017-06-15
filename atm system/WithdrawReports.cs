using System;
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
            atm = new ATMDataContext();
            Withdraws withdraw = new Withdraws();
            int i = 1;
            var results = from data in atm.Withdraws
                          select data;
            ListViewItem[] lItem = results.Select(X => new ListViewItem()).ToArray(); ;

            listView1.BeginUpdate();
            foreach (var row in results)
            {
                var lstItem = listView1.Items.Add(row.AccountNumber);
                
            }
            listView1.EndUpdate();
        }

    }
}
