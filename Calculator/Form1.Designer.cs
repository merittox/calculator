using System.Runtime.CompilerServices;

namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            screen = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btndot = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            merittox = new Label();
            SuspendLayout();
            // 
            // screen
            // 
            screen.BackColor = Color.FromArgb(180, 190, 200);
            screen.BorderStyle = BorderStyle.FixedSingle;
            screen.Cursor = Cursors.Help;
            screen.Enabled = false;
            screen.Font = new Font("Exo", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            screen.ForeColor = Color.Black;
            screen.HideSelection = false;
            screen.Location = new Point(12, 12);
            screen.Name = "screen";
            screen.ReadOnly = true;
            screen.Size = new Size(424, 77);
            screen.TabIndex = 0;
            screen.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(129, 165, 181);
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Exo", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(12, 123);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 60);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(129, 165, 181);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Exo", 15.75F);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(98, 123);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 60);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(129, 165, 181);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Exo", 15.75F);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(184, 123);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 60);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(129, 165, 181);
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Exo", 15.75F);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(12, 189);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 60);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(129, 165, 181);
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Exo", 15.75F);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(98, 189);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 60);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(129, 165, 181);
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Exo", 15.75F);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(184, 189);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(129, 165, 181);
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Exo", 15.75F);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(12, 255);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 60);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(129, 165, 181);
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Exo", 15.75F);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(98, 255);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(129, 165, 181);
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Exo", 15.75F);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(184, 255);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 60);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(129, 165, 181);
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Exo", 15.75F);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(12, 321);
            btn0.Name = "btn0";
            btn0.Size = new Size(166, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btndot
            // 
            btndot.BackColor = Color.FromArgb(129, 165, 181);
            btndot.Cursor = Cursors.Hand;
            btndot.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btndot.FlatStyle = FlatStyle.Flat;
            btndot.Font = new Font("Exo", 15.75F);
            btndot.ForeColor = Color.Black;
            btndot.Location = new Point(184, 321);
            btndot.Name = "btndot";
            btndot.Size = new Size(80, 60);
            btndot.TabIndex = 11;
            btndot.Text = ",";
            btndot.UseVisualStyleBackColor = false;
            btndot.Click += btnDot_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(160, 200, 220);
            btnMultiply.Cursor = Cursors.Hand;
            btnMultiply.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Exo", 15.75F);
            btnMultiply.ForeColor = Color.Black;
            btnMultiply.Location = new Point(270, 123);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 60);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(160, 200, 220);
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Exo", 15.75F);
            btnDivide.ForeColor = Color.Black;
            btnDivide.Location = new Point(270, 189);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(80, 60);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(160, 200, 220);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Exo", 15.75F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(270, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 60);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(160, 200, 220);
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Exo", 15.75F);
            btnSubtract.ForeColor = Color.Black;
            btnSubtract.Location = new Point(270, 321);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(80, 60);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(200, 220, 240);
            btnEquals.Cursor = Cursors.Hand;
            btnEquals.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Exo", 15.75F);
            btnEquals.ForeColor = Color.Black;
            btnEquals.Location = new Point(356, 255);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(80, 126);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(160, 200, 220);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 103, 109);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Exo", 15.75F);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(356, 123);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 126);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // merittox
            // 
            merittox.AutoSize = true;
            merittox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            merittox.ForeColor = SystemColors.AppWorkspace;
            merittox.Location = new Point(12, 105);
            merittox.Name = "merittox";
            merittox.Size = new Size(186, 15);
            merittox.TabIndex = 18;
            merittox.Text = "created by MERITTOX - 13.09.24";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 222, 247);
            ClientSize = new Size(448, 393);
            Controls.Add(merittox);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(screen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox screen;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btndot;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnEquals;
        private Button btnClear;
        private Label merittox;
    }
}
