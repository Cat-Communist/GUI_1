namespace Bank_Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtInitialDeposit = new TextBox();
            txtExpectedIncrease = new TextBox();
            txtExpectedDeposit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CalcMonthByIncr = new Button();
            CalcMonthByDeposit = new Button();
            SuspendLayout();
            // 
            // txtInitialDeposit
            // 
            txtInitialDeposit.Location = new Point(237, 13);
            txtInitialDeposit.Name = "txtInitialDeposit";
            txtInitialDeposit.Size = new Size(125, 27);
            txtInitialDeposit.TabIndex = 0;
            // 
            // txtExpectedIncrease
            // 
            txtExpectedIncrease.Location = new Point(237, 46);
            txtExpectedIncrease.Name = "txtExpectedIncrease";
            txtExpectedIncrease.Size = new Size(125, 27);
            txtExpectedIncrease.TabIndex = 1;
            // 
            // txtExpectedDeposit
            // 
            txtExpectedDeposit.Location = new Point(237, 79);
            txtExpectedDeposit.Name = "txtExpectedDeposit";
            txtExpectedDeposit.Size = new Size(125, 27);
            txtExpectedDeposit.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 3;
            label1.Text = "Сумма вклада";
            // 
            // label2
            // 
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 4;
            label2.Text = "Ожидаемый размер вклада";
            // 
            // label3
            // 
            label3.Location = new Point(22, 49);
            label3.Name = "label3";
            label3.Size = new Size(208, 20);
            label3.TabIndex = 5;
            label3.Text = "Ожидаемое увеличение";
            // 
            // label4
            // 
            label4.Location = new Point(22, 119);
            label4.Name = "label4";
            label4.Size = new Size(565, 107);
            label4.TabIndex = 6;
            label4.Text = resources.GetString("label4.Text");
            // 
            // CalcMonthByIncr
            // 
            CalcMonthByIncr.Location = new Point(368, 45);
            CalcMonthByIncr.Name = "CalcMonthByIncr";
            CalcMonthByIncr.Size = new Size(219, 29);
            CalcMonthByIncr.TabIndex = 7;
            CalcMonthByIncr.Text = "Рассчитать месяц";
            CalcMonthByIncr.UseVisualStyleBackColor = true;
            CalcMonthByIncr.Click += CalcMonthByIncr_Click;
            // 
            // CalcMonthByDeposit
            // 
            CalcMonthByDeposit.Location = new Point(368, 77);
            CalcMonthByDeposit.Name = "CalcMonthByDeposit";
            CalcMonthByDeposit.Size = new Size(219, 29);
            CalcMonthByDeposit.TabIndex = 8;
            CalcMonthByDeposit.Text = "Рассчитать кол-во месяцев";
            CalcMonthByDeposit.UseVisualStyleBackColor = true;
            CalcMonthByDeposit.Click += CalcMonthByDeposit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 232);
            Controls.Add(CalcMonthByDeposit);
            Controls.Add(CalcMonthByIncr);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExpectedDeposit);
            Controls.Add(txtExpectedIncrease);
            Controls.Add(txtInitialDeposit);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInitialDeposit;
        private TextBox txtExpectedIncrease;
        private TextBox txtExpectedDeposit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CalcMonthByIncr;
        private Button CalcMonthByDeposit;
    }
}
