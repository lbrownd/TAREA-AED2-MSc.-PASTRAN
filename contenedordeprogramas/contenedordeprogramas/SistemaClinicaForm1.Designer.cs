namespace SistemaClinicaForms
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtFicha = new TextBox();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnInorden = new Button();
            btnPreorden = new Button();
            btnPostorden = new Button();
            dgvPacientes = new DataGridView();
            ficha = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            cmbCriterioBusqueda = new ComboBox();
            txtValorBusqueda = new TextBox();
            btnVerTodo = new Button();
            label8 = new Label();
            label9 = new Label();
            txtEspecialidad = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFicha
            // 
            txtFicha.BackColor = Color.White;
            txtFicha.Location = new Point(176, 136);
            txtFicha.Name = "txtFicha";
            txtFicha.Size = new Size(140, 27);
            txtFicha.TabIndex = 0;
            txtFicha.TextChanged += txtFicha_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Location = new Point(176, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SteelBlue;
            btnRegistrar.Location = new Point(177, 240);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(139, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Location = new Point(173, 353);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(59, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnInorden
            // 
            btnInorden.BackColor = Color.DodgerBlue;
            btnInorden.Location = new Point(173, 388);
            btnInorden.Name = "btnInorden";
            btnInorden.Size = new Size(42, 29);
            btnInorden.TabIndex = 6;
            btnInorden.Text = "In";
            btnInorden.UseVisualStyleBackColor = false;
            btnInorden.Click += btnInorden_Click_1;
            // 
            // btnPreorden
            // 
            btnPreorden.BackColor = Color.Gold;
            btnPreorden.Location = new Point(222, 386);
            btnPreorden.Name = "btnPreorden";
            btnPreorden.Size = new Size(38, 29);
            btnPreorden.TabIndex = 7;
            btnPreorden.Text = "Pre";
            btnPreorden.UseVisualStyleBackColor = false;
            btnPreorden.Click += btnPreorden_Click_1;
            // 
            // btnPostorden
            // 
            btnPostorden.BackColor = Color.Red;
            btnPostorden.Location = new Point(267, 386);
            btnPostorden.Name = "btnPostorden";
            btnPostorden.Size = new Size(47, 29);
            btnPostorden.TabIndex = 8;
            btnPostorden.Text = "Post";
            btnPostorden.UseVisualStyleBackColor = false;
            btnPostorden.Click += btnPostorden_Click_1;
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = Color.DarkGray;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { ficha, nombre, especialidad });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPacientes.Location = new Point(323, 137);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(475, 332);
            dgvPacientes.TabIndex = 9;
            // 
            // ficha
            // 
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ficha.DefaultCellStyle = dataGridViewCellStyle5;
            ficha.HeaderText = "Ficha";
            ficha.MinimumWidth = 6;
            ficha.Name = "ficha";
            ficha.Width = 125;
            // 
            // nombre
            // 
            dataGridViewCellStyle6.BackColor = Color.SteelBlue;
            nombre.DefaultCellStyle = dataGridViewCellStyle6;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 160;
            // 
            // especialidad
            // 
            dataGridViewCellStyle7.BackColor = Color.SteelBlue;
            especialidad.DefaultCellStyle = dataGridViewCellStyle7;
            especialidad.HeaderText = "Especialidad";
            especialidad.MinimumWidth = 6;
            especialidad.Name = "especialidad";
            especialidad.Width = 164;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 139);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 10;
            label1.Text = "Ficha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 172);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 205);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 12;
            label3.Text = "Especialidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(28, 277);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 13;
            label4.Text = "Buscar Por:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 392);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 14;
            label5.Text = "Tipo de Orden:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(367, 39);
            label6.Name = "label6";
            label6.Size = new Size(166, 18);
            label6.TabIndex = 15;
            label6.Text = "MODULO PACIENTES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(187, 58);
            label7.Name = "label7";
            label7.Size = new Size(534, 20);
            label7.TabIndex = 16;
            label7.Text = "Regsitro, Busqueda y Visualizacion de Reportes InOrden , PreOrden y PostOrden";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(176, 421);
            button1.Name = "button1";
            button1.Size = new Size(139, 51);
            button1.TabIndex = 17;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCriterioBusqueda
            // 
            cmbCriterioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriterioBusqueda.FormattingEnabled = true;
            cmbCriterioBusqueda.Items.AddRange(new object[] { "Ficha", "Nombre", "Especialidad" });
            cmbCriterioBusqueda.Location = new Point(176, 274);
            cmbCriterioBusqueda.Name = "cmbCriterioBusqueda";
            cmbCriterioBusqueda.Size = new Size(139, 28);
            cmbCriterioBusqueda.TabIndex = 18;
            cmbCriterioBusqueda.SelectedIndexChanged += cmbCriterioBusqueda_SelectedIndexChanged;
            // 
            // txtValorBusqueda
            // 
            txtValorBusqueda.BackColor = SystemColors.Window;
            txtValorBusqueda.Location = new Point(176, 317);
            txtValorBusqueda.Name = "txtValorBusqueda";
            txtValorBusqueda.Size = new Size(138, 27);
            txtValorBusqueda.TabIndex = 19;
            // 
            // btnVerTodo
            // 
            btnVerTodo.BackColor = Color.SteelBlue;
            btnVerTodo.Location = new Point(246, 353);
            btnVerTodo.Name = "btnVerTodo";
            btnVerTodo.Size = new Size(67, 29);
            btnVerTodo.TabIndex = 20;
            btnVerTodo.Text = "Limpiar";
            btnVerTodo.UseVisualStyleBackColor = false;
            btnVerTodo.Click += btnVerTodo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(247, 78);
            label8.Name = "label8";
            label8.Size = new Size(401, 20);
            label8.TabIndex = 21;
            label8.Text = "Agregar Valores de Fichas Inciales [50, 30, 70, 20, 40, 60, 80]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(354, 488);
            label9.Name = "label9";
            label9.Size = new Size(388, 20);
            label9.TabIndex = 22;
            label9.Text = "Carnet: 12046948 - L. Brown - Arboles Busqueda Binaria";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = Color.White;
            txtEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEspecialidad.FormattingEnabled = true;
            txtEspecialidad.Items.AddRange(new object[] { "Medicina General", "Nutricion", "Oftalmologia", "Pediatria", "Radiologia", "UltraSonido", "Examenes" });
            txtEspecialidad.Location = new Point(176, 202);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(140, 28);
            txtEspecialidad.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = contenedordeprogramas.Properties.Resources.LBROWN_MICROSYSTEMS;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(829, 558);
            Controls.Add(dgvPacientes);
            Controls.Add(pictureBox1);
            Controls.Add(txtEspecialidad);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnVerTodo);
            Controls.Add(txtValorBusqueda);
            Controls.Add(cmbCriterioBusqueda);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPostorden);
            Controls.Add(btnPreorden);
            Controls.Add(btnInorden);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Controls.Add(txtFicha);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tutoria Algorit. y Estructura de Datos II - ABB - Profesor: MSc.Walter Pastran";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFicha;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnInorden;
        private Button btnPreorden;
        private Button btnPostorden;
        private DataGridView dgvPacientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private ComboBox cmbCriterioBusqueda;
        private TextBox txtValorBusqueda;
        private Button btnVerTodo;
        private Label label8;
        private Label label9;
        private ComboBox txtEspecialidad;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ficha;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn especialidad;
    }
}
