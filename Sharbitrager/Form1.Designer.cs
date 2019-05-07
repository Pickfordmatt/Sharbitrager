namespace Sharbitrager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outcome3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(776, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // url
            // 
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            this.url.Width = 374;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sharbitrager.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sharbitrager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn outcome3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

