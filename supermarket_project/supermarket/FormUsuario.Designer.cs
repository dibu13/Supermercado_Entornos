﻿namespace supermarket
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
            this.Datos_Usuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.B_Enviaralcarro = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.L_IdProducto = new System.Windows.Forms.Label();
            this.L_NombreProd = new System.Windows.Forms.Label();
            this.B_VerProductos = new System.Windows.Forms.Button();
            this.ListaProductos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.ListaCarro = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ListaPedidos = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.B_VerPedidos = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // T_Admin
            // 
            this.T_Admin.Location = new System.Drawing.Point(680, 38);
            this.T_Admin.Name = "T_Admin";
            this.T_Admin.Size = new System.Drawing.Size(36, 20);
            this.T_Admin.TabIndex = 13;
            // 
            // T_Direc
            // 
            this.T_Direc.Location = new System.Drawing.Point(457, 73);
            this.T_Direc.Name = "T_Direc";
            this.T_Direc.Size = new System.Drawing.Size(170, 20);
            this.T_Direc.TabIndex = 12;
            // 
            // T_Email
            // 
            this.T_Email.Location = new System.Drawing.Point(457, 38);
            this.T_Email.Name = "T_Email";
            this.T_Email.Size = new System.Drawing.Size(170, 20);
            this.T_Email.TabIndex = 11;
            // 
            // T_Pass
            // 
            this.T_Pass.Location = new System.Drawing.Point(225, 73);
            this.T_Pass.Name = "T_Pass";
            this.T_Pass.Size = new System.Drawing.Size(150, 20);
            this.T_Pass.TabIndex = 10;
            // 
            // T_Nombre
            // 
            this.T_Nombre.Location = new System.Drawing.Point(225, 38);
            this.T_Nombre.Name = "T_Nombre";
            this.T_Nombre.Size = new System.Drawing.Size(150, 20);
            this.T_Nombre.TabIndex = 9;
            // 
            // T_Dni
            // 
            this.T_Dni.Location = new System.Drawing.Point(43, 73);
            this.T_Dni.Name = "T_Dni";
            this.T_Dni.Size = new System.Drawing.Size(83, 20);
            this.T_Dni.TabIndex = 8;
            // 
            // T_Id
            // 
            this.T_Id.Location = new System.Drawing.Point(43, 38);
            this.T_Id.Name = "T_Id";
            this.T_Id.Size = new System.Drawing.Size(83, 20);
            this.T_Id.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ADMIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIRECCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.B_Enviaralcarro);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
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
            // B_Enviaralcarro
            // 
            this.B_Enviaralcarro.Location = new System.Drawing.Point(512, 206);
            this.B_Enviaralcarro.Name = "B_Enviaralcarro";
            this.B_Enviaralcarro.Size = new System.Drawing.Size(85, 23);
            this.B_Enviaralcarro.TabIndex = 11;
            this.B_Enviaralcarro.Text = "Añadir al Carro";
            this.B_Enviaralcarro.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(423, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(423, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(423, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Precio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Id_Categoria";
            // 
            // L_IdProducto
            // 
            this.L_IdProducto.AutoSize = true;
            this.L_IdProducto.Location = new System.Drawing.Point(300, 131);
            this.L_IdProducto.Name = "L_IdProducto";
            this.L_IdProducto.Size = new System.Drawing.Size(16, 13);
            this.L_IdProducto.TabIndex = 4;
            this.L_IdProducto.Text = "Id";
            // 
            // L_NombreProd
            // 
            this.L_NombreProd.AutoSize = true;
            this.L_NombreProd.Location = new System.Drawing.Point(300, 92);
            this.L_NombreProd.Name = "L_NombreProd";
            this.L_NombreProd.Size = new System.Drawing.Size(90, 13);
            this.L_NombreProd.TabIndex = 3;
            this.L_NombreProd.Text = "Nombre Producto";
            // 
            // B_VerProductos
            // 
            this.B_VerProductos.Location = new System.Drawing.Point(162, 30);
            this.B_VerProductos.Name = "B_VerProductos";
            this.B_VerProductos.Size = new System.Drawing.Size(75, 23);
            this.B_VerProductos.TabIndex = 2;
            this.B_VerProductos.Text = "Ver Detalles";
            this.B_VerProductos.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hacer Pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListaCarro
            // 
            this.ListaCarro.FormattingEnabled = true;
            this.ListaCarro.Location = new System.Drawing.Point(47, 91);
            this.ListaCarro.Name = "ListaCarro";
            this.ListaCarro.Size = new System.Drawing.Size(163, 173);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Desloguear";
            this.button1.UseVisualStyleBackColor = true;
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
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.Datos_Usuario);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button B_Enviaralcarro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListaCarro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox ListaPedidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button B_VerPedidos;
    }
}