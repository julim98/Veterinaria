namespace Veterinaria
{
    partial class Frm_Perros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Perros));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Nombr = new System.Windows.Forms.TextBox();
            this.Txt_Dueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Cerrar_ABM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE PERROS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(681, 95);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(91, 23);
            this.Btn_Buscar.TabIndex = 23;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click_1);
            // 
            // Txt_Nombr
            // 
            this.Txt_Nombr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Nombr.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombr.Location = new System.Drawing.Point(392, 95);
            this.Txt_Nombr.Name = "Txt_Nombr";
            this.Txt_Nombr.Size = new System.Drawing.Size(200, 23);
            this.Txt_Nombr.TabIndex = 22;
            this.Txt_Nombr.TextChanged += new System.EventHandler(this.Txt_Nombr_TextChanged_1);
            // 
            // Txt_Dueño
            // 
            this.Txt_Dueño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Dueño.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dueño.Location = new System.Drawing.Point(73, 95);
            this.Txt_Dueño.Name = "Txt_Dueño";
            this.Txt_Dueño.Size = new System.Drawing.Size(200, 23);
            this.Txt_Dueño.TabIndex = 21;
            this.Txt_Dueño.TextChanged += new System.EventHandler(this.Txt_Dueño_TextChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dueño:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Nuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_Nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Location = new System.Drawing.Point(466, 439);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(98, 50);
            this.Btn_Nuevo.TabIndex = 18;
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
            this.Btn_Modificar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(570, 439);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(98, 50);
            this.Btn_Modificar.TabIndex = 17;
            this.Btn_Modificar.Text = " Editar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click_1);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(674, 439);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(98, 50);
            this.Btn_Eliminar.TabIndex = 16;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoriaClinica,
            this.nombre,
            this.FechaNacimiento,
            this.Raza,
            this.Dueño,
            this.Peso,
            this.Altura,
            this.Sucursal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 309);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // HistoriaClinica
            // 
            this.HistoriaClinica.HeaderText = "N° Historia Clinica";
            this.HistoriaClinica.Name = "HistoriaClinica";
            this.HistoriaClinica.ReadOnly = true;
            this.HistoriaClinica.Width = 90;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 89;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 90;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            this.Raza.Width = 90;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Dueño";
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            this.Dueño.Width = 89;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 90;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 89;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 90;
            // 
            // Btn_Cerrar_ABM
            // 
            this.Btn_Cerrar_ABM.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar_ABM.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cerrar_ABM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Cerrar_ABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar_ABM.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar_ABM.Image")));
            this.Btn_Cerrar_ABM.Location = new System.Drawing.Point(12, 9);
            this.Btn_Cerrar_ABM.Name = "Btn_Cerrar_ABM";
            this.Btn_Cerrar_ABM.Size = new System.Drawing.Size(20, 20);
            this.Btn_Cerrar_ABM.TabIndex = 24;
            this.Btn_Cerrar_ABM.UseVisualStyleBackColor = true;
            this.Btn_Cerrar_ABM.Click += new System.EventHandler(this.Btn_Cerrar_ABM_Click);
            // 
            // Frm_Perros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.Btn_Cerrar_ABM);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Nombr);
            this.Controls.Add(this.Txt_Dueño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Perros";
            this.Text = "Frm_Perros";
            this.Load += new System.EventHandler(this.Frm_Perros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Nombr;
        private System.Windows.Forms.TextBox Txt_Dueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.Button Btn_Cerrar_ABM;
    }
}