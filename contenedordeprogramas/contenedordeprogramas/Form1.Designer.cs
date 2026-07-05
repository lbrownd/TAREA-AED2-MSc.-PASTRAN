namespace contenedordeprogramas
{
    partial class contenedorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contenedorFrm));
            toolStrip1 = new ToolStrip();
            toolStripBtnBB = new ToolStripButton();
            toolStripBtnOrdenamientos = new ToolStripButton();
            toolStripBtnSalir = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnBB, toolStripBtnOrdenamientos, toolStripBtnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnBB
            // 
            toolStripBtnBB.Image = (Image)resources.GetObject("toolStripBtnBB.Image");
            toolStripBtnBB.ImageTransparentColor = Color.Magenta;
            toolStripBtnBB.Name = "toolStripBtnBB";
            toolStripBtnBB.Size = new Size(148, 24);
            toolStripBtnBB.Text = "Busqueda Binaria";
            toolStripBtnBB.Click += toolStripBtnBB_Click;
            // 
            // toolStripBtnOrdenamientos
            // 
            toolStripBtnOrdenamientos.Image = (Image)resources.GetObject("toolStripBtnOrdenamientos.Image");
            toolStripBtnOrdenamientos.ImageTransparentColor = Color.Magenta;
            toolStripBtnOrdenamientos.Name = "toolStripBtnOrdenamientos";
            toolStripBtnOrdenamientos.Size = new Size(196, 24);
            toolStripBtnOrdenamientos.Text = "Tipos de Ordenamientos";
            toolStripBtnOrdenamientos.Click += toolStripBtnOrdenamientos_Click;
            // 
            // toolStripBtnSalir
            // 
            toolStripBtnSalir.Image = (Image)resources.GetObject("toolStripBtnSalir.Image");
            toolStripBtnSalir.ImageTransparentColor = Color.Magenta;
            toolStripBtnSalir.Name = "toolStripBtnSalir";
            toolStripBtnSalir.Size = new Size(62, 24);
            toolStripBtnSalir.Text = "Salir";
            toolStripBtnSalir.Click += toolStripBtnSalir_Click;
            // 
            // contenedorFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "contenedorFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tutoria de Algoritmo y Estructura de Datos II  - Docente: MSc. Walter Pastran";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnBB;
        private ToolStripButton toolStripBtnOrdenamientos;
        private ToolStripButton toolStripBtnSalir;
    }
}
