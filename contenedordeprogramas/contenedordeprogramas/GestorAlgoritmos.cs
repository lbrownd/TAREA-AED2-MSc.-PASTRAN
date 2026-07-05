using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaClinicaForms
{
    public class NodoPacienteOrdenamiento
    {
        public int NumFicha { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        public NodoPacienteOrdenamiento(int numFicha, string nombre, string especialidad)

        {
            NumFicha = numFicha;
            Nombre = nombre;
            Especialidad = especialidad;
        }
    }

    public class GestorAlgoritmos
    {
        private const string ArchivoRuta = "pacientes_externos.txt";

        // 1. Metodo Burbuja
        public void OrdenarBurbuja(List<NodoPaciente> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j].NumFicha > lista[j + 1].NumFicha)
                    {
                        var temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }

        // 2. Metodo Quicksort
        public void OrdenarQuicksort(List<NodoPaciente> lista, int bajo, int alto)
        {
            if (bajo < alto)
            {
                int indicePivote = Particionar(lista, bajo, alto);
                OrdenarQuicksort(lista, bajo, indicePivote - 1);
                OrdenarQuicksort(lista, indicePivote + 1, alto);
            }
        }

        private int Particionar(List<NodoPaciente> lista, int bajo, int alto)
        {
            int pivote = lista[alto].NumFicha;
            int i = (bajo - 1);

            for (int j = bajo; j < alto; j++)
            {
                if (lista[j].NumFicha < pivote)
                {
                    i++;
                    var temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            var temp2 = lista[i + 1];
            lista[i + 1] = lista[alto];
            lista[alto] = temp2;

            return i + 1;
        }

        // 3. Ordenamiento Externo
        public List<NodoPaciente> OrdenarExterno(List<NodoPaciente> listaActual)
        {
            GuardarEnArchivoExterno(listaActual);
            if (!File.Exists(ArchivoRuta)) return new List<NodoPaciente>();

            List<NodoPaciente> bloque1 = new List<NodoPaciente>();
            List<NodoPaciente> bloque2 = new List<NodoPaciente>();

            string[] lineas = File.ReadAllLines(ArchivoRuta);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(',');
                if (datos.Length == 3)
                {
                    var p = new NodoPaciente(int.Parse(datos[0]), datos[1], datos[2]);
                    if (i < 3) bloque1.Add(p);
                    else bloque2.Add(p);
                }
            }

            OrdenarQuicksort(bloque1, 0, bloque1.Count - 1);
            OrdenarQuicksort(bloque2, 0, bloque2.Count - 1);

            List<NodoPaciente> listaMezcladaFinal = new List<NodoPaciente>();
            int idx1 = 0, idx2 = 0;

            while (idx1 < bloque1.Count && idx2 < bloque2.Count)
            {
                if (bloque1[idx1].NumFicha <= bloque2[idx2].NumFicha)
                {
                    listaMezcladaFinal.Add(bloque1[idx1]);
                    idx1++;
                }
                else
                {
                    listaMezcladaFinal.Add(bloque2[idx2]);
                    idx2++;
                }
            }

            while (idx1 < bloque1.Count) { listaMezcladaFinal.Add(bloque1[idx1]); idx1++; }
            while (idx2 < bloque2.Count) { listaMezcladaFinal.Add(bloque2[idx2]); idx2++; }

            GuardarEnArchivoExterno(listaMezcladaFinal);
            return listaMezcladaFinal;
        }


        // ============================================================
        //  METODOS DE BÚSQUEDA 
        // ============================================================

        // 1. Busqueda Secuencial o Lineal
        public NodoPaciente BusquedaSecuencial(List<NodoPaciente> lista, int fichaBuscar)
        {
            foreach (var paciente in lista)
            {
                if (paciente.NumFicha == fichaBuscar)
                    return paciente;
            }
            return null;
        }

        // 2. Búsqueda Binaria
        public NodoPaciente BusquedaBinaria(List<NodoPaciente> lista, int fichaBuscar)
        {
            int inicio = 0;
            int fin = lista.Count - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                if (lista[medio].NumFicha == fichaBuscar)
                    return lista[medio];

                if (lista[medio].NumFicha < fichaBuscar)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
            return null;
        }

        // 3. BUSQUEDA EXTERNA (Archivo)
        public NodoPaciente BusquedaExterna(int fichaBuscar)
        {
            if (!File.Exists(ArchivoRuta)) return null;

            using (StreamReader sr = new StreamReader(ArchivoRuta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length == 3)
                    {
                        int ficha = int.Parse(datos[0]);
                        if (ficha == fichaBuscar)
                        {
                            return new NodoPaciente(ficha, datos[1], datos[2]);
                        }
                    }
                }
            }
            return null;
        }

        // Con esto guardamos datos en txt
        public void GuardarEnArchivoExterno(List<NodoPaciente> lista)
        {
            using (StreamWriter sw = new StreamWriter(ArchivoRuta, false))
            {
                foreach (var p in lista)
                {
                    sw.WriteLine($"{p.NumFicha},{p.Nombre},{p.Especialidad}");
                }
            }
        }
    }
}