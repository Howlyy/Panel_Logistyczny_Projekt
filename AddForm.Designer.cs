
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
            this.SuspendLayout();
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(134, 169);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(93, 42);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Dodaj";
            this.AddBTN.UseVisualStyleBackColor = true;
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(133, 56);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(170, 23);
            this.NumberTB.TabIndex = 1;
            // 
            // DepLB
            // 
            this.DepLB.FormattingEnabled = true;
            this.DepLB.ItemHeight = 15;
            this.DepLB.Location = new System.Drawing.Point(134, 122);
            this.DepLB.Name = "DepLB";
            this.DepLB.Size = new System.Drawing.Size(170, 19);
            this.DepLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepLB);
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
        private System.Windows.Forms.ListBox DepLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}