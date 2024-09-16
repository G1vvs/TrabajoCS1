using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoCV.clases
{
    public class Venta
    {
        public Vehiculo VehiculoVendido { get; set; }
        public Cliente Cliente { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }

        public void MostrarDetalleVenta()
        {
            Console.WriteLine($"{FechaVenta} : {Cliente.Nombre} {Cliente.Apellidos} " +
                $"compró {VehiculoVendido.Marca} en ${PrecioVenta} ");
        }
        public string[] itemView1()
        {
            string[] data = {Cliente.Nombre, 
                VehiculoVendido.Modelo,
                    Convert.ToString(PrecioVenta),
                Convert.ToString(FechaVenta) };
            return data;
        }
    }
}
