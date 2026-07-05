using System;
using System.Collections.Generic; 
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaClinicaForms
{
    public partial class Form2 : Form
    {
        private List<NodoPaciente> listaMemoria = new List<NodoPaciente>();
        // private List<SistemaClinicaForms.NodoPaciente> listaMemoria = new List<SistemaClinicaForms.NodoPaciente>();
        private GestorAlgoritmos gestor = new GestorAlgoritmos();

        public Form2()
        {
            InitializeComponent();
            CargarDatosOriginales();
            ConfigurarEstructuraMenus();
        }

        private void CargarDatosOriginales()
        {

            listaMemoria.Add(new NodoPaciente(50, "Carlos", "Medicina General"));
            listaMemoria.Add(new NodoPaciente(30, "Ana", "Odontología"));
            listaMemoria.Add(new NodoPaciente(70, "Luis", "Pediatría"));
            listaMemoria.Add(new NodoPaciente(20, "Maria", "Medicina General"));
            listaMemoria.Add(new NodoPaciente(40, "Jorge", "Odontología"));
            listaMemoria.Add(new NodoPaciente(60, "Sofia", "Nutrición"));
            listaMemoria.Add(new NodoPaciente(80, "Andres", "Pediatría"));

            ActualizarTabla(listaMemoria);
        }

        private void ConfigurarEstructuraMenus()
        {
            cmbOrdenamiento.Items.Clear();
            cmbOrdenamiento.Items.Add("1. Burbuja Animada");
            cmbOrdenamiento.Items.Add("2. Quicksort Dinamico");
            cmbOrdenamiento.Items.Add("3. Ordenamiento Externo");
            cmbOrdenamiento.SelectedIndex = 0;

            cmbBusqueda.Items.Clear();
            cmbBusqueda.Items.Add("1. Búsqueda Secuencial o Lineal");
            cmbBusqueda.Items.Add("2. Busqueda Binaria");
            cmbBusqueda.Items.Add("3. Busqueda Externa (Archivo)");
            cmbBusqueda.SelectedIndex = 0;

            if (txtEspecialidad.Items.Count > 0) txtEspecialidad.SelectedIndex = 0;
        }

        private void ActualizarTabla(List<NodoPaciente> lista)
        {
            dgvPacientes.Rows.Clear();
            if (lista == null || lista.Count == 0) return;

            foreach (var p in lista)
            {
                dgvPacientes.Rows.Add(p.NumFicha, p.Nombre, p.Especialidad);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFicha.Text, out int ficha))
            {
                string nombre = txtNombre.Text.Trim();
               
                string especialidad = txtEspecialidad.SelectedItem != null ? txtEspecialidad.SelectedItem.ToString()! : "";

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(especialidad))
                {
                    if (listaMemoria.Exists(x => x.NumFicha == ficha))
                    {
                        MessageBox.Show("Esta ficha ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    listaMemoria.Add(new NodoPaciente(ficha, nombre, especialidad));
                    ActualizarTabla(listaMemoria);
                    txtFicha.Clear();
                    txtNombre.Clear();
                }
            }
        }


        //   Seccion de animaciones de los algoritmos de ordenamiento 

        private async Task AnimacionBurbujaAsync()
        {
            int n = listaMemoria.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // mostramos en amarillo las dos filas que se están comparando en el instante
                    dgvPacientes.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvPacientes.Rows[j + 1].DefaultCellStyle.BackColor = Color.Yellow;
                    await Task.Delay(400); // Pausamos un los milisegundos para que se pueda visualizar, por lo cual tambien el proceso sera mas lento

                    if (listaMemoria[j].NumFicha > listaMemoria[j + 1].NumFicha)
                    {
                        // Mostramos de rojo indicando que hay un intercambio 
                        dgvPacientes.Rows[j].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvPacientes.Rows[j + 1].DefaultCellStyle.BackColor = Color.LightCoral;

                        var temp = listaMemoria[j];
                        listaMemoria[j] = listaMemoria[j + 1];
                        listaMemoria[j + 1] = temp;

                        ActualizarTabla(listaMemoria);
                        dgvPacientes.Rows[j].DefaultCellStyle.BackColor = Color.LightCoral;
                        dgvPacientes.Rows[j + 1].DefaultCellStyle.BackColor = Color.LightCoral;
                        await Task.Delay(300);
                    }

                    // Restauramos el color blanco original
                    dgvPacientes.Rows[j].DefaultCellStyle.BackColor = Color.White;
                    dgvPacientes.Rows[j + 1].DefaultCellStyle.BackColor = Color.White;
                }
                // las ultimas filas ya fijadas se muestran en verdecito
                dgvPacientes.Rows[n - i - 1].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            ActualizarTabla(listaMemoria);
        }

        private async Task AnimacionQuicksortAsync(int bajo, int alto)
        {
            if (bajo < alto)
            {
                int pivoteVal = listaMemoria[alto].NumFicha;

                // Resaltamos visualmente cual es el pivote elegido en color azul celeste
                dgvPacientes.Rows[alto].DefaultCellStyle.BackColor = Color.Cyan;
                await Task.Delay(500);

                int i = (bajo - 1);
                for (int j = bajo; j < alto; j++)
                {
                    if (listaMemoria[j].NumFicha < pivoteVal)
                    {
                        i++;
                        var temp = listaMemoria[i];
                        listaMemoria[i] = listaMemoria[j];
                        listaMemoria[j] = temp;

                        ActualizarTabla(listaMemoria);
                        await Task.Delay(250);
                    }
                }
                var temp2 = listaMemoria[i + 1];
                listaMemoria[i + 1] = listaMemoria[alto];
                listaMemoria[alto] = temp2;

                ActualizarTabla(listaMemoria);

                int indicePivote = i + 1;

                // Llamadas recursivas simuladas visualmente
                await AnimacionQuicksortAsync(bajo, indicePivote - 1);
                await AnimacionQuicksortAsync(indicePivote + 1, alto);
            }
        }

     
        private async void btnEjecutarOrdenamiento_Click(object sender, EventArgs e)
        {
            int seleccion = cmbOrdenamiento.SelectedIndex;
            btnEjecutarOrdenamiento.Enabled = false; // Bloqueamos el boton para evitar bugs de clicks extra






            if (seleccion == 0)
            {
                await AnimacionBurbujaAsync();
                MessageBox.Show("¡Burbuja finalizada! Maestro Pastran ya paseme la clase.", "Ya me duele la cabeza. Jajajaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (seleccion == 1)
            {
                await AnimacionQuicksortAsync(0, listaMemoria.Count - 1);
                ActualizarTabla(listaMemoria);
                MessageBox.Show("¡Quicksot a finalizado sin problemas! Maestro Pastran Por lo menos mi 90 ", "Mire Quicksort Funcionando bien!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (seleccion == 2)
            {
                var listaExterna = gestor.OrdenarExterno(listaMemoria);
                ActualizarTabla(listaExterna);
                MessageBox.Show("¡Algoritmo de mezcla externa ya se completo exitosamente en discoduro!", "Proceso Avanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Primero mapeamos la ruta del escritorio del usuario para guardar el archivo de salida
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaArchivoFinal = Path.Combine(rutaEscritorio, "pacientes_ordenados.txt");

                // Mandamos a guardar el archivo al Escritorio no importando donde se encuentre, alli el archivo se guardara como:pacientes_ordenados.txt '
                using (StreamWriter writer = new StreamWriter(rutaArchivoFinal))
                {
                    foreach (var p in listaMemoria)
                    {
                        writer.WriteLine($"{p.NumFicha},{p.Nombre},{p.Especialidad}");
                    }
                }

                MessageBox.Show($"Archivo guardado en el Escritorio: {rutaArchivoFinal}");


            }

            btnEjecutarOrdenamiento.Enabled = true;
        }

        private void btnEjecutarBusqueda_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtValorBusqueda.Text, out int fichaBuscar)) return;

            int seleccion = cmbBusqueda.SelectedIndex;
            //  NodoPaciente encontrado = null;
            SistemaClinicaForms.NodoPaciente encontrado = null;

            if (seleccion == 0) encontrado = gestor.BusquedaSecuencial(listaMemoria, fichaBuscar);
            else if (seleccion == 1) encontrado = gestor.BusquedaBinaria(listaMemoria, fichaBuscar);
            else if (seleccion == 2) encontrado = gestor.BusquedaExterna(fichaBuscar);

            if (encontrado != null)
            {
                ActualizarTabla(new List<NodoPaciente> { encontrado });
                // Resaltamos el registro encontrado en verde
                dgvPacientes.Rows[0].DefaultCellStyle.BackColor = Color.Lime;
            }
            else
            {
                MessageBox.Show("Ficha no localizada.");
                ActualizarTabla(listaMemoria);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorBusqueda.Clear();
            ActualizarTabla(listaMemoria);
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
        private void Form1_Load(object sender, System.EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCargarTXT_Click(object sender, EventArgs e)
        {
            // Configuracion del buscador de archivos para que podamos localizarlo mediante un OpenFileDialog y asi poder cargarlo en la lista de memoria
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo de pacientes";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer todas las líneas del archivo de forma segura
                    string[] lineas = System.IO.File.ReadAllLines(openFileDialog.FileName);
                    int registrosCargados = 0;
                    int registrosDuplicados = 0;

                    foreach (string linea in lineas)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        // Separamos los datos por coma (pero tambien podemos cambiar ',' por ';' si en el txt  se esta usando punto y coma)
                        string[] datos = linea.Split(',');

                        // Validamos que la línea tenga exactamente los 3 campos requeridos
                        if (datos.Length == 3)
                        {
                            if (int.TryParse(datos[0].Trim(), out int ficha))
                            {
                                string nombre = datos[1].Trim();
                                string especialidad = datos[2].Trim();

                                // Validación clave: Evitamos duplicar fichas en la lista global
                                if (listaMemoria.Exists(x => x.NumFicha == ficha))
                                {
                                    registrosDuplicados++;
                                    continue;
                                }

                                // Añadimos a la lista en memoria (así no se borran al ordenar o buscar)
                                listaMemoria.Add(new NodoPaciente(ficha, nombre, especialidad));
                                registrosCargados++;
                            }
                        }
                    }

                    // Actualizamos la interfaz visual con toda la lista acumulada
                    ActualizarTabla(listaMemoria);

                    // Reporte final al usuario
                    string mensaje = $"Proceso terminado.\n- Cargados con éxito: {registrosCargados}";
                    if (registrosDuplicados > 0)
                    {
                        mensaje += $"\n- Omitidos por ficha duplicada: {registrosDuplicados}";
                    }
                    MessageBox.Show(mensaje, "Carga masiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el usuario haya seleccionado una fila en el DataGridView
            if (dgvPacientes.CurrentRow == null || dgvPacientes.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, seleccione un paciente de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el número de ficha de la fila seleccionada (asumiendo que la ficha está en la columna 0)
            var celdaFicha = dgvPacientes.CurrentRow.Cells[0].Value;
            if (celdaFicha == null) return;

            int fichaAEliminar = Convert.ToInt32(celdaFicha);

            // 3. Confirmar la eliminación con el usuario por seguridad no vaya ser se trate de un dedazo de dedo y se elimine un registro que no se desea eliminar
            DialogResult resultado = MessageBox.Show($"¿Está seguro de que desea eliminar la ficha N° {fichaAEliminar}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // 4. Buscar y remover el paciente de la lista en memoria usando una expresión Lambda
                listaMemoria.RemoveAll(p => p.NumFicha == fichaAEliminar);

                // 5. Refrescar el DataGridView con los registros que quedan
                ActualizarTabla(listaMemoria);

                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            if (listaMemoria.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar todos los registros?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                listaMemoria.Clear();
                ActualizarTabla(listaMemoria);
                MessageBox.Show("Todos los registros han sido eliminados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos la lista actual por si tiene datos mezclados
            listaMemoria.Clear();

            // 2. Volvemos a llamar al método original que añade los 7 pacientes de prueba, esto es para no estar teniendo que meter los datos de prueba cada vez que se reinicia el programa, ya que si no se hace esto, al ordenar o buscar, los datos originales se perderían y no habría forma de recuperarlos
            CargarDatosOriginales();

            // 3. Avisamos al usuario que el sistema volvió a su estado inicial
            MessageBox.Show("Restauramos los datos originales por cualquier cosa extra.", "Restablecer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}


