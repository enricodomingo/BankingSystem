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
    public partial class TransferReport : Form
    {
        public TransferReport()
        {
            InitializeComponent();
        }

        #region Default Instance
        private static TransferReport defaultInstance;


        public static TransferReport Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TransferReport();
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

        private void TransferReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankingDataSet.Transfers' table. You can move, or remove it, as needed.
            this.transfersTableAdapter.Fill(this.bankingDataSet.Transfers);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
