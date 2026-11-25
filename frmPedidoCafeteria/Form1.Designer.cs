namespace frmPedidoCafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_titulo = new Label();
            lbl_titulo2 = new Label();
            lblCliente = new Label();
            lblProducto = new Label();
            textBox1 = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            grpModalidad = new GroupBox();
            rbtnMostrador = new RadioButton();
            rbtnEntrega = new RadioButton();
            grpExtras = new GroupBox();
            chkServilleta = new CheckBox();
            chkPostre = new CheckBox();
            lvPedido = new ListView();
            lvCatalogo = new ListView();
            Nombre = new ColumnHeader();
            Precio = new ColumnHeader();
            lblPedido = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnQuitar = new Button();
            lblEstado = new Label();
            colorDialog1 = new ColorDialog();
            grpModalidad.SuspendLayout();
            grpExtras.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(12, 21);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(603, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Gestor Rapido de Pedidos con Catalogo - Cafeteria Universitaria";
            lbl_titulo.Click += lbl_titulo_Click;
            // 
            // lbl_titulo2
            // 
            lbl_titulo2.AutoSize = true;
            lbl_titulo2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo2.Location = new Point(12, 88);
            lbl_titulo2.Name = "lbl_titulo2";
            lbl_titulo2.Size = new Size(164, 20);
            lbl_titulo2.TabIndex = 2;
            lbl_titulo2.Text = "Catalogo de Productos:";
            lbl_titulo2.Click += lbl_titulo2_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(232, 88);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(232, 121);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(299, 121);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(128, 23);
            txtProducto.TabIndex = 6;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(481, 121);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(32, 23);
            txtCantidad.TabIndex = 7;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Validating += txtCantidad_Validating;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(440, 124);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(35, 15);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cant:";
            // 
            // grpModalidad
            // 
            grpModalidad.BackColor = SystemColors.Window;
            grpModalidad.Controls.Add(rbtnMostrador);
            grpModalidad.Controls.Add(rbtnEntrega);
            grpModalidad.Location = new Point(232, 164);
            grpModalidad.Name = "grpModalidad";
            grpModalidad.Size = new Size(281, 79);
            grpModalidad.TabIndex = 9;
            grpModalidad.TabStop = false;
            grpModalidad.Text = "Modalidad Atencion:";
            grpModalidad.Enter += grpModalidad_Enter;
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Location = new Point(17, 37);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(80, 19);
            rbtnMostrador.TabIndex = 11;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(117, 37);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(166, 19);
            rbtnEntrega.TabIndex = 12;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = " Entrega Aula (+0.50 cntvs)";
            rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // grpExtras
            // 
            grpExtras.BackColor = SystemColors.Window;
            grpExtras.Controls.Add(chkServilleta);
            grpExtras.Controls.Add(chkPostre);
            grpExtras.Location = new Point(232, 263);
            grpExtras.Name = "grpExtras";
            grpExtras.Size = new Size(281, 89);
            grpExtras.TabIndex = 13;
            grpExtras.TabStop = false;
            grpExtras.Text = "Extras de pedido:";
            // 
            // chkServilleta
            // 
            chkServilleta.AutoSize = true;
            chkServilleta.Location = new Point(148, 44);
            chkServilleta.Name = "chkServilleta";
            chkServilleta.Size = new Size(129, 19);
            chkServilleta.TabIndex = 1;
            chkServilleta.Text = "Servilleta/Cubiertos";
            chkServilleta.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(15, 44);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(128, 19);
            chkPostre.TabIndex = 0;
            chkPostre.Text = "Postre del dia (+1$)";
            chkPostre.UseVisualStyleBackColor = true;
            chkPostre.CheckedChanged += chkPostre_CheckedChanged;
            // 
            // lvPedido
            // 
            lvPedido.Location = new Point(540, 112);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(217, 318);
            lvPedido.TabIndex = 14;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lvCatalogo
            // 
            lvCatalogo.Columns.AddRange(new ColumnHeader[] { Nombre, Precio });
            lvCatalogo.FullRowSelect = true;
            lvCatalogo.Location = new Point(12, 111);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(199, 319);
            lvCatalogo.TabIndex = 15;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.View = View.Details;
            lvCatalogo.SelectedIndexChanged += lvCatalogo_SelectedIndexChanged;
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(540, 88);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(112, 21);
            lblPedido.TabIndex = 16;
            lblPedido.Text = "Detalle Pedido:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.CadetBlue;
            lblTotal.Location = new Point(639, 433);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 30);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total 0.00 $";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Chartreuse;
            btnAgregar.Location = new Point(247, 386);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(434, 386);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.Crimson;
            btnQuitar.Location = new Point(339, 386);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 20;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(26, 470);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(173, 15);
            lblEstado.TabIndex = 21;
            lblEstado.Text = "Estado: Seleccione un producto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 526);
            Controls.Add(lblEstado);
            Controls.Add(btnQuitar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(lblPedido);
            Controls.Add(lvCatalogo);
            Controls.Add(lvPedido);
            Controls.Add(grpExtras);
            Controls.Add(grpModalidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(textBox1);
            Controls.Add(lblProducto);
            Controls.Add(lblCliente);
            Controls.Add(lbl_titulo2);
            Controls.Add(lbl_titulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpModalidad.ResumeLayout(false);
            grpModalidad.PerformLayout();
            grpExtras.ResumeLayout(false);
            grpExtras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_titulo2;
        private Label lblCliente;
        private Label lblProducto;
        private TextBox textBox1;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private GroupBox grpModalidad;
        private RadioButton rbtnMostrador;
        private RadioButton rbtnEntrega;
        private GroupBox grpExtras;
        private CheckBox chkServilleta;
        private CheckBox chkPostre;
        private ListView lvPedido;
        private ListView lvCatalogo;
        private Label lblPedido;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnLimpiar
            ;
        private Button btnQuitar;
        private Label lblEstado;
        private ColumnHeader Nombre;
        private ColumnHeader Precio;
        private ColorDialog colorDialog1;
    }
}
