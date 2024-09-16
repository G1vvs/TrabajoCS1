using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        void ListarV()
        {
            listView1.Items.Clear();
            foreach(Venta ventas1 in GlobalVar.concesionario.Lista())
            {
                listView1.Items.Add(new ListViewItem(ventas1.itemView1()));
            }
        }

        void cargaClientes()
        {
            cb_clientes.Items.AddRange(GlobalVar.clientes.ToArray());
            
        }

        void cargaVehiculos()
        {
            cb_vehiculo.Items.AddRange(GlobalVar.Inventario.Lista().ToArray());

        }

        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;
            tx_precio.Text = vehiculoSeleccionado.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cb_clientes.Text))
            {
                MessageBox.Show("Debes ingresar el modelo");
                cb_clientes.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cb_vehiculo.Text))
            {
                MessageBox.Show("Debes ingresar el modelo");
                cb_vehiculo.Focus();
                return;
            }
            decimal Precio;

            bool isOk = decimal.TryParse(tx_precio.Text, out Precio);
            if (!isOk)
            {
                MessageBox.Show("Ingrese precio valido");
                tx_precio.Focus();
                return;
            }

            Cliente clienteSeleccionado = cb_clientes.SelectedItem as Cliente;

            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;

            GlobalVar.concesionario
                .RegistrarVenta(vehiculoSeleccionado, clienteSeleccionado);

            ListarV();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Cliente");
            listView1.Columns.Add("Modelo");
            listView1.Columns.Add("Precio");
            listView1.Columns.Add("Fecha");
            cargaClientes();
            cargaVehiculos();
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = 100;
            }
        }
    }
}
