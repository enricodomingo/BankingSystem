namespace atmsystem
{
    partial class TransferReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bankingDataSet = new atmsystem.BankingDataSet();
            this.transfersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transfersTableAdapter = new atmsystem.BankingDataSetTableAdapters.TransfersTableAdapter();
            this.transferFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(162, 159);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transferFromDataGridViewTextBoxColumn,
            this.transferToDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transfersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // bankingDataSet
            // 
            this.bankingDataSet.DataSetName = "BankingDataSet";
            this.bankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transfersBindingSource
            // 
            this.transfersBindingSource.DataMember = "Transfers";
            this.transfersBindingSource.DataSource = this.bankingDataSet;
            // 
            // transfersTableAdapter
            // 
            this.transfersTableAdapter.ClearBeforeFill = true;
            // 
            // transferFromDataGridViewTextBoxColumn
            // 
            this.transferFromDataGridViewTextBoxColumn.DataPropertyName = "TransferFrom";
            this.transferFromDataGridViewTextBoxColumn.HeaderText = "TransferFrom";
            this.transferFromDataGridViewTextBoxColumn.Name = "transferFromDataGridViewTextBoxColumn";
            this.transferFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transferToDataGridViewTextBoxColumn
            // 
            this.transferToDataGridViewTextBoxColumn.DataPropertyName = "TransferTo";
            this.transferToDataGridViewTextBoxColumn.HeaderText = "TransferTo";
            this.transferToDataGridViewTextBoxColumn.Name = "transferToDataGridViewTextBoxColumn";
            this.transferToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransferReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 206);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Name = "TransferReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferReport";
            this.Load += new System.EventHandler(this.TransferReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankingDataSet bankingDataSet;
        private System.Windows.Forms.BindingSource transfersBindingSource;
        private BankingDataSetTableAdapters.TransfersTableAdapter transfersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
    }
}