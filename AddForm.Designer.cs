
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DepLB = new System.Windows.Forms.ComboBox();
            this.DeliLB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(134, 188);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(93, 42);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Dodaj";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(133, 56);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(170, 23);
            this.NumberTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delivery Type";
            // 
            // DepLB
            // 
            this.DepLB.FormattingEnabled = true;
            this.DepLB.Location = new System.Drawing.Point(133, 97);
            this.DepLB.Name = "DepLB";
            this.DepLB.Size = new System.Drawing.Size(169, 23);
            this.DepLB.TabIndex = 6;
            this.DepLB.SelectedIndexChanged += new System.EventHandler(this.DepLB_SelectedIndexChanged);
            // 
            // DeliLB
            // 
            this.DeliLB.FormattingEnabled = true;
            this.DeliLB.Location = new System.Drawing.Point(133, 136);
            this.DeliLB.Name = "DeliLB";
            this.DeliLB.Size = new System.Drawing.Size(169, 23);
            this.DeliLB.TabIndex = 6;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 253);
            this.Controls.Add(this.DeliLB);
            this.Controls.Add(this.DepLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.AddBTN);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepLB;
        private System.Windows.Forms.ComboBox DeliLB;
    }
}