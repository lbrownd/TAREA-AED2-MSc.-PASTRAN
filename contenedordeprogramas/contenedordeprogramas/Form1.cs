global using System;
global using System.Collections.Generic;
global using System.Drawing;
global using System.IO;
global using System.Linq;
global using System.Net.Http;
global using System.Threading;
global using System.Threading.Tasks;
global using System.Windows.Forms;
global using SistemaClinicaForms;

namespace contenedordeprogramas;

public partial class contenedorFrm : Form
{
    public contenedorFrm()
    {
        InitializeComponent();
        this.IsMdiContainer = true;
        ConfigurarFondoMdi();
    }

    private void toolStripBtnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void toolStripBtnBB_Click(object sender, EventArgs e)
    {
        /*   Form1 SCliForm = new Form1();
           SCliForm.Show();*/

        //if (Application.OpenForms["Form1"] == null)
        if (Application.OpenForms["Form1"] == null)
        {
            Form1 programa = new Form1();
            programa.Show();
        }
        else
        {
            // Si ya está abierto, solo lo trae al frente
            Application.OpenForms["Form1"].BringToFront();
        }
    }

    private void toolStripBtnOrdenamientos_Click(object sender, EventArgs e)
    {
        if (Application.OpenForms["Form2"] == null)
        {
            Form2 programa2 = new Form2();

            programa2.Show();
        }
        else
        {
            // Si ya está abierto, solo lo trae al frente
            Application.OpenForms["Form2"].BringToFront();
            //  Form2.MdiParent = this;
        }

    }


    private void ConfigurarFondoMdi()
    {
        // Buscamos el control MdiClient oculto dentro del formulario
        foreach (Control control in this.Controls)
        {
            if (control is MdiClient mdiClient)
            {
                // 1. Asignamos la imagen PNG desde los Recursos del proyecto
                mdiClient.BackgroundImage = Properties.Resources.HFVP2;

                // 2. Centramos la imagen para que conserve su resolución real y no se deforme
                mdiClient.BackgroundImageLayout = ImageLayout.Stretch;


                break;
            }
        }
    }

    private void contenedorFrm_Load(object sender, EventArgs e)
    {

    }
}

