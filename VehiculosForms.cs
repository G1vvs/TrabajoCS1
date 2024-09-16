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

namespace WinFormsApp1
{
    public partial class VehiculosForms : Form
    {
        string IdGlobal = "";
        public VehiculosForms()
        {
            InitializeComponent();
        }

        private void VehiculosForms_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Marca");
            listView1.Columns.Add("Modelo");
            listView1.Columns.Add("Año");
            listView1.Columns.Add("Kilometraje");
            listView1.Columns.Add("Precio");


            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                if (i == 0)
                {
                    listView1.Columns[i].Width = 0;
                }
                else
                {
                    listView1.Columns[i].Width = 100;
                }
            }
        }

        void Listar()
        {
            listView1.Items.Clear();
            foreach (Vehiculo vehiculo in GlobalVar.Inventario.Lista())
            {
                listView1.Items.Add(new ListViewItem(vehiculo.itemView()));
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tx_marca.Text))
            {
                MessageBox.Show("Debes ingresar la marca");
                tx_marca.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_modelo.Text))
            {
                MessageBox.Show("Debes ingresar el modelo");
                tx_modelo.Focus();
                return;
            }


            int Año;

            bool isOk1 = int.TryParse(tx_año.Text, out Año);
            if (!isOk1)
            {
                MessageBox.Show("Debes ingresar el año del vehiculo");
                tx_año.Focus();
                return;
            }
            int Kil;

            bool isOk2 = int.TryParse(tx_km.Text, out Kil);
            if (!isOk2)
            {
                MessageBox.Show("Debes ingresar el kilometraje del vehiculo");
                tx_km.Focus();
                return;
            }


            decimal Precio;

            bool isOk = decimal.TryParse(tx.Text, out Precio);
            if (!isOk)
            {
                MessageBox.Show("Ingrese precio valido");
                tx.Focus();
                return;
            }

            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = tx_marca.Text,
                Modelo = tx_modelo.Text,
                Año = Año,
                Kilometraje = Kil,
                Precio = Precio
            };
            if (String.IsNullOrEmpty(IdGlobal))
            {
                GlobalVar.Inventario.AgregarVehiculo(vehiculo);
                MessageBox.Show("Cliente Almacenado");

            }
            else
            {
                Vehiculo veh_modificar = GlobalVar.Inventario.Lista().Where(x => x.Id == IdGlobal).FirstOrDefault()!;
                veh_modificar.Marca = tx_marca.Text;
                veh_modificar.Modelo = tx_modelo.Text;
                veh_modificar.Año = Convert.ToInt32(tx_año.Text);
                veh_modificar.Kilometraje = Convert.ToInt32(tx_km.Text);
                veh_modificar.Precio = Convert.ToDecimal(tx.Text);
                IdGlobal = "";
            }

            Listar();

        }


        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].Text;
            Vehiculo ve_eliminar = GlobalVar.Inventario.Lista().Where(x => x.Id == id).FirstOrDefault()!;
            GlobalVar.Inventario.EliminarVehiculo(ve_eliminar);
            Listar();
            MessageBox.Show("Elemento eliminado");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String id = listView1.SelectedItems[0].Text;
            IdGlobal = id;
            Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().FirstOrDefault(v => v.Id == id)!;
            tx_marca.Text = vehiculo_modificar.Marca;
            tx_modelo.Text = vehiculo_modificar.Modelo;
            tx_año.Text = Convert.ToString(vehiculo_modificar.Año);
            tx_km.Text = Convert.ToString(vehiculo_modificar.Kilometraje);
            tx.Text = Convert.ToString(vehiculo_modificar.Precio);
           
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
                e.NewWidth = 0;
            }
        }
    }
}   
