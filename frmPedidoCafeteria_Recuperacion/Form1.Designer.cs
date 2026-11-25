namespace frmPedidoCafeteria_Recuperacion
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
           
            lblCliente = new Label();
            lblProducto = new Label();
            lblTitulo = new Label();
            lblCatalogo = new Label();
            lblCantidad = new Label();
            lblPedido = new Label();
            lvCatalogo = new ListView();
            lvPedido = new ListView();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            grpModalidad = new GroupBox();
            rbtnMostrador = new RadioButton();
            rbtnEntrega = new RadioButton();
            grpExtras = new GroupBox();
            chkPostre = new CheckBox();
            chkServilletas = new CheckBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnLimpiar = new Button();
            lblEstado = new Label();
            lblTotal = new Label();
            txtCantidad = new TextBox();
            grpModalidad.SuspendLayout();
            grpExtras.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(245, 122);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(80, 21);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Producto: ";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(245, 84);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(71, 21);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(603, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestor Rapido de Pedidos con Catalogo - Cafeteria Universitaria";
            // 
            // lblCatalogo
            // 
            lblCatalogo.AutoSize = true;
            lblCatalogo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatalogo.Location = new Point(12, 84);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(174, 21);
            lblCatalogo.TabIndex = 1;
            lblCatalogo.Text = "Catalogo de Productos: ";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(483, 122);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(49, 21);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cant: ";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(599, 84);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(148, 21);
            lblPedido.TabIndex = 5;
            lblPedido.Text = "Detalles del Pedido: ";
            // 
            // lvCatalogo
            // 
            lvCatalogo.Location = new Point(12, 122);
            lvCatalogo.Name = "lvCatalogo";
            lvCatalogo.Size = new Size(218, 264);
            lvCatalogo.TabIndex = 6;
            lvCatalogo.UseCompatibleStateImageBehavior = false;
            lvCatalogo.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lvPedido
            // 
            lvPedido.Location = new Point(599, 122);
            lvPedido.Name = "lvPedido";
            lvPedido.Size = new Size(209, 264);
            lvPedido.TabIndex = 7;
            lvPedido.UseCompatibleStateImageBehavior = false;
            lvPedido.SelectedIndexChanged += lvPedido_SelectedIndexChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(322, 86);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(259, 23);
            txtCliente.TabIndex = 8;
            txtCliente.TextChanged += txtNombre_TextChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(322, 124);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(155, 23);
            txtProducto.TabIndex = 10;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // grpModalidad
            // 
            grpModalidad.BackColor = Color.White;
            grpModalidad.Controls.Add(rbtnMostrador);
            grpModalidad.Controls.Add(rbtnEntrega);
            grpModalidad.Location = new Point(245, 176);
            grpModalidad.Name = "grpModalidad";
            grpModalidad.Size = new Size(336, 71);
            grpModalidad.TabIndex = 11;
            grpModalidad.TabStop = false;
            grpModalidad.Text = "Modalidad de Atencion: ";
            // 
            // rbtnMostrador
            // 
            rbtnMostrador.AutoSize = true;
            rbtnMostrador.Location = new Point(17, 33);
            rbtnMostrador.Name = "rbtnMostrador";
            rbtnMostrador.Size = new Size(123, 19);
            rbtnMostrador.TabIndex = 13;
            rbtnMostrador.TabStop = true;
            rbtnMostrador.Text = "Entrega Mostrador";
            rbtnMostrador.UseVisualStyleBackColor = true;
            rbtnMostrador.CheckedChanged += rbtnMostrador_CheckedChanged;
            // 
            // rbtnEntrega
            // 
            rbtnEntrega.AutoSize = true;
            rbtnEntrega.Location = new Point(151, 33);
            rbtnEntrega.Name = "rbtnEntrega";
            rbtnEntrega.Size = new Size(138, 19);
            rbtnEntrega.TabIndex = 14;
            rbtnEntrega.TabStop = true;
            rbtnEntrega.Text = "Entrega Aula (+$0.50)";
            rbtnEntrega.UseVisualStyleBackColor = true;
       
            // 
            // grpExtras
            // 
            grpExtras.BackColor = Color.White;
            grpExtras.Controls.Add(chkPostre);
            grpExtras.Controls.Add(chkServilletas);
            grpExtras.Location = new Point(245, 267);
            grpExtras.Name = "grpExtras";
            grpExtras.Size = new Size(336, 73);
            grpExtras.TabIndex = 12;
            grpExtras.TabStop = false;
            grpExtras.Text = "Extras del Pedido: ";
            // 
            // chkPostre
            // 
            chkPostre.AutoSize = true;
            chkPostre.Location = new Point(17, 36);
            chkPostre.Name = "chkPostre";
            chkPostre.Size = new Size(143, 19);
            chkPostre.TabIndex = 16;
            chkPostre.Text = "Postre del dia (+$1.00)";
            chkPostre.UseVisualStyleBackColor = true;
            chkPostre.CheckedChanged += chkPostre_CheckedChanged;
            // 
            // chkServilletas
            // 
            chkServilletas.AutoSize = true;
            chkServilletas.Location = new Point(195, 36);
            chkServilletas.Name = "chkServilletas";
            chkServilletas.Size = new Size(134, 19);
            chkServilletas.TabIndex = 15;
            chkServilletas.Text = "Servilletas/Cubiertos";
            chkServilletas.UseVisualStyleBackColor = true;
            chkServilletas.CheckedChanged += chkServilletas_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Location = new Point(250, 363);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.Firebrick;
            btnQuitar.Location = new Point(370, 363);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(75, 23);
            btnQuitar.TabIndex = 14;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(506, 363);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(12, 418);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(225, 21);
            lblEstado.TabIndex = 17;
            lblEstado.Text = "Estado: Seleccione un producto";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(719, 418);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(89, 21);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total $ 0.00";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(528, 124);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(53, 23);
            txtCantidad.TabIndex = 9;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Validating += txtCantidad_Validating;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(820, 484);
            Controls.Add(lblTotal);
            Controls.Add(lblEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(grpExtras);
            Controls.Add(grpModalidad);
            Controls.Add(txtProducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtCliente);
            Controls.Add(lvPedido);
            Controls.Add(lvCatalogo);
            Controls.Add(lblPedido);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblCliente);
            Controls.Add(lblCatalogo);
            Controls.Add(lblTitulo);
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

        private Label lblTitulo;
        private Label lblCatalogo;
        private Label lblCliente;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPedido;
        private ListView lvCatalogo;
        private ListView lvPedido;
        private TextBox txtCliente;
        private TextBox txtCantidad;
        private TextBox txtProducto;
        private GroupBox grpModalidad;
        private RadioButton rbtnMostrador;
        private RadioButton rbtnEntrega;
        private GroupBox grpExtras;
        private CheckBox chkServilletas;
        private CheckBox chkPostre;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
    }
}
