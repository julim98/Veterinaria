using System;
using System.Windows.Forms;

namespace Veterinaria
{
    partial class Frm_Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escritorio));
            this.Pnl_Barra_Superior = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Restaurar = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Maximizar = new System.Windows.Forms.Button();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_Configuracion = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Btn_Sintomas = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_Vacunas = new System.Windows.Forms.Button();
            this.Btn_Informes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Inicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Medicamentos = new System.Windows.Forms.Button();
            this.Btn_Diagnosticos = new System.Windows.Forms.Button();
            this.Btn_Perros = new System.Windows.Forms.Button();
            this.Btn_Consultas = new System.Windows.Forms.Button();
            this.Pnl_Contenedor = new System.Windows.Forms.Panel();
            this.Pnl_Barra_Superior.SuspendLayout();
            this.Pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Barra_Superior
            // 
            this.Pnl_Barra_Superior.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Cerrar);
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Restaurar);
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Minimizar);
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Maximizar);
            this.Pnl_Barra_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Barra_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Barra_Superior.Name = "Pnl_Barra_Superior";
            this.Pnl_Barra_Superior.Size = new System.Drawing.Size(1000, 30);
            this.Pnl_Barra_Superior.TabIndex = 11;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(970, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Cerrar.TabIndex = 25;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Restaurar
            // 
            this.Btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Restaurar.FlatAppearance.BorderSize = 0;
            this.Btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Restaurar.Image")));
            this.Btn_Restaurar.Location = new System.Drawing.Point(940, 0);
            this.Btn_Restaurar.Name = "Btn_Restaurar";
            this.Btn_Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Restaurar.TabIndex = 4;
            this.Btn_Restaurar.UseVisualStyleBackColor = true;
            this.Btn_Restaurar.Visible = false;
            this.Btn_Restaurar.Click += new System.EventHandler(this.Btn_Restaurar_Click_1);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(910, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Minimizar.TabIndex = 3;
            this.Btn_Minimizar.UseVisualStyleBackColor = true;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Maximizar
            // 
            this.Btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximizar.FlatAppearance.BorderSize = 0;
            this.Btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Maximizar.Image")));
            this.Btn_Maximizar.Location = new System.Drawing.Point(940, 0);
            this.Btn_Maximizar.Name = "Btn_Maximizar";
            this.Btn_Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Maximizar.TabIndex = 4;
            this.Btn_Maximizar.UseVisualStyleBackColor = true;
            this.Btn_Maximizar.Click += new System.EventHandler(this.Btn_Maximizar_Click);
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_Menu.Controls.Add(this.Btn_Configuracion);
            this.Pnl_Menu.Controls.Add(this.panel7);
            this.Pnl_Menu.Controls.Add(this.panel10);
            this.Pnl_Menu.Controls.Add(this.Btn_Salir);
            this.Pnl_Menu.Controls.Add(this.panel9);
            this.Pnl_Menu.Controls.Add(this.Btn_Sintomas);
            this.Pnl_Menu.Controls.Add(this.panel8);
            this.Pnl_Menu.Controls.Add(this.panel6);
            this.Pnl_Menu.Controls.Add(this.Btn_Vacunas);
            this.Pnl_Menu.Controls.Add(this.Btn_Informes);
            this.Pnl_Menu.Controls.Add(this.panel5);
            this.Pnl_Menu.Controls.Add(this.panel4);
            this.Pnl_Menu.Controls.Add(this.panel3);
            this.Pnl_Menu.Controls.Add(this.panel2);
            this.Pnl_Menu.Controls.Add(this.panel1);
            this.Pnl_Menu.Controls.Add(this.Btn_Inicio);
            this.Pnl_Menu.Controls.Add(this.label1);
            this.Pnl_Menu.Controls.Add(this.pictureBox1);
            this.Pnl_Menu.Controls.Add(this.label2);
            this.Pnl_Menu.Controls.Add(this.Btn_Medicamentos);
            this.Pnl_Menu.Controls.Add(this.Btn_Diagnosticos);
            this.Pnl_Menu.Controls.Add(this.Btn_Perros);
            this.Pnl_Menu.Controls.Add(this.Btn_Consultas);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 30);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(200, 550);
            this.Pnl_Menu.TabIndex = 12;
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Configuracion.FlatAppearance.BorderSize = 0;
            this.Btn_Configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Configuracion.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Configuracion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Configuracion.Image")));
            this.Btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Configuracion.Location = new System.Drawing.Point(5, 427);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.Size = new System.Drawing.Size(195, 40);
            this.Btn_Configuracion.TabIndex = 10;
            this.Btn_Configuracion.Text = "Configuración";
            this.Btn_Configuracion.UseVisualStyleBackColor = false;
            this.Btn_Configuracion.Click += new System.EventHandler(this.Btn_Configuracion_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel7.Location = new System.Drawing.Point(0, 427);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 40);
            this.panel7.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel10.Location = new System.Drawing.Point(0, 498);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 40);
            this.panel10.TabIndex = 16;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Location = new System.Drawing.Point(5, 498);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(195, 40);
            this.Btn_Salir.TabIndex = 15;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel9.Location = new System.Drawing.Point(0, 243);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 40);
            this.panel9.TabIndex = 14;
            // 
            // Btn_Sintomas
            // 
            this.Btn_Sintomas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Sintomas.FlatAppearance.BorderSize = 0;
            this.Btn_Sintomas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Sintomas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Sintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sintomas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sintomas.Image = global::Veterinaria.Properties.Resources.sintomas;
            this.Btn_Sintomas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sintomas.Location = new System.Drawing.Point(5, 243);
            this.Btn_Sintomas.Name = "Btn_Sintomas";
            this.Btn_Sintomas.Size = new System.Drawing.Size(195, 40);
            this.Btn_Sintomas.TabIndex = 13;
            this.Btn_Sintomas.Text = "       Síntomas";
            this.Btn_Sintomas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sintomas.UseVisualStyleBackColor = false;
            this.Btn_Sintomas.Click += new System.EventHandler(this.Btn_Sintomas_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel8.Location = new System.Drawing.Point(0, 381);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 40);
            this.panel8.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel6.Location = new System.Drawing.Point(0, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 40);
            this.panel6.TabIndex = 5;
            // 
            // Btn_Vacunas
            // 
            this.Btn_Vacunas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Vacunas.FlatAppearance.BorderSize = 0;
            this.Btn_Vacunas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Vacunas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Vacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Vacunas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vacunas.Image = global::Veterinaria.Properties.Resources.calendario1;
            this.Btn_Vacunas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vacunas.Location = new System.Drawing.Point(5, 381);
            this.Btn_Vacunas.Name = "Btn_Vacunas";
            this.Btn_Vacunas.Size = new System.Drawing.Size(195, 40);
            this.Btn_Vacunas.TabIndex = 7;
            this.Btn_Vacunas.Text = "       Vacunas";
            this.Btn_Vacunas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vacunas.UseVisualStyleBackColor = false;
            this.Btn_Vacunas.Click += new System.EventHandler(this.Btn_Vacunas_Click);
            // 
            // Btn_Informes
            // 
            this.Btn_Informes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Informes.FlatAppearance.BorderSize = 0;
            this.Btn_Informes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Informes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Informes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Informes.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Informes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Informes.Image")));
            this.Btn_Informes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Informes.Location = new System.Drawing.Point(5, 335);
            this.Btn_Informes.Name = "Btn_Informes";
            this.Btn_Informes.Size = new System.Drawing.Size(195, 40);
            this.Btn_Informes.TabIndex = 9;
            this.Btn_Informes.Text = "       Informes";
            this.Btn_Informes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Informes.UseVisualStyleBackColor = false;
            this.Btn_Informes.Click += new System.EventHandler(this.Btn_Informes_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Location = new System.Drawing.Point(0, 289);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 40);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Location = new System.Drawing.Point(0, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 40);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Inicio.FlatAppearance.BorderSize = 0;
            this.Btn_Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Inicio.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Inicio.Image")));
            this.Btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Inicio.Location = new System.Drawing.Point(5, 59);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.Size = new System.Drawing.Size(195, 40);
            this.Btn_Inicio.TabIndex = 0;
            this.Btn_Inicio.Text = "Inicio           ";
            this.Btn_Inicio.UseVisualStyleBackColor = false;
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "VETERINARIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "EL SABUESO FELÍZ";
            // 
            // Btn_Medicamentos
            // 
            this.Btn_Medicamentos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Medicamentos.FlatAppearance.BorderSize = 0;
            this.Btn_Medicamentos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Medicamentos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Medicamentos.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Medicamentos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Medicamentos.Image")));
            this.Btn_Medicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Medicamentos.Location = new System.Drawing.Point(5, 289);
            this.Btn_Medicamentos.Name = "Btn_Medicamentos";
            this.Btn_Medicamentos.Size = new System.Drawing.Size(195, 40);
            this.Btn_Medicamentos.TabIndex = 6;
            this.Btn_Medicamentos.Text = "Medicamentos";
            this.Btn_Medicamentos.UseVisualStyleBackColor = false;
            this.Btn_Medicamentos.Click += new System.EventHandler(this.Btn_Medicamentos_Click);
            // 
            // Btn_Diagnosticos
            // 
            this.Btn_Diagnosticos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Diagnosticos.FlatAppearance.BorderSize = 0;
            this.Btn_Diagnosticos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Diagnosticos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Diagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Diagnosticos.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Diagnosticos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Diagnosticos.Image")));
            this.Btn_Diagnosticos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Diagnosticos.Location = new System.Drawing.Point(5, 197);
            this.Btn_Diagnosticos.Name = "Btn_Diagnosticos";
            this.Btn_Diagnosticos.Size = new System.Drawing.Size(195, 40);
            this.Btn_Diagnosticos.TabIndex = 5;
            this.Btn_Diagnosticos.Text = "Diagnósticos ";
            this.Btn_Diagnosticos.UseVisualStyleBackColor = false;
            this.Btn_Diagnosticos.Click += new System.EventHandler(this.Btn_Diagnosticos_Click);
            // 
            // Btn_Perros
            // 
            this.Btn_Perros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Perros.FlatAppearance.BorderSize = 0;
            this.Btn_Perros.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Perros.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Perros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Perros.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Perros.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Perros.Image")));
            this.Btn_Perros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Perros.Location = new System.Drawing.Point(5, 105);
            this.Btn_Perros.Name = "Btn_Perros";
            this.Btn_Perros.Size = new System.Drawing.Size(195, 40);
            this.Btn_Perros.TabIndex = 2;
            this.Btn_Perros.Text = "Perros          ";
            this.Btn_Perros.UseVisualStyleBackColor = false;
            this.Btn_Perros.Click += new System.EventHandler(this.Btn_Perros_Click_1);
            // 
            // Btn_Consultas
            // 
            this.Btn_Consultas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consultas.FlatAppearance.BorderSize = 0;
            this.Btn_Consultas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Consultas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Consultas.Image")));
            this.Btn_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultas.Location = new System.Drawing.Point(5, 151);
            this.Btn_Consultas.Name = "Btn_Consultas";
            this.Btn_Consultas.Size = new System.Drawing.Size(195, 40);
            this.Btn_Consultas.TabIndex = 3;
            this.Btn_Consultas.Text = "Consultas      ";
            this.Btn_Consultas.UseVisualStyleBackColor = false;
            this.Btn_Consultas.Click += new System.EventHandler(this.Btn_Consultas_Click_1);
            // 
            // Pnl_Contenedor
            // 
            this.Pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contenedor.Location = new System.Drawing.Point(200, 30);
            this.Pnl_Contenedor.Name = "Pnl_Contenedor";
            this.Pnl_Contenedor.Size = new System.Drawing.Size(800, 550);
            this.Pnl_Contenedor.TabIndex = 13;
            // 
            // Frm_Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.Pnl_Contenedor);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.Pnl_Barra_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Escritorio";
            this.Load += new System.EventHandler(this.Frm_Escritorio_Load);
            this.Pnl_Barra_Superior.ResumeLayout(false);
            this.Pnl_Menu.ResumeLayout(false);
            this.Pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            Btn_Restaurar.Visible = false;
            Btn_Maximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Perros_Click(object sender, EventArgs e)
        {
            AbrirFormsHijos(new Frm_Perros());
        }

          

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Pnl_Menu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private Panel Pnl_Barra_Superior;
        private Button Btn_Cerrar;
        private Button Btn_Restaurar;
        private Button Btn_Minimizar;
        private Button Btn_Maximizar;
        private Panel Pnl_Menu;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button Btn_Inicio;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button Btn_Medicamentos;
        private Button Btn_Vacunas;
        private Button Btn_Diagnosticos;
        private Button Btn_Perros;
        private Button Btn_Consultas;
        private Panel Pnl_Contenedor;
        private Panel panel8;
        private Panel panel7;
        private Button Btn_Configuracion;
        private Button Btn_Informes;
        private Panel panel10;
        private Button Btn_Salir;
        private Panel panel9;
        private Button Btn_Sintomas;
    }
}