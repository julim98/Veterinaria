namespace Veterinaria.Formularios
{
    partial class Frm_Informes
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
            this.Btn_Empleados = new System.Windows.Forms.Button();
            this.btn_diagnosticos = new System.Windows.Forms.Button();
            this.btn_vacunas = new System.Windows.Forms.Button();
            this.btn_razas = new System.Windows.Forms.Button();
            this.btn_medicamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Empleados
            // 
            this.Btn_Empleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Empleados.FlatAppearance.BorderSize = 2;
            this.Btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Empleados.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empleados.Location = new System.Drawing.Point(12, 12);
            this.Btn_Empleados.Name = "Btn_Empleados";
            this.Btn_Empleados.Size = new System.Drawing.Size(360, 80);
            this.Btn_Empleados.TabIndex = 1;
            this.Btn_Empleados.Text = "Empleados";
            this.Btn_Empleados.UseVisualStyleBackColor = false;
            this.Btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // btn_diagnosticos
            // 
            this.btn_diagnosticos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_diagnosticos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_diagnosticos.FlatAppearance.BorderSize = 2;
            this.btn_diagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosticos.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diagnosticos.Location = new System.Drawing.Point(392, 12);
            this.btn_diagnosticos.Name = "btn_diagnosticos";
            this.btn_diagnosticos.Size = new System.Drawing.Size(360, 80);
            this.btn_diagnosticos.TabIndex = 2;
            this.btn_diagnosticos.Text = "Diagnosticos";
            this.btn_diagnosticos.UseVisualStyleBackColor = false;
            // 
            // btn_vacunas
            // 
            this.btn_vacunas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vacunas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vacunas.FlatAppearance.BorderSize = 2;
            this.btn_vacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vacunas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vacunas.Location = new System.Drawing.Point(12, 114);
            this.btn_vacunas.Name = "btn_vacunas";
            this.btn_vacunas.Size = new System.Drawing.Size(360, 80);
            this.btn_vacunas.TabIndex = 3;
            this.btn_vacunas.Text = "Vacunas";
            this.btn_vacunas.UseVisualStyleBackColor = false;
            this.btn_vacunas.Click += new System.EventHandler(this.btn_vacunas_Click);
            // 
            // btn_razas
            // 
            this.btn_razas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_razas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_razas.FlatAppearance.BorderSize = 2;
            this.btn_razas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_razas.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_razas.Location = new System.Drawing.Point(392, 114);
            this.btn_razas.Name = "btn_razas";
            this.btn_razas.Size = new System.Drawing.Size(360, 80);
            this.btn_razas.TabIndex = 4;
            this.btn_razas.Text = "Razas";
            this.btn_razas.UseVisualStyleBackColor = false;
            this.btn_razas.Click += new System.EventHandler(this.btn_razas_Click);
            // 
            // btn_medicamentos
            // 
            this.btn_medicamentos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_medicamentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_medicamentos.FlatAppearance.BorderSize = 2;
            this.btn_medicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicamentos.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medicamentos.Location = new System.Drawing.Point(12, 215);
            this.btn_medicamentos.Name = "btn_medicamentos";
            this.btn_medicamentos.Size = new System.Drawing.Size(360, 80);
            this.btn_medicamentos.TabIndex = 5;
            this.btn_medicamentos.Text = "Medicamentos";
            this.btn_medicamentos.UseVisualStyleBackColor = false;
            this.btn_medicamentos.Click += new System.EventHandler(this.btn_medicamentos_Click);
            // 
            // Frm_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_medicamentos);
            this.Controls.Add(this.btn_razas);
            this.Controls.Add(this.btn_vacunas);
            this.Controls.Add(this.btn_diagnosticos);
            this.Controls.Add(this.Btn_Empleados);
            this.Name = "Frm_Informes";
            this.Text = "Frm_Informes";
            this.Load += new System.EventHandler(this.Frm_Informes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Empleados;
        private System.Windows.Forms.Button btn_diagnosticos;
        private System.Windows.Forms.Button btn_vacunas;
        private System.Windows.Forms.Button btn_razas;
        private System.Windows.Forms.Button btn_medicamentos;
    }
}