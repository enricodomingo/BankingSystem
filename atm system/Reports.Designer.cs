// VBConversions Note: VB project level imports
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
// End of VB project level imports


namespace atmsystem
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Reports : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.btnwith = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.btndep);
            this.GroupBox1.Controls.Add(this.btnwith);
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(13, 47);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(536, 108);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Transaction";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Maroon;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(351, 23);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(177, 71);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "Transfer";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btndep
            // 
            this.btndep.BackColor = System.Drawing.Color.Maroon;
            this.btndep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.Location = new System.Drawing.Point(171, 23);
            this.btndep.Margin = new System.Windows.Forms.Padding(4);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(172, 71);
            this.btndep.TabIndex = 2;
            this.btndep.Text = "Deposit";
            this.btndep.UseVisualStyleBackColor = false;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnwith
            // 
            this.btnwith.BackColor = System.Drawing.Color.Maroon;
            this.btnwith.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwith.Location = new System.Drawing.Point(8, 23);
            this.btnwith.Margin = new System.Windows.Forms.Padding(4);
            this.btnwith.Name = "btnwith";
            this.btnwith.Size = new System.Drawing.Size(155, 71);
            this.btnwith.TabIndex = 1;
            this.btnwith.Text = "Withdraw";
            this.btnwith.UseVisualStyleBackColor = false;
            this.btnwith.Click += new System.EventHandler(this.btnwith_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(360, 11);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 18);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(563, 167);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btndep;
        internal System.Windows.Forms.Button btnwith;
        internal System.Windows.Forms.Label lbldate;
        internal System.Windows.Forms.Button Button2;
	}
	
}
