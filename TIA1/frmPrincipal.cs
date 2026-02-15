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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
             
            clientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            productos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            categorias.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            facturas.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            facturas.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            informes.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            informes.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            empleados.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles roles = new frmRoles();
            roles.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            roles.Show();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSeguridad seguridad = new frmSeguridad();
            seguridad.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            seguridad.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            ayuda.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            acercaDe.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            acercaDe.Show();
        }
    }
}
