using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ControllerLinq cl = new ControllerLinq();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Filtrar_Click(object sender, EventArgs e)
        {
            string filtro = txt_filtro.Text;
            var clientes = cl.FiltroCliente(filtro);

            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = clientes;
        }

        private void bt_Maiusculo_Click(object sender, EventArgs e)

        {
            var dataSource = cl.clientes.Select(c => new { Id = c.Id, Nome = c.Nome.ToUpper(), Email = c.Email}).ToList();

            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = dataSource;

        }

        private void bt_agrupar_Click(object sender, EventArgs e)
        {
            

            var dataSource = cl.clientes.Select(c => new { Inicial = c.Nome[0], Nome = c.Nome}).OrderBy(c => c.Inicial).ThenBy(c => c.Nome).ToList();

            dgv_clientes.DataSource = null; 
            dgv_clientes.DataSource = dataSource;
        }
    }
}
