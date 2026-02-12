namespace CalculadorA.FORMULARIOS
{
    partial class FrmEditor
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
            mnsEditor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tssStatus = new ToolStripStatusLabel();
            rtbEditor = new RichTextBox();
            ofdEditor = new OpenFileDialog();
            sfdEditor = new SaveFileDialog();
            mnsEditor.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnsEditor
            // 
            mnsEditor.ImageScalingSize = new Size(20, 20);
            mnsEditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mnsEditor.Location = new Point(0, 0);
            mnsEditor.Name = "mnsEditor";
            mnsEditor.Size = new Size(800, 28);
            mnsEditor.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(187, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(187, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(187, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(187, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(184, 6);
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(187, 26);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            tssStatus.Name = "tssStatus";
            tssStatus.Size = new Size(76, 20);
            tssStatus.Text = "0 Palabras";
            tssStatus.Click += toolStripStatusLabel1_Click;
            
            // 
            // rtbEditor
            // 
            rtbEditor.Dock = DockStyle.Fill;
            rtbEditor.Location = new Point(0, 28);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new Size(800, 396);
            rtbEditor.TabIndex = 2;
            rtbEditor.Text = "";
            rtbEditor.TextChanged += rtbEditor_TextChanged;
            // 
            // ofdEditor
            // 
            ofdEditor.FileName = "openFileDialog1";
            ofdEditor.Filter = "\"Archivos de Texto\"|*.txt";
            // 
            // sfdEditor
            // 
            sfdEditor.Filter = "\"Archivos de Texto\"|*.txt";
            // 
            // FrmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbEditor);
            Controls.Add(statusStrip1);
            Controls.Add(mnsEditor);
            MainMenuStrip = mnsEditor;
            Name = "FrmEditor";
            Text = "Editor de Texto";
            mnsEditor.ResumeLayout(false);
            mnsEditor.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsEditor;
        private StatusStrip statusStrip1;
        private RichTextBox rtbEditor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private OpenFileDialog ofdEditor;
        private SaveFileDialog sfdEditor;
        private ToolStripStatusLabel tssStatus;
    }
}