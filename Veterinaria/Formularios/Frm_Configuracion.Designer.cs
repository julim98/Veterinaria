namespace Veterinaria.Vista
{
    partial class Frm_Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Configuracion));
            this.Btn_Laboratorios = new System.Windows.Forms.Button();
            this.Btn_Sucursales = new System.Windows.Forms.Button();
            this.Btn_Empleados = new System.Windows.Forms.Button();
            this.Btn_Razas = new System.Windows.Forms.Button();
            this.Pnl_Contenedor = new System.Windows.Forms.Panel();
            this.Btn_Sintomas = new System.Windows.Forms.Button();
            this.Btn_Calendario_Vacunacion = new System.Windows.Forms.Button();
            this.Pnl_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Laboratorios
            // 
            this.Btn_Laboratorios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Laboratorios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Laboratorios.FlatAppearance.BorderSize = 2;
            this.Btn_Laboratorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Laboratorios.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Laboratorios.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Laboratorios.Image")));
            this.Btn_Laboratorios.Location = new System.Drawing.Point(27, 25);
            this.Btn_Laboratorios.Name = "Btn_Laboratorios";
            this.Btn_Laboratorios.Size = new System.Drawing.Size(150, 150);
            this.Btn_Laboratorios.TabIndex = 0;
            this.Btn_Laboratorios.Text = "Laboratorios";
            this.Btn_Laboratorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Laboratorios.UseVisualStyleBackColor = false;
            this.Btn_Laboratorios.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Sucursales
            // 
            this.Btn_Sucursales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Sucursales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Sucursales.FlatAppearance.BorderSize = 2;
            this.Btn_Sucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sucursales.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sucursales.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sucursales.Image")));
            this.Btn_Sucursales.Location = new System.Drawing.Point(203, 25);
            this.Btn_Sucursales.Name = "Btn_Sucursales";
            this.Btn_Sucursales.Size = new System.Drawing.Size(150, 150);
            this.Btn_Sucursales.TabIndex = 1;
            this.Btn_Sucursales.Text = "Sucursales";
            this.Btn_Sucursales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Sucursales.UseVisualStyleBackColor = false;
            this.Btn_Sucursales.Click += new System.EventHandler(this.Btn_Sucursales_Click);
            // 
            // Btn_Empleados
            // 
            this.Btn_Empleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Empleados.FlatAppearance.BorderSize = 2;
            this.Btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Empleados.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Empleados.Image")));
            this.Btn_Empleados.Location = new System.Drawing.Point(376, 25);
            this.Btn_Empleados.Name = "Btn_Empleados";
            this.Btn_Empleados.Size = new System.Drawing.Size(150, 150);
            this.Btn_Empleados.TabIndex = 2;
            this.Btn_Empleados.Text = "Empleados";
            this.Btn_Empleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Empleados.UseVisualStyleBackColor = false;
            this.Btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // Btn_Razas
            // 
            this.Btn_Razas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Razas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Razas.FlatAppearance.BorderSize = 2;
            this.Btn_Razas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Razas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Razas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Razas.Image")));
            this.Btn_Razas.Location = new System.Drawing.Point(548, 25);
            this.Btn_Razas.Name = "Btn_Razas";
            this.Btn_Razas.Size = new System.Drawing.Size(150, 150);
            this.Btn_Razas.TabIndex = 3;
            this.Btn_Razas.Text = "Razas";
            this.Btn_Razas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Razas.UseVisualStyleBackColor = false;
            // 
            // Pnl_Contenedor
            // 
            this.Pnl_Contenedor.Controls.Add(this.Btn_Razas);
            this.Pnl_Contenedor.Controls.Add(this.Btn_Sintomas);
            this.Pnl_Contenedor.Controls.Add(this.Btn_Empleados);
            this.Pnl_Contenedor.Controls.Add(this.Btn_Calendario_Vacunacion);
            this.Pnl_Contenedor.Controls.Add(this.Btn_Sucursales);
            this.Pnl_Contenedor.Controls.Add(this.Btn_Laboratorios);
            this.Pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Contenedor.Name = "Pnl_Contenedor";
            this.Pnl_Contenedor.Size = new System.Drawing.Size(784, 511);
            this.Pnl_Contenedor.TabIndex = 4;
            // 
            // Btn_Sintomas
            // 
            this.Btn_Sintomas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Sintomas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Sintomas.FlatAppearance.BorderSize = 2;
            this.Btn_Sintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sintomas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sintomas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sintomas.Image")));
            this.Btn_Sintomas.Location = new System.Drawing.Point(203, 201);
            this.Btn_Sintomas.Name = "Btn_Sintomas";
            this.Btn_Sintomas.Size = new System.Drawing.Size(150, 150);
            this.Btn_Sintomas.TabIndex = 2;
            this.Btn_Sintomas.Text = "Sintomas";
            this.Btn_Sintomas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Sintomas.UseVisualStyleBackColor = false;
            // 
            // Btn_Calendario_Vacunacion
            // 
            this.Btn_Calendario_Vacunacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Calendario_Vacunacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Calendario_Vacunacion.FlatAppearance.BorderSize = 2;
            this.Btn_Calendario_Vacunacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calendario_Vacunacion.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calendario_Vacunacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Calendario_Vacunacion.Image")));
            this.Btn_Calendario_Vacunacion.Location = new System.Drawing.Point(27, 201);
            this.Btn_Calendario_Vacunacion.Name = "Btn_Calendario_Vacunacion";
            this.Btn_Calendario_Vacunacion.Size = new System.Drawing.Size(150, 150);
            this.Btn_Calendario_Vacunacion.TabIndex = 1;
            this.Btn_Calendario_Vacunacion.Text = "Calendario Vacunas";
            this.Btn_Calendario_Vacunacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Calendario_Vacunacion.UseVisualStyleBackColor = false;
            // 
            // Frm_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.Pnl_Contenedor);
            this.Name = "Frm_Configuracion";
            this.Text = "Frm_Configuracion";
            this.Pnl_Contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Laboratorios;
        private System.Windows.Forms.Button Btn_Sucursales;
        private System.Windows.Forms.Button Btn_Empleados;
        private System.Windows.Forms.Button Btn_Razas;
        private System.Windows.Forms.Panel Pnl_Contenedor;
        private System.Windows.Forms.Button Btn_Calendario_Vacunacion;
        private System.Windows.Forms.Button Btn_Sintomas;
    }
}