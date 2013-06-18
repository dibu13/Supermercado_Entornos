namespace supermarket
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.Datos_Usuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.T_Direc = new System.Windows.Forms.TextBox();
            this.T_Email = new System.Windows.Forms.TextBox();
            this.T_Nombre = new System.Windows.Forms.TextBox();
            this.T_Dni = new System.Windows.Forms.TextBox();
            this.T_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.T_cantidad = new System.Windows.Forms.TextBox();
            this.B_Enviaralcarro = new System.Windows.Forms.Button();
            this.T_Precio = new System.Windows.Forms.TextBox();
            this.T_IdCategoria = new System.Windows.Forms.TextBox();
            this.T_IdProd = new System.Windows.Forms.TextBox();
            this.T_NombreProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.L_IdProducto = new System.Windows.Forms.Label();
            this.L_NombreProd = new System.Windows.Forms.Label();
            this.B_VerProductos = new System.Windows.Forms.Button();
            this.ListaProductos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListaCarro = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.B_VerPedidos = new System.Windows.Forms.Button();
            this.ListaPedidos = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.B_CerrarSesion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Datos_Usuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos_Usuario
            // 
            this.Datos_Usuario.Controls.Add(this.tabPage1);
            this.Datos_Usuario.Controls.Add(this.tabPage2);
            this.Datos_Usuario.Controls.Add(this.tabPage3);
            this.Datos_Usuario.Controls.Add(this.tabPage4);
            this.Datos_Usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Datos_Usuario.Location = new System.Drawing.Point(0, 29);
            this.Datos_Usuario.Name = "Datos_Usuario";
            this.Datos_Usuario.SelectedIndex = 0;
            this.Datos_Usuario.Size = new System.Drawing.Size(786, 315);
            this.Datos_Usuario.TabIndex = 2;
            this.Datos_Usuario.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.T_Direc);
            this.tabPage1.Controls.Add(this.T_Email);
            this.tabPage1.Controls.Add(this.T_Nombre);
            this.tabPage1.Controls.Add(this.T_Dni);
            this.tabPage1.Controls.Add(this.T_Id);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // T_Direc
            // 
            this.T_Direc.Location = new System.Drawing.Point(470, 51);
            this.T_Direc.Name = "T_Direc";
            this.T_Direc.Size = new System.Drawing.Size(246, 20);
            this.T_Direc.TabIndex = 12;
            // 
            // T_Email
            // 
            this.T_Email.Location = new System.Drawing.Point(143, 163);
            this.T_Email.Name = "T_Email";
            this.T_Email.ReadOnly = true;
            this.T_Email.Size = new System.Drawing.Size(150, 20);
            this.T_Email.TabIndex = 11;
            // 
            // T_Nombre
            // 
            this.T_Nombre.Location = new System.Drawing.Point(143, 122);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.ReadOnly = true;
            this.T_Nombre.Size = new System.Drawing.Size(150, 20);
            this.T_Nombre.TabIndex = 9;
            // 
            // T_Dni
            // 
            this.T_Dni.Location = new System.Drawing.Point(143, 86);
            this.T_Dni.Name = "T_Dni";
            this.T_Dni.ReadOnly = true;
            this.T_Dni.Size = new System.Drawing.Size(150, 20);
            this.T_Dni.TabIndex = 8;
            // 
            // T_Id
            // 
            this.T_Id.Location = new System.Drawing.Point(143, 54);
            this.T_Id.Name = "T_Id";
            this.T_Id.ReadOnly = true;
            this.T_Id.Size = new System.Drawing.Size(150, 20);
            this.T_Id.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.T_cantidad);
            this.tabPage2.Controls.Add(this.B_Enviaralcarro);
            this.tabPage2.Controls.Add(this.T_Precio);
            this.tabPage2.Controls.Add(this.T_IdCategoria);
            this.tabPage2.Controls.Add(this.T_IdProd);
            this.tabPage2.Controls.Add(this.T_NombreProducto);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.L_IdProducto);
            this.tabPage2.Controls.Add(this.L_NombreProd);
            this.tabPage2.Controls.Add(this.B_VerProductos);
            this.tabPage2.Controls.Add(this.ListaProductos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad:";
            // 
            // T_cantidad
            // 
            this.T_cantidad.Location = new System.Drawing.Point(422, 236);
            this.T_cantidad.Name = "T_cantidad";
            this.T_cantidad.Size = new System.Drawing.Size(115, 20);
            this.T_cantidad.TabIndex = 12;
            this.T_cantidad.Text = "1";
            // 
            // B_Enviaralcarro
            // 
            this.B_Enviaralcarro.Location = new System.Drawing.Point(599, 236);
            this.B_Enviaralcarro.Name = "B_Enviaralcarro";
            this.B_Enviaralcarro.Size = new System.Drawing.Size(85, 23);
            this.B_Enviaralcarro.TabIndex = 11;
            this.B_Enviaralcarro.Text = "Añadir al Carro";
            this.B_Enviaralcarro.UseVisualStyleBackColor = true;
            this.B_Enviaralcarro.Click += new System.EventHandler(this.B_Enviaralcarro_Click);
            // 
            // T_Precio
            // 
            this.T_Precio.Location = new System.Drawing.Point(422, 195);
            this.T_Precio.Name = "T_Precio";
            this.T_Precio.Size = new System.Drawing.Size(115, 20);
            this.T_Precio.TabIndex = 10;
            // 
            // T_IdCategoria
            // 
            this.T_IdCategoria.Location = new System.Drawing.Point(422, 155);
            this.T_IdCategoria.Name = "T_IdCategoria";
            this.T_IdCategoria.Size = new System.Drawing.Size(115, 20);
            this.T_IdCategoria.TabIndex = 9;
            // 
            // T_IdProd
            // 
            this.T_IdProd.Location = new System.Drawing.Point(422, 118);
            this.T_IdProd.Name = "T_IdProd";
            this.T_IdProd.Size = new System.Drawing.Size(115, 20);
            this.T_IdProd.TabIndex = 8;
            // 
            // T_NombreProducto
            // 
            this.T_NombreProducto.Location = new System.Drawing.Point(422, 79);
            this.T_NombreProducto.Name = "T_NombreProducto";
            this.T_NombreProducto.Size = new System.Drawing.Size(115, 20);
            this.T_NombreProducto.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Id_Categoria:";
            // 
            // L_IdProducto
            // 
            this.L_IdProducto.AutoSize = true;
            this.L_IdProducto.Location = new System.Drawing.Point(299, 118);
            this.L_IdProducto.Name = "L_IdProducto";
            this.L_IdProducto.Size = new System.Drawing.Size(19, 13);
            this.L_IdProducto.TabIndex = 4;
            this.L_IdProducto.Text = "Id:";
            // 
            // L_NombreProd
            // 
            this.L_NombreProd.AutoSize = true;
            this.L_NombreProd.Location = new System.Drawing.Point(299, 79);
            this.L_NombreProd.Name = "L_NombreProd";
            this.L_NombreProd.Size = new System.Drawing.Size(93, 13);
            this.L_NombreProd.TabIndex = 3;
            this.L_NombreProd.Text = "Nombre Producto:";
            // 
            // B_VerProductos
            // 
            this.B_VerProductos.Location = new System.Drawing.Point(162, 30);
            this.B_VerProductos.Name = "B_VerProductos";
            this.B_VerProductos.Size = new System.Drawing.Size(75, 23);
            this.B_VerProductos.TabIndex = 2;
            this.B_VerProductos.Text = "Ver Detalles";
            this.B_VerProductos.UseVisualStyleBackColor = true;
            this.B_VerProductos.Click += new System.EventHandler(this.B_VerProductos_Click);
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(67, 70);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(170, 186);
            this.ListaProductos.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "PRODUCTOS";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.ListaCarro);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(778, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Carrito de Compra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Eliminar Producto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hacer Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaCarro
            // 
            this.ListaCarro.FormattingEnabled = true;
            this.ListaCarro.Location = new System.Drawing.Point(47, 91);
            this.ListaCarro.Name = "ListaCarro";
            this.ListaCarro.Size = new System.Drawing.Size(276, 82);
            this.ListaCarro.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "PRODUCTOS";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.B_VerPedidos);
            this.tabPage4.Controls.Add(this.ListaPedidos);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(778, 289);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pedidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // B_VerPedidos
            // 
            this.B_VerPedidos.Location = new System.Drawing.Point(285, 39);
            this.B_VerPedidos.Name = "B_VerPedidos";
            this.B_VerPedidos.Size = new System.Drawing.Size(75, 23);
            this.B_VerPedidos.TabIndex = 2;
            this.B_VerPedidos.Text = "Ver Pedidos";
            this.B_VerPedidos.UseVisualStyleBackColor = true;
            // 
            // ListaPedidos
            // 
            this.ListaPedidos.FormattingEnabled = true;
            this.ListaPedidos.Location = new System.Drawing.Point(63, 73);
            this.ListaPedidos.Name = "ListaPedidos";
            this.ListaPedidos.Size = new System.Drawing.Size(297, 173);
            this.ListaPedidos.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "PEDIDOS";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(586, 10);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(0, 13);
            this.LabelUser.TabIndex = 3;
            // 
            // B_CerrarSesion
            // 
            this.B_CerrarSesion.Location = new System.Drawing.Point(657, 12);
            this.B_CerrarSesion.Name = "B_CerrarSesion";
            this.B_CerrarSesion.Size = new System.Drawing.Size(93, 23);
            this.B_CerrarSesion.TabIndex = 4;
            this.B_CerrarSesion.Text = "Cerrar sesion";
            this.B_CerrarSesion.UseVisualStyleBackColor = true;
            this.B_CerrarSesion.Click += new System.EventHandler(this.B_CerrarSesion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.B_CerrarSesion);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.Datos_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Datos_Usuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Datos_Usuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox T_Direc;
        private System.Windows.Forms.TextBox T_Email;
        private System.Windows.Forms.TextBox T_Nombre;
        private System.Windows.Forms.TextBox T_Dni;
        private System.Windows.Forms.TextBox T_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label L_IdProducto;
        private System.Windows.Forms.Label L_NombreProd;
        private System.Windows.Forms.Button B_VerProductos;
        private System.Windows.Forms.ListBox ListaProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox T_Precio;
        private System.Windows.Forms.TextBox T_IdCategoria;
        private System.Windows.Forms.TextBox T_IdProd;
        private System.Windows.Forms.TextBox T_NombreProducto;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button B_CerrarSesion;
        private System.Windows.Forms.Button B_Enviaralcarro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListaCarro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox ListaPedidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button B_VerPedidos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox T_cantidad;
    }
}