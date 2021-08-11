namespace Producto
{
    partial class FrmProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIngreso = new System.Windows.Forms.Label();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblEmpaquetado = new System.Windows.Forms.Label();
            this.dtEmpaquetado = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(292, 20);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(89, 13);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Fecha de ingreso";
            // 
            // dtIngreso
            // 
            this.dtIngreso.Location = new System.Drawing.Point(292, 48);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtIngreso.TabIndex = 1;
            // 
            // lblEmpaquetado
            // 
            this.lblEmpaquetado.AutoSize = true;
            this.lblEmpaquetado.Location = new System.Drawing.Point(292, 83);
            this.lblEmpaquetado.Name = "lblEmpaquetado";
            this.lblEmpaquetado.Size = new System.Drawing.Size(121, 13);
            this.lblEmpaquetado.TabIndex = 2;
            this.lblEmpaquetado.Text = "Fecha de Empaquetado";
            // 
            // dtEmpaquetado
            // 
            this.dtEmpaquetado.Location = new System.Drawing.Point(292, 111);
            this.dtEmpaquetado.Name = "dtEmpaquetado";
            this.dtEmpaquetado.Size = new System.Drawing.Size(200, 20);
            this.dtEmpaquetado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Vencimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Location = new System.Drawing.Point(292, 170);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtVencimiento.TabIndex = 5;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(540, 51);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 6;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(540, 110);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(707, 51);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(707, 110);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(121, 20);
            this.txtExistencia.TabIndex = 10;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(707, 23);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(540, 84);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado del Producto";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(540, 23);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad en Existencia";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(146, 102);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 38);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar Detalle";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(14, 102);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(111, 38);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Acrtualizar Detalles";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 38);
            this.button4.TabIndex = 16;
            this.button4.Text = "Actualizar grid de datos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(14, 58);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 38);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar Detalle del Producto";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Limpiar campos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.dtVencimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEmpaquetado);
            this.Controls.Add(this.lblEmpaquetado);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Name = "FrmProducto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.Label lblEmpaquetado;
        private System.Windows.Forms.DateTimePicker dtEmpaquetado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

