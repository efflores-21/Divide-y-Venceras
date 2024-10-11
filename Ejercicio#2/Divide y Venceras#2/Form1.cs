using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divide_y_Venceras_2
{
    public partial class Form1 : Form
    {
        List<Producto> inventario = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto(txtCodigo.Text, txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
            inventario.Add(nuevoProducto);
            MessageBox.Show("Producto agregado.");
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            Producto producto = inventario.Find(p => p.Codigo == codigo);
            if (producto != null)
            {
                inventario.Remove(producto);
                MessageBox.Show("Producto eliminado.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            Producto producto = inventario.Find(p => p.Codigo == codigo);
            if (producto != null)
            {
                producto.Nombre = txtNombre.Text;
                producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                producto.Precio = Convert.ToDouble(txtPrecio.Text);
                MessageBox.Show("Producto modificado.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            Producto producto = inventario.Find(p => p.Codigo == codigo);
            if (producto != null)
            {
                MessageBox.Show($"Código: {producto.Codigo}\nNombre: {producto.Nombre}\nCantidad: {producto.Cantidad}\nPrecio: {producto.Precio}");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            string listaProductos = "";
            foreach (var producto in inventario)
            {
                listaProductos += $"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Cantidad: {producto.Cantidad}, Precio: {producto.Precio}\n";
            }
            MessageBox.Show(listaProductos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public Producto(string codigo, string nombre, int cantidad, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}

