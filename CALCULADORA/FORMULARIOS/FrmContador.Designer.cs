namespace CalculadorA.FORMULARIOS
{
    partial class FrmContador
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
            components = new System.ComponentModel.Container();
            lblCuenta = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            tbVelocidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(216, 9);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(136, 159);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            lblCuenta.Click += lblCuenta_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(97, 286);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(399, 286);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "DETENER";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tbVelocidad
            // 
            tbVelocidad.Enabled = false;
            tbVelocidad.Location = new Point(66, 186);
            tbVelocidad.Maximum = 5;
            tbVelocidad.Minimum = 1;
            tbVelocidad.Name = "tbVelocidad";
            tbVelocidad.Size = new Size(427, 56);
            tbVelocidad.TabIndex = 3;
            tbVelocidad.Value = 1;
            tbVelocidad.Scroll += trackBar1_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // FrmContador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 345);
            Controls.Add(tbVelocidad);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblCuenta);
            Name = "FrmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar tbVelocidad;
        private System.Windows.Forms.Timer tmrContador;
    }
}