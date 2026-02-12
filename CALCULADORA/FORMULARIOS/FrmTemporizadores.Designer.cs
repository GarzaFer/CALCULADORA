namespace CalculadorA.FORMULARIOS
{
    partial class FrmTemporizadores
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
            lblHora = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            menuAlarma = new MenuStrip();
            MNSalarma = new ToolStripMenuItem();
            alarma1ToolStripMenuItem = new ToolStripMenuItem();
            menuAlarma.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(158, 72);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(298, 69);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00 x.x";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Interval = 1000;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // menuAlarma
            // 
            menuAlarma.ImageScalingSize = new Size(20, 20);
            menuAlarma.Items.AddRange(new ToolStripItem[] { MNSalarma });
            menuAlarma.Location = new Point(0, 0);
            menuAlarma.Name = "menuAlarma";
            menuAlarma.Size = new Size(622, 28);
            menuAlarma.TabIndex = 1;
            menuAlarma.Text = "menuStrip1";
            // 
            // MNSalarma
            // 
            MNSalarma.DropDownItems.AddRange(new ToolStripItem[] { alarma1ToolStripMenuItem });
            MNSalarma.Name = "MNSalarma";
            MNSalarma.Size = new Size(147, 24);
            MNSalarma.Text = "Establecer Alarma ";
            // 
            // alarma1ToolStripMenuItem
            // 
            alarma1ToolStripMenuItem.Name = "alarma1ToolStripMenuItem";
            alarma1ToolStripMenuItem.Size = new Size(224, 26);
            alarma1ToolStripMenuItem.Text = "Alarma 1";
            alarma1ToolStripMenuItem.Click += alarma1ToolStripMenuItem_Click;
            // 
            // FrmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 180);
            Controls.Add(lblHora);
            Controls.Add(menuAlarma);
            MainMenuStrip = menuAlarma;
            Name = "FrmTemporizadores";
            Text = "Reloj";
            menuAlarma.ResumeLayout(false);
            menuAlarma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private MenuStrip menuAlarma;
        private ToolStripMenuItem MNSalarma;
        private ToolStripMenuItem alarma1ToolStripMenuItem;
    }
}