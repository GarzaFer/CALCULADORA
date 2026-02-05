namespace CalculadorA
{
    partial class FrmBurbuja
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
            dgbDesordenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgbOrdenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgbOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgbDesordenado
            // 
            dgbDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbDesordenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgbDesordenado.Location = new Point(12, 12);
            dgbDesordenado.Name = "dgbDesordenado";
            dgbDesordenado.RowHeadersWidth = 51;
            dgbDesordenado.Size = new Size(185, 396);
            dgbDesordenado.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dgbOrdenado
            // 
            dgbOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbOrdenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgbOrdenado.Location = new Point(303, 12);
            dgbOrdenado.Name = "dgbOrdenado";
            dgbOrdenado.RowHeadersWidth = 51;
            dgbOrdenado.Size = new Size(192, 396);
            dgbOrdenado.TabIndex = 1;
            dgbOrdenado.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(203, 159);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 29);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "ORDENAR";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // FrmBurbuja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(dgbOrdenado);
            Controls.Add(dgbDesordenado);
            Name = "FrmBurbuja";
            Text = "OrdenamientoBurbuja";
            ((System.ComponentModel.ISupportInitialize)dgbDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgbOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgbDesordenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgbOrdenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnOrdenar;
    }
}