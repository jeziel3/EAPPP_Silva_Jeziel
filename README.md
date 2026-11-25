# Gestor Rápido de Pedidos con Catálogo - Cafetería Universitaria

## 1. Datos del Estudiante y Asignatura
* **Estudiante:** Jeremyn Jeziel Silva Caiza
* **Institución:** Escuela Politécnica Nacional (EPN)
* **Asignatura:** ITID 543 - Diseño y Programación de Software
* **Docente:** Ing. Jose Naranjo
* **Evaluación:** Examen Práctico Acumulativo - Primer Parcial (Recuperación)

## 2. Instrucciones de Ejecución
1. Clonar este repositorio público:
   ```bash
   git clone https://github.com/jeziel3/EAPPP_Silva_Jeremyn.gitgit clone [https://github.com/jeziel3/EAPPP_Silva_Jeremyn.git](https://github.com/jeziel3/EAPPP_Silva_Jeremyn.git)
** Abrir el archivo de solución (.sln) en Visual Studio 2022 / 2026.
** Compilar y ejecutar la aplicación presionando F5 (o mediante el botón Iniciar).
** Eventos Implementados (6/6)
Load (Form1_Load):
 Configura las columnas de lvCatalogo y lvPedido en vista Details, precarga los 10 productos oficiales con sus precios unitarios e inicializa los controles del formulario.
SelectedIndexChanged (listView1_SelectedIndexChanged, lvPedido_SelectedIndexChanged):
 Carga en txtProducto el producto seleccionado del catálogo junto con su precio real almacenado en Tag, y habilita o deshabilita btnQuitar según la selección en lvPedido.
Validating (txtCantidad_Validating): 
Valida mediante int.TryParse que la cantidad ingresada sea un número entero ≥1 antes de abandonar el campo, cancelando el foco (e.Cancel = true) y seleccionando el texto (SelectAll()) si es inválido.
TextChanged (txtCantidad_TextChanged, txtProducto_TextChanged):
 Evalúa en tiempo real que exista un producto seleccionado y una cantidad válida (≥1) para habilitar btnAgregar.
CheckedChanged (rbtnEntrega_CheckedChanged, chkPostre_CheckedChanged, chkServilletas_CheckedChanged):
 Recalcula el total general en tiempo real al activar o desactivar recargos/extras y notifica el estado en lblEstado.
Click (btnAgregar_Click, btnQuitar_Click, btnLimpiar_Click): 
Valida el nombre del cliente, agrega ítems calculando su subtotal, elimina filas seleccionadas y reinicia por completo el formulario.
