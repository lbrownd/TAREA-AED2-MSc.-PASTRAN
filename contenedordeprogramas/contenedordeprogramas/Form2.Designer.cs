
namespace SistemaClinicaForms
{
    partial class Form2
    {
        
        private System.ComponentModel.IContainer components = null;

        
      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            txtFicha = new TextBox();
            txtNombre = new TextBox();
            txtEspecialidad = new ComboBox();
            btnRegistrar = new Button();
            cmbOrdenamiento = new ComboBox();
            btnEjecutarOrdenamiento = new Button();
            cmbBusqueda = new ComboBox();
            txtValorBusqueda = new TextBox();
            label1 = new Label();
            btnEjecutarBusqueda = new Button();
            dgvPacientes = new DataGridView();
            numficha = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            btnCargarTXT = new Button();
            btnEliminar = new Button();
            label8 = new Label();
            label9 = new Label();
            btnEliminarTodos = new Button();
            btnRestablecer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFicha
            // 
            txtFicha.BackColor = SystemColors.InactiveCaption;
            txtFicha.Location = new Point(211, 209);
            txtFicha.Margin = new Padding(4, 5, 4, 5);
            txtFicha.Name = "txtFicha";
            txtFicha.Size = new Size(159, 27);
            txtFicha.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(211, 252);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = SystemColors.InactiveCaption;
            txtEspecialidad.FormattingEnabled = true;
            txtEspecialidad.Items.AddRange(new object[] { "Medicina General", "Odontología", "Pediatría", "Nutrición", "" });
            txtEspecialidad.Location = new Point(211, 294);
            txtEspecialidad.Margin = new Padding(4, 5, 4, 5);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(160, 28);
            txtEspecialidad.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrar.Location = new Point(209, 335);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(161, 46);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Paciente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbOrdenamiento
            // 
            cmbOrdenamiento.BackColor = SystemColors.InactiveCaption;
            cmbOrdenamiento.FormattingEnabled = true;
            cmbOrdenamiento.Items.AddRange(new object[] { "Burbuja", "QuickSort", "Ordenamiento Externo" });
            cmbOrdenamiento.Location = new Point(209, 402);
            cmbOrdenamiento.Margin = new Padding(4, 5, 4, 5);
            cmbOrdenamiento.Name = "cmbOrdenamiento";
            cmbOrdenamiento.Size = new Size(160, 28);
            cmbOrdenamiento.TabIndex = 4;
            // 
            // btnEjecutarOrdenamiento
            // 
            btnEjecutarOrdenamiento.BackColor = SystemColors.HotTrack;
            btnEjecutarOrdenamiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEjecutarOrdenamiento.Location = new Point(209, 440);
            btnEjecutarOrdenamiento.Margin = new Padding(4, 5, 4, 5);
            btnEjecutarOrdenamiento.Name = "btnEjecutarOrdenamiento";
            btnEjecutarOrdenamiento.Size = new Size(159, 45);
            btnEjecutarOrdenamiento.TabIndex = 5;
            btnEjecutarOrdenamiento.Text = "Ordenar";
            btnEjecutarOrdenamiento.UseVisualStyleBackColor = false;
            btnEjecutarOrdenamiento.Click += btnEjecutarOrdenamiento_Click;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.BackColor = SystemColors.InactiveCaption;
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Items.AddRange(new object[] { "Busqueda Secuencial", "Busqueda Binaria", "Busqueda Externa" });
            cmbBusqueda.Location = new Point(209, 495);
            cmbBusqueda.Margin = new Padding(4, 5, 4, 5);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(160, 28);
            cmbBusqueda.TabIndex = 6;
            // 
            // txtValorBusqueda
            // 
            txtValorBusqueda.BackColor = SystemColors.InactiveCaption;
            txtValorBusqueda.Location = new Point(209, 542);
            txtValorBusqueda.Margin = new Padding(4, 5, 4, 5);
            txtValorBusqueda.Name = "txtValorBusqueda";
            txtValorBusqueda.Size = new Size(160, 27);
            txtValorBusqueda.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 540);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 24);
            label1.TabIndex = 8;
            label1.Text = "Que ficha buscar:";
            // 
            // btnEjecutarBusqueda
            // 
            btnEjecutarBusqueda.BackColor = SystemColors.HotTrack;
            btnEjecutarBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEjecutarBusqueda.ForeColor = SystemColors.Control;
            btnEjecutarBusqueda.Location = new Point(209, 588);
            btnEjecutarBusqueda.Margin = new Padding(4, 5, 4, 5);
            btnEjecutarBusqueda.Name = "btnEjecutarBusqueda";
            btnEjecutarBusqueda.Size = new Size(73, 49);
            btnEjecutarBusqueda.TabIndex = 9;
            btnEjecutarBusqueda.Text = "Buscar Ficha";
            btnEjecutarBusqueda.UseVisualStyleBackColor = false;
            btnEjecutarBusqueda.Click += btnEjecutarBusqueda_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { numficha, nombre, especialidad });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle11;
            dgvPacientes.GridColor = SystemColors.HotTrack;
            dgvPacientes.Location = new Point(391, 212);
            dgvPacientes.Margin = new Padding(4, 5, 4, 5);
            dgvPacientes.Name = "dgvPacientes";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvPacientes.RowHeadersWidth = 62;
            dgvPacientes.Size = new Size(475, 346);
            dgvPacientes.TabIndex = 10;
            // 
            // numficha
            // 
            dataGridViewCellStyle8.BackColor = Color.Silver;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            numficha.DefaultCellStyle = dataGridViewCellStyle8;
            numficha.HeaderText = "Num. Ficha";
            numficha.MinimumWidth = 8;
            numficha.Name = "numficha";
            numficha.Width = 140;
            // 
            // nombre
            // 
            dataGridViewCellStyle9.BackColor = Color.Silver;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            nombre.DefaultCellStyle = dataGridViewCellStyle9;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // especialidad
            // 
            dataGridViewCellStyle10.BackColor = Color.Silver;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            especialidad.DefaultCellStyle = dataGridViewCellStyle10;
            especialidad.HeaderText = "Especialidad";
            especialidad.MinimumWidth = 8;
            especialidad.Name = "especialidad";
            especialidad.Width = 150;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DeepPink;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(550, 588);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(156, 49);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LISTAR TODO";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.HotTrack;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(209, 657);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(160, 53);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 289);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 13;
            label2.Text = "Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 406);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 24);
            label3.TabIndex = 14;
            label3.Text = "Tipo de Ordenam.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(7, 494);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 24);
            label4.TabIndex = 15;
            label4.Text = "Tip. de Busqueda:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 24);
            label5.TabIndex = 16;
            label5.Text = "Ficha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 248);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 24);
            label6.TabIndex = 17;
            label6.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = contenedordeprogramas.Properties.Resources.LBROWN_MICROSYSTEMS;
            pictureBox1.Location = new Point(11, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(261, 77);
            label7.Name = "label7";
            label7.Size = new Size(420, 41);
            label7.TabIndex = 19;
            label7.Text = "TIPOS DE ORDENAMIENTOS";
            // 
            // btnCargarTXT
            // 
            btnCargarTXT.BackColor = Color.ForestGreen;
            btnCargarTXT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarTXT.Location = new Point(391, 587);
            btnCargarTXT.Name = "btnCargarTXT";
            btnCargarTXT.Size = new Size(141, 49);
            btnCargarTXT.TabIndex = 20;
            btnCargarTXT.Text = "CARGAR DATOS EXTERNOS";
            btnCargarTXT.UseVisualStyleBackColor = false;
            btnCargarTXT.Click += btnCargarTXT_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(289, 588);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 49);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Elimin. Ficha";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 708);
            label8.Name = "label8";
            label8.Size = new Size(364, 20);
            label8.TabIndex = 22;
            label8.Text = "Carnet: 12046948 - L. Brown - Tipos de Ordenamiento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(320, 36);
            label9.Name = "label9";
            label9.Size = new Size(316, 41);
            label9.TabIndex = 23;
            label9.Text = "MODULO PACIENTES";
            // 
            // btnEliminarTodos
            // 
            btnEliminarTodos.BackColor = Color.Red;
            btnEliminarTodos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarTodos.Location = new Point(725, 587);
            btnEliminarTodos.Name = "btnEliminarTodos";
            btnEliminarTodos.Size = new Size(141, 49);
            btnEliminarTodos.TabIndex = 24;
            btnEliminarTodos.Text = "ELIMIN. TODOS";
            btnEliminarTodos.UseVisualStyleBackColor = false;
            btnEliminarTodos.Click += btnEliminarTodos_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.BackColor = SystemColors.HotTrack;
            btnRestablecer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestablecer.Location = new Point(729, 657);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(137, 48);
            btnRestablecer.TabIndex = 25;
            btnRestablecer.Text = "RECUP. TODOS";
            btnRestablecer.UseVisualStyleBackColor = false;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(881, 737);
            Controls.Add(btnRestablecer);
            Controls.Add(btnEliminarTodos);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnCargarTXT);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPacientes);
            Controls.Add(btnEjecutarBusqueda);
            Controls.Add(label1);
            Controls.Add(txtValorBusqueda);
            Controls.Add(cmbBusqueda);
            Controls.Add(btnEjecutarOrdenamiento);
            Controls.Add(cmbOrdenamiento);
            Controls.Add(btnRegistrar);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(txtFicha);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tutoria Algorit. y Estructura de Datos II - Tipos de Ordenamiento - Profesor: MSc.Walter Pastran";
            TopMost = true;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox txtEspecialidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
        private System.Windows.Forms.Button btnEjecutarOrdenamiento;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEjecutarBusqueda;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label7;
        private DataGridViewTextBoxColumn numficha;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn especialidad;
        private Button btnCargarTXT;
        private Button btnEliminar;
        private Label label8;
        private Label label9;
        private Button btnEliminarTodos;
        private Button btnRestablecer;
    }
}

