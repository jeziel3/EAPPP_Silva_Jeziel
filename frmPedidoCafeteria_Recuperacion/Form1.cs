
/*
 * ============================================================================
 * ESCUELA POLITÉCNICA NACIONAL
 * Asignatura: Diseño y Programación de Software
 * Evaluación: Examen Práctico - Primer Parcial (Recuperación)
 * Proyecto: Gestor Rápido de Pedidos con Catálogo - Cafetería Universitaria
 * Autor: Jeremyn Jeziel Silva Caiza
 * Fecha: 24 Noviembre 2026
 * ============================================================================
 */

using System.Globalization;
//Permite el uso de puntos o comas 
using System.Collections.Generic;
using System.Windows.Forms;

namespace frmPedidoCafeteria_Recuperacion
{
    public partial class Form1 : Form
    {
        // Constantes de recargos y extras según reglas de negocio
        private const decimal RECARGO_ENTREGA = 0.50m;
        private const decimal EXTRA_POSTRE = 1.00m;

        // Variable auxiliar para almacenar el precio unitario del producto seleccionado
        private decimal precioSeleccionadoActual = 0.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verificacion que nos permite saber si ya se escogio 
            if (lvCatalogo.SelectedItems.Count > 0)
            {
                //Como se configuro solo un producto a la vez toma el valor, solo tomara en cuenta ese valor. 
                ListViewItem fila = lvCatalogo.SelectedItems[0];
                string nombreProducto = fila.Text;
                //Com antes guardamos en la variable en Tag ya podemos extraer el valor 
                precioSeleccionadoActual = (decimal)fila.Tag;

                //De esta forma logramos que se muestre el nombre del producto 
                txtProducto.Text = nombreProducto;
                ValidarHabilitacionAgregar();

                lblEstado.Text = $"Estado: Producto seleccionado : {nombreProducto} (${precioSeleccionadoActual.ToString("0.00", CultureInfo.InvariantCulture)}).";
            }
            else
            {
                txtProducto.Clear();
                precioSeleccionadoActual = 0.00m;
                btnAgregar.Enabled = false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarHabilitacionAgregar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar de las propiedades que vamos a usar
            // Propiedades que nos permiten hacer uso de las columnas en lugar LargeIcon
            lvCatalogo.View = View.Details;
            //Permite seleccionar toda la fila
            lvCatalogo.FullRowSelect = true;

            lvCatalogo.GridLines = true;
            lvCatalogo.MultiSelect = false;
            //Cada vez que se ejecute borra valores anteriores
            lvCatalogo.Columns.Clear();
            // Metodos para agregar la columna 
            lvCatalogo.Columns.Add("Producto", 180);
            lvCatalogo.Columns.Add("Precio", 80);

            // Precarga oficial de los 10 productos 
            var productosCatalogo = new List<(string Nombre, decimal Precio)>
            {
                ("Empanada de queso", 1.25m),
                ("Sánduche de pollo", 2.50m),
                ("Bolón de verde mixto", 2.25m),
                ("Humita tradicional", 1.50m),
                ("Tostada con queso", 1.00m),
                ("Café pasado", 0.85m),
                ("Chocolate caliente", 1.35m),
                ("Jugo natural (naranja/mora)", 1.50m),
                ("Batido de fruta", 2.00m),
                ("Botella de agua", 0.75m)
            };


            //Limpia la vista Catalogo 

            lvCatalogo.Items.Clear();
            //foreach dentro de la lista creada con todos los productos
            foreach (var prod in productosCatalogo)
            {
                //Creamos una nueva lista que nos permita llenar la viesta 
                ListViewItem item = new ListViewItem(prod.Nombre);
                item.SubItems.Add("$" + prod.Precio.ToString("0.00", CultureInfo.InvariantCulture));
                // Guardamos el valor decimal exacto en Tag para evitar problemas de parseo
                item.Tag = prod.Precio;

                //Finalmente agregamos los elementos a la lista
                lvCatalogo.Items.Add(item);
            }

            // Configurar columnas y propiedades de lvPedido
            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;
            lvPedido.GridLines = true;
            lvPedido.MultiSelect = false;
            lvPedido.Columns.Clear();
            lvPedido.Columns.Add("Producto", 160);
            lvPedido.Columns.Add("Cant.", 55);
            lvPedido.Columns.Add("Subtotal", 85);

            // Estado inicial de controles
            txtProducto.ReadOnly = true;
            txtCantidad.Text = "1";
            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;
            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";




        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita btnQuitar únicamente si hay una fila seleccionada en el carrito
            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0;
        }

        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Nos permite transformar la variable y ademas verifica si se logro convertirla en entero , caso contrario devulve 
            //false 
            int cantidadValida;
            bool esNumero = int.TryParse(txtCantidad.Text.Trim(), out cantidadValida);

            if (esNumero == false || cantidadValida < 1)
            {
                e.Cancel = true;
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.Focus();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ValidarHabilitacionAgregar();
        }

        //Creamos una funcion para poder validar las condiciones en txtNombre y txtProdcuto 
        private void ValidarHabilitacionAgregar()

        {

            bool productoValido = false;
            bool cantidadValida = false;
            //Primera validacion sobre si no estavbacio o nulo el texto de producto
            if (!string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                productoValido = true;
            }

            //Mismo metodo para comprobar si hay un valor en txtCantidad
            int cant;
            bool esNumero = int.TryParse(txtCantidad.Text.Trim(), out cant);
            if (esNumero == true && cant >= 1)
            {
                cantidadValida = true;

            }


            btnAgregar.Enabled = productoValido && cantidadValida;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {


            lvPedido.Items.Clear();
            lvCatalogo.SelectedItems.Clear();
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Text = "1";
            precioSeleccionadoActual = 0.00m;

            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            ActualizarTotal();
            lblEstado.Text = "Estado: Pedido reiniciado.";
            txtCliente.Focus();


        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //Verificacion para saber si ya se escogio un producto
            if (lvPedido.SelectedItems.Count > 0)
            {
                //Toma la posicion seleccionada de nuestra nueva lista al tocar el producto
                string eliminado = lvPedido.SelectedItems[0].Text;
                //Remueve de la lista 
                lvPedido.Items.Remove(lvPedido.SelectedItems[0]);

                btnQuitar.Enabled = false;
                ActualizarTotal();
                lblEstado.Text = $"Estado: '{eliminado}' quitado del pedido.";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verificamos si esta vacio txtCliente
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente antes de agregar.";
                txtCliente.Focus();
                return;
            }
            //Igual con producto
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                lblEstado.Text = "Error: Seleccione un producto del catálogo.";
                return;
            }


            //Mismo metodo para verificar si se esocogio la cantidad 
            int cantidad;
            bool esNumero = int.TryParse(txtCantidad.Text.Trim(), out cantidad);

            if (esNumero == false || cantidad < 1)
            {
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.Focus();
            }

            //Imprimimos en la litsPedido
            string producto = txtProducto.Text;
            decimal subtotal = cantidad * precioSeleccionadoActual;

            //Creamos una nueva lista 
            ListViewItem itemPedido = new ListViewItem(producto);
            //Agregamos los elementos de la lista 
            itemPedido.SubItems.Add(cantidad.ToString());
            itemPedido.SubItems.Add("$" + subtotal.ToString("0.00", CultureInfo.InvariantCulture));
            itemPedido.Tag = subtotal;

            lvPedido.Items.Add(itemPedido);

            ActualizarTotal();
            txtCantidad.Text = "1";
            lblEstado.Text = $"Estado: '{producto}' agregado (Cant: {cantidad}, Subtotal: ${subtotal.ToString("0.00", CultureInfo.InvariantCulture)}).";
        }



        //Funcion principal del programa para calcular los precios 
        private void ActualizarTotal()
        {
            decimal sumaSubtotales = 0.00m;

            foreach (ListViewItem item in lvPedido.Items)
            {
                if (item.Tag is decimal sub)
                {
                    sumaSubtotales += sub;
                }
            }
            //Validaciones para sber si se selecciono las opciones y ponerle un valor. 
            //Si esta marcado permite realizar la suma, caso contrario no lo suma 
            decimal recargoEntrega = rbtnEntrega.Checked ? RECARGO_ENTREGA : 0.00m;
            decimal extraPostre = chkPostre.Checked ? EXTRA_POSTRE : 0.00m;
            //Guardamos todas las sumas de variables 
            decimal totalGeneral = sumaSubtotales + recargoEntrega + extraPostre;
            lblTotal.Text = "Total: $" + totalGeneral.ToString("0.00", CultureInfo.InvariantCulture);
        }

        //Super importante para realizar la suma gracias a esto el programa sabe si esta presionado o no las opciones 
        private void rbtnMostrador_CheckedChanged(object sender, EventArgs e)
        {
            //Al estar en el mismo group box son mutuamente excluyentes de esta forma comprobamos cual de las dos
            //opciones aplastamos
            ActualizarTotal();
            lblEstado.Text = rbtnEntrega.Checked
                ? "Opción aplicada: Entrega en aula (+$0.50)."
                : "Opción aplicada: Retiro en mostrador ($0.00).";
        }

    
        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            //Cada vez que se marca o desmarca salta el evento y se manda la opcion 
            ActualizarTotal();
            lblEstado.Text = chkPostre.Checked
                ? "Opción aplicada: Postre del día (+$1.00)."
                : "Opción removida: Postre del día.";
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            lblEstado.Text = chkServilletas.Checked
                ? "Opción aplicada: Servilletas / Cubiertos ($0.00)."
                : "Opción removida: Servilletas / Cubiertos.";
        }
    }
}
