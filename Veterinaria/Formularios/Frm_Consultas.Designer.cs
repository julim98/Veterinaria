namespace Veterinaria.Vista
{
    partial class Frm_Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consultas));
            this.Btn_Cerrar_ABM = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Tbl_Consultas = new System.Windows.Forms.DataGridView();
            this.HistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nro_Historia_Clinica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cerrar_ABM
            // 
            this.Btn_Cerrar_ABM.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar_ABM.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cerrar_ABM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Cerrar_ABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar_ABM.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar_ABM.Image")));
            this.Btn_Cerrar_ABM.Location = new System.Drawing.Point(10, 10);
            this.Btn_Cerrar_ABM.Name = "Btn_Cerrar_ABM";
            this.Btn_Cerrar_ABM.Size = new System.Drawing.Size(20, 20);
            this.Btn_Cerrar_ABM.TabIndex = 31;
            this.Btn_Cerrar_ABM.UseVisualStyleBackColor = true;
            this.Btn_Cerrar_ABM.Click += new System.EventHandler(this.Btn_Cerrar_ABM_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(682, 104);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(91, 23);
            this.Btn_Buscar.TabIndex = 30;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Nuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_Nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Location = new System.Drawing.Point(467, 448);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(98, 50);
            this.Btn_Nuevo.TabIndex = 29;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(571, 448);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(98, 50);
            this.Btn_Modificar.TabIndex = 28;
            this.Btn_Modificar.Text = " Editar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(675, 448);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(98, 50);
            this.Btn_Eliminar.TabIndex = 27;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Tbl_Consultas
            // 
            this.Tbl_Consultas.AllowUserToAddRows = false;
            this.Tbl_Consultas.AllowUserToDeleteRows = false;
            this.Tbl_Consultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbl_Consultas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.Tbl_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_Consultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoriaClinica,
            this.Sucursal,
            this.Empleado,
            this.Entrada,
            this.Salida});
            this.Tbl_Consultas.Location = new System.Drawing.Point(13, 133);
            this.Tbl_Consultas.Name = "Tbl_Consultas";
            this.Tbl_Consultas.ReadOnly = true;
            this.Tbl_Consultas.Size = new System.Drawing.Size(760, 309);
            this.Tbl_Consultas.TabIndex = 26;
            // 
            // HistoriaClinica
            // 
            this.HistoriaClinica.HeaderText = "N° Historia Clinica";
            this.HistoriaClinica.Name = "HistoriaClinica";
            this.HistoriaClinica.ReadOnly = true;
            this.HistoriaClinica.Width = 90;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 90;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "CONSULTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Nro_Historia_Clinica
            // 
            this.Txt_Nro_Historia_Clinica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Nro_Historia_Clinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nro_Historia_Clinica.Location = new System.Drawing.Point(152, 104);
            this.Txt_Nro_Historia_Clinica.Name = "Txt_Nro_Historia_Clinica";
            this.Txt_Nro_Historia_Clinica.Size = new System.Drawing.Size(200, 22);
            this.Txt_Nro_Historia_Clinica.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "N° Historia Clinica:";
            // 
            // Frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.Txt_Nro_Historia_Clinica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Cerrar_ABM);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Tbl_Consultas);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Consultas";
            this.Text = "Frm_Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Consultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cerrar_ABM;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridView Tbl_Consultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.TextBox Txt_Nro_Historia_Clinica;
        private System.Windows.Forms.Label label2;
    }
}