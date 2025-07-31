namespace WinFormsApp_Calculatrice_Teste
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
            btnInitialiser = new Button();
            btnMoins = new Button();
            btnMult = new Button();
            btnPlus = new Button();
            btnDiv = new Button();
            label1 = new Label();
            txtNb1 = new TextBox();
            txtNb2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtResult = new TextBox();
            btnPower = new Button();
            btnSqrt = new Button();
            label4 = new Label();
            btnEvaluer = new Button();
            txtExpression = new TextBox();
            SuspendLayout();
            // 
            // btnInitialiser
            // 
            btnInitialiser.Location = new Point(413, 126);
            btnInitialiser.Name = "btnInitialiser";
            btnInitialiser.Size = new Size(102, 40);
            btnInitialiser.TabIndex = 0;
            btnInitialiser.Text = "Initialliser";
            btnInitialiser.UseVisualStyleBackColor = true;
            btnInitialiser.Click += btnInitialiser_Click;
            // 
            // btnMoins
            // 
            btnMoins.Location = new Point(61, 247);
            btnMoins.Name = "btnMoins";
            btnMoins.Size = new Size(102, 40);
            btnMoins.TabIndex = 1;
            btnMoins.Text = "-";
            btnMoins.UseVisualStyleBackColor = true;
            btnMoins.Click += btnMoins_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(370, 333);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(102, 40);
            btnMult.TabIndex = 2;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(370, 247);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(102, 40);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(215, 247);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(102, 40);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // label1
            // 
            label1.Location = new Point(61, 443);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 5;
            label1.Text = "Resultat";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNb1
            // 
            txtNb1.Location = new Point(226, 94);
            txtNb1.Name = "txtNb1";
            txtNb1.Size = new Size(125, 27);
            txtNb1.TabIndex = 6;
            // 
            // txtNb2
            // 
            txtNb2.Location = new Point(226, 154);
            txtNb2.Name = "txtNb2";
            txtNb2.Size = new Size(125, 27);
            txtNb2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(54, 93);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 8;
            label2.Text = "Nombre 1";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(54, 157);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 9;
            label3.Text = "Nombre 2";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(226, 440);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(125, 27);
            txtResult.TabIndex = 10;
            // 
            // btnPower
            // 
            btnPower.Location = new Point(215, 333);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(102, 40);
            btnPower.TabIndex = 11;
            btnPower.Text = "^";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(61, 333);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(102, 40);
            btnSqrt.TabIndex = 12;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(129, 9);
            label4.Name = "label4";
            label4.Size = new Size(300, 55);
            label4.TabIndex = 13;
            label4.Text = "CALCULATRICE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEvaluer
            // 
            btnEvaluer.Location = new Point(61, 188);
            btnEvaluer.Name = "btnEvaluer";
            btnEvaluer.Size = new Size(102, 40);
            btnEvaluer.TabIndex = 14;
            btnEvaluer.Text = "Eval";
            btnEvaluer.UseVisualStyleBackColor = true;
            btnEvaluer.Click += btnEvaluer_Click;
            // 
            // txtExpression
            // 
            txtExpression.Location = new Point(226, 201);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(125, 27);
            txtExpression.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 523);
            Controls.Add(txtExpression);
            Controls.Add(btnEvaluer);
            Controls.Add(label4);
            Controls.Add(btnSqrt);
            Controls.Add(btnPower);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNb2);
            Controls.Add(txtNb1);
            Controls.Add(label1);
            Controls.Add(btnDiv);
            Controls.Add(btnPlus);
            Controls.Add(btnMult);
            Controls.Add(btnMoins);
            Controls.Add(btnInitialiser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInitialiser;
        private Button btnMoins;
        private Button btnMult;
        private Button btnPlus;
        private Button btnDiv;
        private Label label1;
        private TextBox txtNb1;
        private TextBox txtNb2;
        private Label label2;
        private Label label3;
        private TextBox txtResult;
        private Button btnPower;
        private Button btnSqrt;
        private Label label4;
        private Button btnEvaluer;
        private TextBox txtExpression;
    }
}
