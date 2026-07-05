using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaClinicaForms
{
    public partial class Form1 : Form
    {
        // 1. Instanciamos globalmente la clase de arbol logico
        private SistemaFichas sistema = new SistemaFichas();

        public Form1()
        {
            InitializeComponent();
            CargarDatosPrueba();
        }

        // 2. PAra efecto de pruebas inicialmente cargamos 7 pacintes por defecto al iniciar el programa
        private void CargarDatosPrueba()
        {
           /* 
            
            sistema.Insertar(50, "Carlos", "Medicina General");
            sistema.Insertar(30, "Ana", "Odontología");
            sistema.Insertar(70, "Luis", "Pediatría");
            sistema.Insertar(20, "Maria", "Medicina General");
            sistema.Insertar(40, "Jorge", "Odontología");
            sistema.Insertar(60, "Sofia", "Nutrición");
            sistema.Insertar(80, "Andres", "Pediatría");

        // 3. Muestramos el reporte inicial ordenado por defecto en la tabla
            
        //B */
            ActualizarTabla(sistema.ObtenerInorden());
            txtEspecialidad.SelectedIndex = 0;
        }

        // 4. Metodo auxiliar para limpiar la tabla y llenarla con cualquier reporte
        private void ActualizarTabla(List<NodoPaciente> listaPacientes)
        {
            /*
            dgvPacientes.Rows.Clear();
            foreach (var p in listaPacientes)
            {
                dgvPacientes.Rows.Add(p.NumFicha, p.Nombre, p.Especialidad);
            }*/
            dgvPacientes.Rows.Clear();

            // 5. Si la lista viene vacía, no hace nada y deja la tabla limpia
            if (listaPacientes == null || listaPacientes.Count == 0)
            {
                return;
            }

            foreach (var p in listaPacientes)
            {
                dgvPacientes.Rows.Add(p.NumFicha, p.Nombre, p.Especialidad);
            }

        }

        //  6. Registrar nuevo paciente
        /*    private void btnRegistrar_Click(object sender, EventArgs e)
            {
            }

            // EVENTO: Buscar paciente por ficha
            private void btnBuscar_Click(object sender, EventArgs e)
            {
            }*/

        // 6. Eventos de reportes: Cambian de forma automatica las filas de la tabla gráfica y necesitamos pasar el reporte que se
        // obtiene del arbol lógico a la tabla visual
        private void btnInorden_Click(object sender, EventArgs e) => ActualizarTabla(sistema.ObtenerInorden());
        private void btnPreorden_Click(object sender, EventArgs e) => ActualizarTabla(sistema.ObtenerPreorden());
        private void btnPostorden_Click(object sender, EventArgs e) => ActualizarTabla(sistema.ObtenerPostorden());

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtFicha.Text, out int ficha))
            {
                /*   string nombre = txtNombre.Text.Trim();
                     string especialidad = txtEspecialidad.Text.Trim();



                         if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(especialidad))
                     {
                         */
                string nombre = txtNombre.Text.Trim();

                // 7. Ahora leemos el texto directamente del ComboBox seleccionado para que no haya problemas de formato o espacios en blanco,
                // y si no hay nada seleccionado, asignamos una cadena vacía para que el programa pida llenar ese campo
                string especialidad = txtEspecialidad.SelectedItem != null ? txtEspecialidad.SelectedItem.ToString() : "";

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(especialidad))
                {




                    // 8. Buscamos por si acaso ya existe para no duplicar el nuevo registro en el ABB
                    if (sistema.Buscar(ficha) != null)
                    {
                        MessageBox.Show($"La ficha {ficha} ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    sistema.Insertar(ficha, nombre, especialidad);
                    MessageBox.Show($"Paciente {nombre} registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 9.  Limpiamos los textbox para que no queden ahi restos de la insersion anterior
                    txtFicha.Clear();
                    txtNombre.Clear();
                    txtEspecialidad.SelectedIndex = 0;


                    // 10.  Aqui refrescamos la tabla visual en Inorden automáticamente segun el ordenamiento natural del ABB,
                    // para que el usuario vea el nuevo registro agregado
                    ActualizarTabla(sistema.ObtenerInorden());
                }
                else
                {
                    MessageBox.Show("Por favor, rellene todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La ficha debe ser un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            // 11. Aqui Validamos la selección en el ComboBox
            if (cmbCriterioBusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda (Ficha, Nombre o Especialidad).", "Seleccione Criterio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string valorBuscar = txtValorBusqueda.Text.Trim();

            // 12. Validamos campo de texto vacío
            if (string.IsNullOrEmpty(valorBuscar))
            {
                MessageBox.Show("Por favor, ingrese el término que desea buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = cmbCriterioBusqueda.SelectedItem.ToString();
            List<NodoPaciente> resultadosBusqueda = new List<NodoPaciente>();

            // 13. Aqui se realiza la evaluacion del criterio seleccionado y se llama al método de búsqueda correspondiente,
            // y se maneja el caso especial de la ficha para convertir el texto a número entero puro antes de buscar en el ABB,
            // y si no es un número válido, se muestra un mensaje de error
            if (criterio == "Número de Ficha" || criterio == "Ficha")
            {
                // 14. Convertimos el texto ingresado a número entero puro
                if (int.TryParse(valorBuscar, out int ficha))
                {
                    // 15. Aqui utilizamos el método original del árbol que busca directamente por número me refiero al método Buscar(int numFicha)
                    // que devuelve un solo nodo, y si encuentra el paciente con esa ficha, lo añadimos a la lista de resultados para mostrarlo en
                    // la tabla, y si no lo encuentra, la lista quedará vacía y se mostrará el mensaje de "No se encontraron pacientes..."
                    NodoPaciente paciente = sistema.Buscar(ficha);

                    if (paciente != null)
                    {
                        // 16. Se añade el paciente encontrado a la lista
                        resultadosBusqueda.Add(paciente);
                    }
                }
                else
                {
                    // 17. Si el valor ingresado no es un número entero válido, se muestra un mensaje de error y se detiene la búsqueda
                    MessageBox.Show("Para buscar por ficha, debe ingresar un número entero válido (sin letras ni espacios).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (criterio == "Nombre")
            {
                // 18. Si el criterio es por nombre, se llama al método de búsqueda por nombre que devuelve una lista de pacientes
                // que coinciden con el término ingresado, y se asigna esa lista a resultadosBusqueda para mostrarla en la tabla
                resultadosBusqueda = sistema.BuscarPorNombreLista(valorBuscar);
            }
            else if (criterio == "Especialidad")
            {
                resultadosBusqueda = sistema.BuscarPorEspecialidadLista(valorBuscar);
            }

            // 19. mostramos los resultados en la tabla, y si no hay resultados, se muestra un mensaje informativo y se refresca
            // la tabla con la lista completa de pacientes para que el usuario pueda ver todos los registros disponibles
            if (resultadosBusqueda.Count > 0)
            {
                ActualizarTabla(resultadosBusqueda);
            }
            else
            {
                MessageBox.Show($"No se encontraron pacientes que coincidan con '{valorBuscar}' en el criterio seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarTabla(sistema.ObtenerInorden());
                // 20. Si no hay resultados, la actualizacion de la tabla muestra la lista completa
            }
        }



        // 21. Cada vez que se hace clic en uno de los botones de orden (Inorden, Preorden, Postorden), se llama
        // al método ActualizarTabla con el reporte correspondiente obtenido del árbol lógico, para que la tabla visual
        // se actualice automáticamente con el nuevo ordenamiento seleccionado por el usuario
        private void btnInorden_Click_1(object sender, EventArgs e)
        {
            ActualizarTabla(sistema.ObtenerInorden());
        }

        private void btnPreorden_Click_1(object sender, EventArgs e)
        {
            ActualizarTabla(sistema.ObtenerPreorden());
        }

        private void btnPostorden_Click_1(object sender, EventArgs e)
        {
            ActualizarTabla(sistema.ObtenerPostorden());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            // 22. Este botón simplemente limpia el campo de búsqueda, resetea el ComboBox a su estado inicial y muestra
            // la lista completa de pacientes en la tabla, para que el usuario pueda volver a ver todos los registros después
            // de realizar una búsqueda específica
            txtValorBusqueda.Clear();
            cmbCriterioBusqueda.SelectedIndex = 0;
            ActualizarTabla(sistema.ObtenerInorden());
            txtValorBusqueda.Focus();
        }

        
        private void cmbCriterioBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFicha_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // 23. Esta clase representa cada nodo del árbol lógico, con sus propiedades de número de ficha, nombre, especialidad
    // y referencias a los nodos izquierdo y derecho para formar la estructura del ABB, y un constructor para inicializar
    // estos valores al crear un nuevo nodo
    public class NodoPaciente
    {
        public int NumFicha { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public NodoPaciente Izquierdo { get; set; }
        public NodoPaciente Derecho { get; set; }

        // 24. El constructor de la clase NodoPaciente recibe los parámetros necesarios para crear un nuevo nodo con la información
        // del paciente, y asigna esos valores a las propiedades correspondientes, mientras que las referencias a los nodos izquierdo
        // y derecho se inicializan como null por defecto, ya que al crear un nuevo nodo no tiene hijos aún    
        public NodoPaciente(int numFicha, string nombre, string especialidad)
        {
            NumFicha = numFicha;
            Nombre = nombre;
            Especialidad = especialidad;
        }
    }
    // 25. Esta clase representa el sistema de fichas médicas utilizando un árbol binario de búsqueda (ABB) para almacenar
    // y gestionar los pacientes, con métodos para insertar nuevos pacientes, buscar por ficha, nombre o especialidad,
    // y obtener reportes en diferentes órdenes (Inorden, Preorden, Postorden) para mostrar en la tabla visual del formulario
    public class SistemaFichas
    {
        private NodoPaciente raiz = null;

        public void Insertar(int numFicha, string nombre, string especialidad)
        {
            NodoPaciente nuevo = new NodoPaciente(numFicha, nombre, especialidad);
            if (raiz == null) raiz = nuevo;
            else InsertarRecursivo(raiz, nuevo);
        }
        // 26. Este método privado realiza la inserción recursiva de un nuevo nodo en el árbol binario de búsqueda,
        // comparando el número de ficha del nuevo nodo con el nodo actual para determinar si debe ir a la izquierda
        // o a la derecha, y asegurándose de no insertar duplicados al verificar si el número de ficha ya existe en el árbol
        private void InsertarRecursivo(NodoPaciente actual, NodoPaciente nuevo)
        {
            if (nuevo.NumFicha == actual.NumFicha) return;

            if (nuevo.NumFicha < actual.NumFicha)
            {
                if (actual.Izquierdo == null) actual.Izquierdo = nuevo;
                else InsertarRecursivo(actual.Izquierdo, nuevo);
            }
            else
            {
                if (actual.Derecho == null) actual.Derecho = nuevo;
                else InsertarRecursivo(actual.Derecho, nuevo);
            }
        }

        // 27. Este método privado es una función auxiliar para eliminar las tildes de un texto, reemplazando
        // cada vocal acentuada por su equivalente sin tilde, lo que facilita las comparaciones de texto en
        // las búsquedas por nombre o especialidad, permitiendo que las búsquedas sean insensibles a las tildes
        // y mejorando la experiencia del usuario al no tener que preocuparse por la ortografía exacta al buscar pacientes
        private string EliminarTildes(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return texto;

            // Diccionario rápido de reemplazo para eliminar tildes
            return texto.Replace("á", "a")
                            .Replace("é", "e")
                            .Replace("í", "i")
                            .Replace("ó", "o")
                            .Replace("ú", "u");
        }
        // 28. Este método público permite buscar un paciente por su número de ficha, utilizando una búsqueda
        // recursiva en el árbol binario de búsqueda, y devuelve el nodo del paciente si se encuentra,
        // o null si no se encuentra ningún paciente con esa ficha, lo que facilita la gestión de los pacientes
        // y la verificación de duplicados al insertar nuevos registros
        public NodoPaciente Buscar(int numFicha) => BuscarRecursivo(raiz, numFicha);

        // 29. Este método privado realiza la búsqueda recursiva de un paciente por su número de ficha,
        // comparando el número de ficha buscado con el número de ficha del nodo actual para determinar
        // si se encuentra en ese nodo, o si debe continuar la búsqueda hacia la izquierda o hacia la derecha del árbol,
        // lo que permite una búsqueda eficiente en el ABB
        private NodoPaciente BuscarRecursivo(NodoPaciente actual, int numFicha)
        {
            if (actual == null || actual.NumFicha == numFicha) return actual;
            if (numFicha < actual.NumFicha) return BuscarRecursivo(actual.Izquierdo, numFicha);
            return BuscarRecursivo(actual.Derecho, numFicha);
        }

        // 30. Este método público permite buscar pacientes por su nombre, recorriendo todo el árbol binario
        // de forma recursiva y comparando el nombre de cada nodo con el término de búsqueda ingresado,
        // utilizando una comparación insensible a mayúsculas y tildes para mejorar la experiencia del usuario,
        // y devuelve una lista de nodos que coinciden con el término de búsqueda, lo que facilita la gestión
        // de los pacientes y la visualización de los resultados en la tabla del formulario
        public List<NodoPaciente> BuscarPorNombreLista(string nombre)
        {
            List<NodoPaciente> resultados = new List<NodoPaciente>();
            BuscarNombreRecursivoLista(raiz, nombre.ToLower(), resultados);
            return resultados;
        }
        // 31. Este método privado realiza la búsqueda recursiva de pacientes por su nombre,
        // comparando el nombre de cada nodo con el término de búsqueda ingresado, utilizando
        // una comparación insensible a mayúsculas y tildes para mejorar la experiencia del usuario,
        // y añadiendo los nodos que coinciden con el término de búsqueda a una lista de resultados
        // que se devuelve al finalizar la búsqueda, lo que permite obtener una lista completa de pacientes
        // que coinciden con el criterio de búsqueda por nombre
        private void BuscarNombreRecursivoLista(NodoPaciente nodoActual, string nombreBuscar, List<NodoPaciente> resultados)
        {
            if (nodoActual == null) return;

            // 32. Pasamos todo a minúsculas y limpiamos tildes para hacer una comparación insensible a mayúsculas y tildes
            string nombreNodoLimpio = EliminarTildesInterno(nodoActual.Nombre.ToLower());
            string nombreBuscarLimpio = EliminarTildesInterno(nombreBuscar);

            if (nombreNodoLimpio.Contains(nombreBuscarLimpio))
            {
                resultados.Add(nodoActual);
            }

            BuscarNombreRecursivoLista(nodoActual.Izquierdo, nombreBuscar, resultados);
            BuscarNombreRecursivoLista(nodoActual.Derecho, nombreBuscar, resultados);
        }

        // 33. Este método público permite buscar pacientes por su especialidad,
        // recorriendo todo el árbol de forma recursiva y comparando la especialidad
        // de cada nodo con el término de búsqueda ingresado, utilizando una comparación
        // insensible a mayúsculas y tildes y devuelve una lista de nodos que coinciden
        // con el término de búsqueda, lo que facilita la gestión de los pacientes
        // y la visualización de los resultados en la tabla del formulario
        public List<NodoPaciente> BuscarPorEspecialidadLista(string especialidad)
        {
            List<NodoPaciente> resultados = new List<NodoPaciente>();
            BuscarEspecialidadRecursivoLista(raiz, especialidad.ToLower(), resultados);
            return resultados;
        }
        // 34. Este método privado realiza la búsqueda recursiva de pacientes por su especialidad,
        // comparando la especialidad de cada nodo con el término de búsqueda ingresado, utilizando
        // una comparación insensible a mayúsculas y tildes para mejorar la experiencia del usuario,
        // y añadiendo los nodos que coinciden con el término de búsqueda a una lista de resultados
        // que se devuelve al finalizar la búsqueda, lo que permite obtener una lista completa de
        // pacientes que coinciden con el criterio de búsqueda por especialidad
        private void BuscarEspecialidadRecursivoLista(NodoPaciente nodoActual, string espBuscar, List<NodoPaciente> resultados)
        {
            if (nodoActual == null) return;

            // 35. Pasamos todo a minúsculas y limpiamos tildes para hacer una comparación insensible a mayúsculas y tildes
            string espNodoLimpio = EliminarTildesInterno(nodoActual.Especialidad.ToLower());
            string espBuscarLimpio = EliminarTildesInterno(espBuscar);

            if (espNodoLimpio.Contains(espBuscarLimpio))
            {
                resultados.Add(nodoActual);
            }

            BuscarEspecialidadRecursivoLista(nodoActual.Izquierdo, espBuscar, resultados);
            BuscarEspecialidadRecursivoLista(nodoActual.Derecho, espBuscar, resultados);
        }
        // 36. Este método privado es una función auxiliar para eliminar las tildes de un texto,
        // reemplazando cada vocal acentuada por su equivalente sin tilde, lo que facilita las comparaciones
        // de texto en las búsquedas por nombre o especialidad, permitiendo que las búsquedas sean insensibles
        // a las tildes y mejorando la experiencia del usuario al no tener que preocuparse por la ortografía
        // exacta al buscar pacientes
        private string EliminarTildesInterno(string texto)
        {
            return texto.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");
        }

        // 37. Estos metodos devuelven listas de nodos para que el DataGridView los pueda imprimir aqui me refiero a
        // los métodos públicos ObtenerInorden, ObtenerPreorden y ObtenerPostorden
        // que generan reportes en diferentes órdenes de recorrido del árbol binario de búsqueda,
        // y devuelven listas de nodos que se pueden utilizar para actualizar la tabla visual del formulario,
        // permitiendo al usuario ver los pacientes ordenados según el criterio seleccionado (Inorden para
        // orden natural por ficha, Preorden para mostrar primero los padres y luego los hijos, y
        // Postorden para mostrar primero los hijos y luego los padres)
        public List<NodoPaciente> ObtenerInorden()
        {
            List<NodoPaciente> lista = new List<NodoPaciente>();
            Inorden(raiz, lista);
            return lista;
        }
        private void Inorden(NodoPaciente actual, List<NodoPaciente> lista)
        {
            if (actual != null)
            {
                Inorden(actual.Izquierdo, lista);
                lista.Add(actual);
                Inorden(actual.Derecho, lista);
            }
        }

        public List<NodoPaciente> ObtenerPreorden()
        {
            List<NodoPaciente> lista = new List<NodoPaciente>();
            Preorden(raiz, lista);
            return lista;
        }
        private void Preorden(NodoPaciente actual, List<NodoPaciente> lista)
        {
            if (actual != null)
            {
                lista.Add(actual);
                Preorden(actual.Izquierdo, lista);
                Preorden(actual.Derecho, lista);
            }
        }

        public List<NodoPaciente> ObtenerPostorden()
        {
            List<NodoPaciente> lista = new List<NodoPaciente>();
            Postorden(raiz, lista);
            return lista;
        }
        private void Postorden(NodoPaciente actual, List<NodoPaciente> lista)
        {
            if (actual != null)
            {
                Postorden(actual.Izquierdo, lista);
                Postorden(actual.Derecho, lista);
                lista.Add(actual);
            }
        }
    }
}
