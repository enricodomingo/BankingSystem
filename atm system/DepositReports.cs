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
    public partial class DepositReports : Form
    {
        public DepositReports()
        {
            InitializeComponent();
        }

        #region Default Instance
        private static DepositReports defaultInstance;


        public static DepositReports Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new DepositReports();
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

        private void DepositReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet.Deposits' table. You can move, or remove it, as needed.
            this.depositsTableAdapter.Fill(this.bankingDataSet.Deposits);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
