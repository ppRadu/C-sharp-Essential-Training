namespace SchoolFormsApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(164, 70);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(164, 98);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(164, 126);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 22);
            this.txtState.TabIndex = 9;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(164, 154);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 22);
            this.txtZip.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(164, 182);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 11;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(164, 210);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(100, 22);
            this.txtTwitter.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Twitter";
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(109, 250);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(155, 28);
            this.btnPushToTest.TabIndex = 14;
            this.btnPushToTest.Text = "Push To Test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.btnPushToTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 349);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPushToTest;
    }
}

