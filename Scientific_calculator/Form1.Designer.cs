namespace Scientific_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtresult = new TextBox();
            btnback = new Button();
            btnclear = new Button();
            btnclr = new Button();
            btnpm = new Button();
            btnadd = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnsub = new Button();
            btnmult = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btndot = new Button();
            btnequal = new Button();
            btndiv = new Button();
            SuspendLayout();
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Segoe UI", 11F);
            txtresult.ForeColor = Color.Blue;
            txtresult.Location = new Point(10, 16);
            txtresult.Margin = new Padding(3, 2, 3, 2);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(373, 44);
            txtresult.TabIndex = 0;
            txtresult.Text = "0";
            txtresult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 11F);
            btnback.ForeColor = Color.Red;
            btnback.Location = new Point(10, 63);
            btnback.Margin = new Padding(3, 2, 3, 2);
            btnback.Name = "btnback";
            btnback.Size = new Size(89, 51);
            btnback.TabIndex = 1;
            btnback.Text = "back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 11F);
            btnclear.ForeColor = Color.Red;
            btnclear.Location = new Point(105, 63);
            btnclear.Margin = new Padding(3, 2, 3, 2);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(89, 51);
            btnclear.TabIndex = 2;
            btnclear.Text = "CE";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnclr
            // 
            btnclr.Font = new Font("Segoe UI", 11F);
            btnclr.ForeColor = Color.Red;
            btnclr.Location = new Point(200, 63);
            btnclr.Margin = new Padding(3, 2, 3, 2);
            btnclr.Name = "btnclr";
            btnclr.Size = new Size(89, 51);
            btnclr.TabIndex = 3;
            btnclr.Text = "C";
            btnclr.UseVisualStyleBackColor = true;
            btnclr.Click += btnclr_Click;
            // 
            // btnpm
            // 
            btnpm.Font = new Font("Segoe UI", 11F);
            btnpm.ForeColor = Color.Red;
            btnpm.Location = new Point(294, 63);
            btnpm.Margin = new Padding(3, 2, 3, 2);
            btnpm.Name = "btnpm";
            btnpm.Size = new Size(89, 51);
            btnpm.TabIndex = 4;
            btnpm.Text = "±";
            btnpm.UseVisualStyleBackColor = true;
            btnpm.Click += btnpm_Click;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 11F);
            btnadd.ForeColor = Color.Red;
            btnadd.Location = new Point(294, 118);
            btnadd.Margin = new Padding(3, 2, 3, 2);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(89, 51);
            btnadd.TabIndex = 8;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += numberOper;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 11F);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(200, 118);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(89, 51);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 11F);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(105, 118);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(89, 51);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 11F);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(10, 118);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(89, 51);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 11F);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(10, 174);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(89, 51);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 11F);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(105, 174);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(89, 51);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 11F);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(200, 174);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(89, 51);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btnsub
            // 
            btnsub.Font = new Font("Segoe UI", 11F);
            btnsub.ForeColor = Color.Red;
            btnsub.Location = new Point(294, 174);
            btnsub.Margin = new Padding(3, 2, 3, 2);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(89, 51);
            btnsub.TabIndex = 9;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = true;
            btnsub.Click += numberOper;
            // 
            // btnmult
            // 
            btnmult.Font = new Font("Segoe UI", 11F);
            btnmult.ForeColor = Color.Red;
            btnmult.Location = new Point(294, 230);
            btnmult.Margin = new Padding(3, 2, 3, 2);
            btnmult.Name = "btnmult";
            btnmult.Size = new Size(89, 58);
            btnmult.TabIndex = 16;
            btnmult.Text = "*";
            btnmult.UseVisualStyleBackColor = true;
            btnmult.Click += numberOper;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 11F);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(200, 230);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(89, 58);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 11F);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(105, 230);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(89, 58);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 11F);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(10, 230);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(89, 58);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 11F);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(10, 292);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(89, 58);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btndot
            // 
            btndot.Font = new Font("Segoe UI", 11F);
            btndot.ForeColor = Color.Blue;
            btndot.Location = new Point(105, 292);
            btndot.Margin = new Padding(3, 2, 3, 2);
            btndot.Name = "btndot";
            btndot.Size = new Size(89, 58);
            btndot.TabIndex = 19;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += EnterNumbers;
            // 
            // btnequal
            // 
            btnequal.Font = new Font("Segoe UI", 11F);
            btnequal.ForeColor = Color.Blue;
            btnequal.Location = new Point(200, 292);
            btnequal.Margin = new Padding(3, 2, 3, 2);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(89, 58);
            btnequal.TabIndex = 18;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // btndiv
            // 
            btndiv.Font = new Font("Segoe UI", 11F);
            btndiv.ForeColor = Color.Red;
            btndiv.Location = new Point(294, 292);
            btndiv.Margin = new Padding(3, 2, 3, 2);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(89, 58);
            btndiv.TabIndex = 17;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += numberOper;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 446);
            Controls.Add(btn0);
            Controls.Add(btndot);
            Controls.Add(btnequal);
            Controls.Add(btndiv);
            Controls.Add(btnmult);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnsub);
            Controls.Add(btnadd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnpm);
            Controls.Add(btnclr);
            Controls.Add(btnclear);
            Controls.Add(btnback);
            Controls.Add(txtresult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresult;
        private Button btnback;
        private Button btnclear;
        private Button btnclr;
        private Button btnpm;
        private Button btnadd;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnsub;
        private Button btnmult;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private Button btndot;
        private Button btnequal;
        private Button btndiv;
    }
}
