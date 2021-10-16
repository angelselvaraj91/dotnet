namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtperiod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinterest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrincipalAmt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(279, 149);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(260, 26);
            this.txtrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate(p a)";
            // 
            // txtperiod
            // 
            this.txtperiod.Location = new System.Drawing.Point(280, 201);
            this.txtperiod.Name = "txtperiod";
            this.txtperiod.Size = new System.Drawing.Size(260, 26);
            this.txtperiod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period(Months)";
            // 
            // txtinterest
            // 
            this.txtinterest.Location = new System.Drawing.Point(280, 284);
            this.txtinterest.Name = "txtinterest";
            this.txtinterest.Size = new System.Drawing.Size(260, 26);
            this.txtinterest.TabIndex = 7;
           // this.txtinterest.TextChanged += new System.EventHandler(this.txtinterest_changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interest";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(280, 333);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(260, 26);
            this.txtAmount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Interest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateInterestButton_Click);
            // 
            // txtPrincipalAmt
            // 
            this.txtPrincipalAmt.Location = new System.Drawing.Point(279, 86);
            this.txtPrincipalAmt.Name = "txtPrincipalAmt";
            this.txtPrincipalAmt.Size = new System.Drawing.Size(260, 26);
            this.txtPrincipalAmt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrincipalAmt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtinterest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtperiod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtperiod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinterest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrincipalAmt;
    }
}

