namespace supermarket
{
    partial class FormAdministrador
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.B_BorrarCliente = new System.Windows.Forms.Button();
            this.B_ModUsuarios = new System.Windows.Forms.Button();
            this.T_Admin = new System.Windows.Forms.TextBox();
            this.T_Direc = new System.Windows.Forms.TextBox();
            this.T_Email = new System.Windows.Forms.TextBox();
            this.T_Pass = new System.Windows.Forms.TextBox();
            this.T_Nombre = new System.Windows.Forms.TextBox();
            this.T_Dni = new System.Windows.Forms.TextBox();
            this.T_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.B_VerClientes = new System.Windows.Forms.Button();
            this.ListaClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.B_BorrarCat = new System.Windows.Forms.Button();
            this.B_GuardarCat = new System.Windows.Forms.Button();
            this.T_NombreCat = new System.Windows.Forms.TextBox();
            this.T_IdCat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.B_VerDetCat = new System.Windows.Forms.Button();
            this.ListaCategorias = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.B_GuardarProd = new System.Windows.Forms.Button();
            this.T_precio_P = new System.Windows.Forms.TextBox();
            this.T_id_cat_P = new System.Windows.Forms.TextBox();
            this.T_id_P = new System.Windows.Forms.TextBox();
            this.T_nom_P = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.L_IdProducto = new System.Windows.Forms.Label();
            this.L_NombreProd = new System.Windows.Forms.Label();
            this.ListaProductos = new System.Windows.Forms.ListBox();
            this.B_VerProductos = new System.Windows.Forms.Button();
            this.B_NuevaCat = new System.Windows.Forms.Button();
            this.B_EliminarCat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.LabelUser = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.B_BorrarCliente);
            this.tabPage1.Controls.Add(this.B_ModUsuarios);
            this.tabPage1.Controls.Add(this.T_Admin);
            this.tabPage1.Controls.Add(this.T_Direc);
            this.tabPage1.Controls.Add(this.T_Email);
            this.tabPage1.Controls.Add(this.T_Pass);
            this.tabPage1.Controls.Add(this.T_Nombre);
            this.tabPage1.Controls.Add(this.T_Dni);
            this.tabPage1.Controls.Add(this.T_Id);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.B_VerClientes);
            this.tabPage1.Controls.Add(this.ListaClientes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_BorrarCliente
            // 
            this.B_BorrarCliente.Location = new System.Drawing.Point(44, 238);
            this.B_BorrarCliente.Name = "B_BorrarCliente";
            this.B_BorrarCliente.Size = new System.Drawing.Size(84, 23);
            this.B_BorrarCliente.TabIndex = 29;
            this.B_BorrarCliente.Text = "Borrar Cliente";
            this.B_BorrarCliente.UseVisualStyleBackColor = true;
            // 
            // B_ModUsuarios
            // 
            this.B_ModUsuarios.Location = new System.Drawing.Point(644, 180);
            this.B_ModUsuarios.Name = "B_ModUsuarios";
            this.B_ModUsuarios.Size = new System.Drawing.Size(75, 23);
            this.B_ModUsuarios.TabIndex = 28;
            this.B_ModUsuarios.Text = "Guardar";
            this.B_ModUsuarios.UseVisualStyleBackColor = true;
            // 
            // T_Admin
            // 
            this.T_Admin.Location = new System.Drawing.Point(636, 138);
            this.T_Admin.Name = "T_Admin";
            this.T_Admin.Size = new System.Drawing.Size(36, 20);
            this.T_Admin.TabIndex = 27;
            // 
            // T_Direc
            // 
            this.T_Direc.Location = new System.Drawing.Point(332, 183);
            this.T_Direc.Name = "T_Direc";
            this.T_Direc.Size = new System.Drawing.Size(152, 20);
            this.T_Direc.TabIndex = 26;
            // 
            // T_Email
            // 
            this.T_Email.Location = new System.Drawing.Point(332, 144);
            this.T_Email.Name = "T_Email";
            this.T_Email.Size = new System.Drawing.Size(152, 20);
            this.T_Email.TabIndex = 25;
            // 
            // T_Pass
            // 
            this.T_Pass.Location = new System.Drawing.Point(332, 105);
            this.T_Pass.Name = "T_Pass";
            this.T_Pass.PasswordChar = '*';
            this.T_Pass.Size = new System.Drawing.Size(150, 20);
            this.T_Pass.TabIndex = 24;
            // 
            // T_Nombre
            // 
            this.T_Nombre.Location = new System.Drawing.Point(332, 67);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.Size = new System.Drawing.Size(150, 20);
            this.T_Nombre.TabIndex = 23;
            // 
            // T_Dni
            // 
            this.T_Dni.Location = new System.Drawing.Point(636, 102);
            this.T_Dni.Name = "T_Dni";
            this.T_Dni.Size = new System.Drawing.Size(83, 20);
            this.T_Dni.TabIndex = 22;
            // 
            // T_Id
            // 
            this.T_Id.Location = new System.Drawing.Point(636, 67);
            this.T_Id.Name = "T_Id";
            this.T_Id.Size = new System.Drawing.Size(83, 20);
            this.T_Id.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ADMIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "DIRECCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID";
            // 
            // B_VerClientes
            // 
            this.B_VerClientes.Location = new System.Drawing.Point(133, 11);
            this.B_VerClientes.Name = "B_VerClientes";
            this.B_VerClientes.Size = new System.Drawing.Size(75, 23);
            this.B_VerClientes.TabIndex = 5;
            this.B_VerClientes.Text = "Ver Detalles";
            this.B_VerClientes.UseVisualStyleBackColor = true;
            this.B_VerClientes.Click += new System.EventHandler(this.B_VerClientes_Click);
            // 
            // ListaClientes
            // 
            this.ListaClientes.FormattingEnabled = true;
            this.ListaClientes.Location = new System.Drawing.Point(44, 46);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(182, 173);
            this.ListaClientes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.B_BorrarCat);
            this.tabPage2.Controls.Add(this.B_GuardarCat);
            this.tabPage2.Controls.Add(this.T_NombreCat);
            this.tabPage2.Controls.Add(this.T_IdCat);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.B_VerDetCat);
            this.tabPage2.Controls.Add(this.ListaCategorias);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(779, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Nueva";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // B_BorrarCat
            // 
            this.B_BorrarCat.Location = new System.Drawing.Point(52, 242);
            this.B_BorrarCat.Name = "B_BorrarCat";
            this.B_BorrarCat.Size = new System.Drawing.Size(84, 23);
            this.B_BorrarCat.TabIndex = 49;
            this.B_BorrarCat.Text = "Eliminar";
            this.B_BorrarCat.UseVisualStyleBackColor = true;
            // 
            // B_GuardarCat
            // 
            this.B_GuardarCat.Location = new System.Drawing.Point(340, 200);
            this.B_GuardarCat.Name = "B_GuardarCat";
            this.B_GuardarCat.Size = new System.Drawing.Size(75, 23);
            this.B_GuardarCat.TabIndex = 48;
            this.B_GuardarCat.Text = "Guardar";
            this.B_GuardarCat.UseVisualStyleBackColor = true;
            // 
            // T_NombreCat
            // 
            this.T_NombreCat.Location = new System.Drawing.Point(340, 71);
            this.T_NombreCat.Name = "T_NombreCat";
            this.T_NombreCat.Size = new System.Drawing.Size(150, 20);
            this.T_NombreCat.TabIndex = 43;
            // 
            // T_IdCat
            // 
            this.T_IdCat.Location = new System.Drawing.Point(340, 118);
            this.T_IdCat.Name = "T_IdCat";
            this.T_IdCat.Size = new System.Drawing.Size(83, 20);
            this.T_IdCat.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "NOMBRE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "ID";
            // 
            // B_VerDetCat
            // 
            this.B_VerDetCat.Location = new System.Drawing.Point(141, 15);
            this.B_VerDetCat.Name = "B_VerDetCat";
            this.B_VerDetCat.Size = new System.Drawing.Size(75, 23);
            this.B_VerDetCat.TabIndex = 33;
            this.B_VerDetCat.Text = "Ver Detalles";
            this.B_VerDetCat.UseVisualStyleBackColor = true;
            // 
            // ListaCategorias
            // 
            this.ListaCategorias.FormattingEnabled = true;
            this.ListaCategorias.Location = new System.Drawing.Point(52, 50);
            this.ListaCategorias.Name = "ListaCategorias";
            this.ListaCategorias.Size = new System.Drawing.Size(182, 173);
            this.ListaCategorias.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(60, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "CATEGORIAS";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.B_GuardarProd);
            this.tabPage3.Controls.Add(this.T_precio_P);
            this.tabPage3.Controls.Add(this.T_id_cat_P);
            this.tabPage3.Controls.Add(this.T_id_P);
            this.tabPage3.Controls.Add(this.T_nom_P);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.L_IdProducto);
            this.tabPage3.Controls.Add(this.L_NombreProd);
            this.tabPage3.Controls.Add(this.ListaProductos);
            this.tabPage3.Controls.Add(this.B_VerProductos);
            this.tabPage3.Controls.Add(this.B_NuevaCat);
            this.tabPage3.Controls.Add(this.B_EliminarCat);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(779, 281);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // B_GuardarProd
            // 
            this.B_GuardarProd.Location = new System.Drawing.Point(154, 240);
            this.B_GuardarProd.Name = "B_GuardarProd";
            this.B_GuardarProd.Size = new System.Drawing.Size(75, 23);
            this.B_GuardarProd.TabIndex = 66;
            this.B_GuardarProd.Text = "Nuevo";
            this.B_GuardarProd.UseVisualStyleBackColor = true;
            this.B_GuardarProd.Click += new System.EventHandler(this.B_GuardarProd_Click);
            // 
            // T_precio_P
            // 
            this.T_precio_P.Location = new System.Drawing.Point(409, 172);
            this.T_precio_P.Name = "T_precio_P";
            this.T_precio_P.Size = new System.Drawing.Size(52, 20);
            this.T_precio_P.TabIndex = 65;
            // 
            // T_id_cat_P
            // 
            this.T_id_cat_P.Location = new System.Drawing.Point(409, 132);
            this.T_id_cat_P.Name = "T_id_cat_P";
            this.T_id_cat_P.Size = new System.Drawing.Size(52, 20);
            this.T_id_cat_P.TabIndex = 64;
            // 
            // T_id_P
            // 
            this.T_id_P.Location = new System.Drawing.Point(409, 95);
            this.T_id_P.Name = "T_id_P";
            this.T_id_P.Size = new System.Drawing.Size(52, 20);
            this.T_id_P.TabIndex = 63;
            // 
            // T_nom_P
            // 
            this.T_nom_P.Location = new System.Drawing.Point(409, 56);
            this.T_nom_P.Name = "T_nom_P";
            this.T_nom_P.Size = new System.Drawing.Size(194, 20);
            this.T_nom_P.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Precio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Id_Categoria";
            // 
            // L_IdProducto
            // 
            this.L_IdProducto.AutoSize = true;
            this.L_IdProducto.Location = new System.Drawing.Point(286, 95);
            this.L_IdProducto.Name = "L_IdProducto";
            this.L_IdProducto.Size = new System.Drawing.Size(16, 13);
            this.L_IdProducto.TabIndex = 59;
            this.L_IdProducto.Text = "Id";
            // 
            // L_NombreProd
            // 
            this.L_NombreProd.AutoSize = true;
            this.L_NombreProd.Location = new System.Drawing.Point(286, 56);
            this.L_NombreProd.Name = "L_NombreProd";
            this.L_NombreProd.Size = new System.Drawing.Size(90, 13);
            this.L_NombreProd.TabIndex = 58;
            this.L_NombreProd.Text = "Nombre Producto";
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(47, 48);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(182, 186);
            this.ListaProductos.TabIndex = 57;
            // 
            // B_VerProductos
            // 
            this.B_VerProductos.Location = new System.Drawing.Point(154, 14);
            this.B_VerProductos.Name = "B_VerProductos";
            this.B_VerProductos.Size = new System.Drawing.Size(75, 23);
            this.B_VerProductos.TabIndex = 56;
            this.B_VerProductos.Text = "Ver Detalles";
            this.B_VerProductos.UseVisualStyleBackColor = true;
            this.B_VerProductos.Click += new System.EventHandler(this.B_VerProductos_Click);
            // 
            // B_NuevaCat
            // 
            this.B_NuevaCat.Location = new System.Drawing.Point(360, 211);
            this.B_NuevaCat.Name = "B_NuevaCat";
            this.B_NuevaCat.Size = new System.Drawing.Size(92, 23);
            this.B_NuevaCat.TabIndex = 55;
            this.B_NuevaCat.Text = "Modificar";
            this.B_NuevaCat.UseVisualStyleBackColor = true;
            // 
            // B_EliminarCat
            // 
            this.B_EliminarCat.Location = new System.Drawing.Point(47, 240);
            this.B_EliminarCat.Name = "B_EliminarCat";
            this.B_EliminarCat.Size = new System.Drawing.Size(84, 23);
            this.B_EliminarCat.TabIndex = 54;
            this.B_EliminarCat.Text = "Eliminar";
            this.B_EliminarCat.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "CATEGORIAS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(682, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Desloguear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(612, 17);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(0, 13);
            this.LabelUser.TabIndex = 5;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 343);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button B_VerClientes;
        private System.Windows.Forms.ListBox ListaClientes;
        private System.Windows.Forms.TextBox T_Admin;
        private System.Windows.Forms.TextBox T_Direc;
        private System.Windows.Forms.TextBox T_Email;
        private System.Windows.Forms.TextBox T_Pass;
        private System.Windows.Forms.TextBox T_Nombre;
        private System.Windows.Forms.TextBox T_Dni;
        private System.Windows.Forms.TextBox T_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button B_ModUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button B_BorrarCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_BorrarCat;
        private System.Windows.Forms.Button B_GuardarCat;
        private System.Windows.Forms.TextBox T_NombreCat;
        private System.Windows.Forms.TextBox T_IdCat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button B_VerDetCat;
        private System.Windows.Forms.ListBox ListaCategorias;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button B_NuevaCat;
        private System.Windows.Forms.Button B_EliminarCat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button B_VerProductos;
        private System.Windows.Forms.ListBox ListaProductos;
        private System.Windows.Forms.TextBox T_precio_P;
        private System.Windows.Forms.TextBox T_id_cat_P;
        private System.Windows.Forms.TextBox T_id_P;
        private System.Windows.Forms.TextBox T_nom_P;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label L_IdProducto;
        private System.Windows.Forms.Label L_NombreProd;
        private System.Windows.Forms.Button B_GuardarProd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelUser;
    }
}