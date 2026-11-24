namespace frmPedidoCafeteria
{
    public partial class Form1 : Form
    {
        double precioSeleccionado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo2_Click(object sender, EventArgs e)
        {

        }

        private void grpModalidad_Enter(object sender, EventArgs e)
        {

        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {

            // Configurar lvCatalogo
            lvCatalogo.View = View.Details;
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.GridLines = true;

            lvCatalogo.Columns.Clear();
            lvCatalogo.Columns.Add("Producto", 150);
            lvCatalogo.Columns.Add("Precio", 100);

            // Cargar los productos
            lvCatalogo.Items.Clear();

            //Poroductos
            string[,] productos = {
                 {"Empanada de queso ", "$1.25"},
                {"Sánduche de pollo", "$2.50"},
                {"Bolón de verde mixto ", "$2.25"},
                {"Humita tradicional ", "$1.50"},
                {"Tostada con queso ", "$1.00"},
                {"Café pasado ", "$0.85 "},
                {"Chocolate caliente", "$1.35 "},
                {"Jugo natural (naranja/mora)", "$1.50 "},
                {"Batido de fruta ", "$2.00 "},
                {"Botella de agua ", "$0.75"}
    };

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(productos[i, 0]);
                item.SubItems.Add(productos[i, 1]);
                lvCatalogo.Items.Add(item);
            }

            //LVL pedido configuracion 
            lvPedido.View = View.Details;
            lvPedido.FullRowSelect = true;
            lvPedido.GridLines = true;

            lvPedido.Columns.Clear();
            lvPedido.Columns.Add("Producto", 150);
            lvPedido.Columns.Add("Cant.", 60);
            lvPedido.Columns.Add("Subtotal", 60);

            // Valores iniciales que se deben configurar al inicio de la carga 
            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilleta.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int cantidadValida = int.Parse(txtCantidad.Text);
            if (cantidadValida < 1)
            {
                e.Cancel = true;
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual 1.";
                txtCantidad.Focus();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
