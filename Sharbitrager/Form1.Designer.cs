﻿namespace Sharbitrager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.url,
            this.profit,
            this.outcome1,
            this.outcome2,
            this.outcome3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // url
            // 
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.Name = "profit";
            // 
            // outcome1
            // 
            this.outcome1.HeaderText = "Outcome 1";
            this.outcome1.Name = "outcome1";
            // 
            // outcome2
            // 
            this.outcome2.HeaderText = "Outcome 2";
            this.outcome2.Name = "outcome2";
            // 
            // outcome3
            // 
            this.outcome3.HeaderText = "Outcome 3";
            this.outcome3.Name = "outcome3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome3;
    }
}

