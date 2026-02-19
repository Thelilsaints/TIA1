using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA1
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            rtbAyuda.Text =
                "Bienvenido al sistema de gestión.\n\n" +
                "Uso básico:\n" +
                "- Para registrar clientes, dirígete al menú 'Clientes'.\n" +
                "- Para administrar productos, utiliza el menú 'Productos'.\n" +
                "- Los informes se generan desde el menú 'Informes'.\n\n" +
                "Consejos:\n" +
                "- Guarda tu trabajo frecuentemente.\n" +
                "- Usa las opciones de seguridad para proteger tu información.";

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            trvIndice.Nodes.Add("Clientes");
            trvIndice.Nodes.Add("Productos");
            trvIndice.Nodes.Add("Categorías");
            trvIndice.Nodes.Add("Facturas");
            trvIndice.Nodes.Add("Informes");
            trvIndice.Nodes.Add("Seguridad");
            trvIndice.Nodes.Add("Roles");
            trvIndice.Nodes.Add("Empleados");
            trvIndice.Nodes.Add("Ayuda");
            trvIndice.Nodes.Add("Acerca de");

            switch (e.Node.Text)
            {
                case "Clientes": rtbAyuda.Text = "En este módulo puedes registrar, editar y eliminar clientes..."; break;
                case "Productos": rtbAyuda.Text = "Aquí gestionas los productos, precios y stock..."; break;
                case "Informes": rtbAyuda.Text = "Genera reportes de ventas, clientes y productos..."; break; // Agregar más casos según los temas }

            }
        }
    }
}
