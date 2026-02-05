namespace CalculadorA
{
    partial class Calculadora
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
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            Operaciones = new GroupBox();
            rdbDIVISION = new RadioButton();
            rdbMULTIPLICACION = new RadioButton();
            rdbRESTA = new RadioButton();
            rdbSUMA = new RadioButton();
            butCALCULAR = new Button();
            label1 = new Label();
            label2 = new Label();
            btnReset = new Button();
            Operaciones.SuspendLayout();
            SuspendLayout();
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(158, 73);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(125, 27);
            txtVariableA.TabIndex = 0;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(158, 130);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(125, 27);
            txtVariableB.TabIndex = 1;
            // 
            // Operaciones
            // 
            Operaciones.Controls.Add(rdbDIVISION);
            Operaciones.Controls.Add(rdbMULTIPLICACION);
            Operaciones.Controls.Add(rdbRESTA);
            Operaciones.Controls.Add(rdbSUMA);
            Operaciones.Location = new Point(301, 73);
            Operaciones.Name = "Operaciones";
            Operaciones.Size = new Size(218, 182);
            Operaciones.TabIndex = 2;
            Operaciones.TabStop = false;
            Operaciones.Text = "Operaciones";
            Operaciones.Enter += groupBox1_Enter;
            // 
            // rdbDIVISION
            // 
            rdbDIVISION.AutoSize = true;
            rdbDIVISION.Location = new Point(66, 130);
            rdbDIVISION.Name = "rdbDIVISION";
            rdbDIVISION.Size = new Size(83, 24);
            rdbDIVISION.TabIndex = 3;
            rdbDIVISION.TabStop = true;
            rdbDIVISION.Text = "Division";
            rdbDIVISION.UseVisualStyleBackColor = true;
            // 
            // rdbMULTIPLICACION
            // 
            rdbMULTIPLICACION.AutoSize = true;
            rdbMULTIPLICACION.Location = new Point(66, 100);
            rdbMULTIPLICACION.Name = "rdbMULTIPLICACION";
            rdbMULTIPLICACION.Size = new Size(124, 24);
            rdbMULTIPLICACION.TabIndex = 2;
            rdbMULTIPLICACION.TabStop = true;
            rdbMULTIPLICACION.Text = "Multiplicacion";
            rdbMULTIPLICACION.UseVisualStyleBackColor = true;
            // 
            // rdbRESTA
            // 
            rdbRESTA.AutoSize = true;
            rdbRESTA.Location = new Point(68, 70);
            rdbRESTA.Name = "rdbRESTA";
            rdbRESTA.Size = new Size(66, 24);
            rdbRESTA.TabIndex = 1;
            rdbRESTA.TabStop = true;
            rdbRESTA.Text = "Resta";
            rdbRESTA.UseVisualStyleBackColor = true;
            // 
            // rdbSUMA
            // 
            rdbSUMA.AutoSize = true;
            rdbSUMA.Location = new Point(68, 40);
            rdbSUMA.Name = "rdbSUMA";
            rdbSUMA.Size = new Size(67, 24);
            rdbSUMA.TabIndex = 0;
            rdbSUMA.TabStop = true;
            rdbSUMA.Text = "Suma";
            rdbSUMA.UseVisualStyleBackColor = true;
            // 
            // butCALCULAR
            // 
            butCALCULAR.Location = new Point(44, 198);
            butCALCULAR.Name = "butCALCULAR";
            butCALCULAR.Size = new Size(94, 29);
            butCALCULAR.TabIndex = 3;
            butCALCULAR.Text = "calcular";
            butCALCULAR.UseVisualStyleBackColor = true;
            butCALCULAR.Click += butCALCULAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 73);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Variable A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 137);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Variable B";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(43, 250);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butCALCULAR);
            Controls.Add(Operaciones);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Name = "Form1";
            Text = "Calculadora";
            Operaciones.ResumeLayout(false);
            Operaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private GroupBox Operaciones;
        private RadioButton rdbDIVISION;
        private RadioButton rdbMULTIPLICACION;
        private RadioButton rdbRESTA;
        private RadioButton rdbSUMA;
        private Button butCALCULAR;
        private Label label1;
        private Label label2;
        private Button btnReset;
    }
}
