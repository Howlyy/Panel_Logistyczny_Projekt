
namespace Panel_logistyczny
{
    partial class MainForm
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
            this.AddBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextStateBTN = new System.Windows.Forms.Button();
            this.BackStateBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 474);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(21, 36);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(105, 39);
            this.AddBTN.TabIndex = 1;
            this.AddBTN.Text = "Dodaj";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(132, 36);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(105, 39);
            this.DeleteBTN.TabIndex = 1;
            this.DeleteBTN.Text = "Usun";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NextStateBTN);
            this.groupBox1.Controls.Add(this.DeleteBTN);
            this.groupBox1.Controls.Add(this.BackStateBTN);
            this.groupBox1.Controls.Add(this.AddBTN);
            this.groupBox1.Location = new System.Drawing.Point(795, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje ";
            // 
            // NextStateBTN
            // 
            this.NextStateBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.NextStateBTN.Location = new System.Drawing.Point(132, 81);
            this.NextStateBTN.Name = "NextStateBTN";
            this.NextStateBTN.Size = new System.Drawing.Size(105, 41);
            this.NextStateBTN.TabIndex = 0;
            this.NextStateBTN.Text = "Następny status";
            this.NextStateBTN.UseVisualStyleBackColor = true;
            this.NextStateBTN.Click += new System.EventHandler(this.NextStateBTN_Click);
            // 
            // BackStateBTN
            // 
            this.BackStateBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackStateBTN.Location = new System.Drawing.Point(21, 81);
            this.BackStateBTN.Name = "BackStateBTN";
            this.BackStateBTN.Size = new System.Drawing.Size(105, 41);
            this.BackStateBTN.TabIndex = 0;
            this.BackStateBTN.Text = "Cofnij status";
            this.BackStateBTN.UseVisualStyleBackColor = true;
            this.BackStateBTN.Click += new System.EventHandler(this.BackStateBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Odśwież dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button DeleteBTN;
        public System.Windows.Forms.Button NextStateBTN;
        public System.Windows.Forms.Button BackStateBTN;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}