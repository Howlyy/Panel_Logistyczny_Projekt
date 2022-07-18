
namespace Panel_logistyczny
{
    partial class AddForm
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
            this.AddBTN = new System.Windows.Forms.Button();
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.DepLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeliLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(191, 313);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(133, 70);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Dodaj";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(190, 93);
            this.NumberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(241, 31);
            this.NumberTB.TabIndex = 1;
            // 
            // DepLB
            // 
            this.DepLB.FormattingEnabled = true;
            this.DepLB.ItemHeight = 25;
            this.DepLB.Location = new System.Drawing.Point(191, 166);
            this.DepLB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepLB.Name = "DepLB";
            this.DepLB.Size = new System.Drawing.Size(241, 29);
            this.DepLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delivery Type";
            // 
            // DeliLB
            // 
            this.DeliLB.FormattingEnabled = true;
            this.DeliLB.ItemHeight = 25;
            this.DeliLB.Location = new System.Drawing.Point(191, 231);
            this.DeliLB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliLB.Name = "DeliLB";
            this.DeliLB.Size = new System.Drawing.Size(241, 29);
            this.DeliLB.TabIndex = 3;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliLB);
            this.Controls.Add(this.DepLB);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.AddBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.ListBox DepLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DeliLB;
    }
}