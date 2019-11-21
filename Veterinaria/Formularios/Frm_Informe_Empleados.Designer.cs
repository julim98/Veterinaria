namespace Veterinaria.Formularios
{
    partial class Frm_Informe_Empleados
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datos_Empleados = new Veterinaria.Datos.datos_empleados();
            this.datosEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datos_Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.empleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Informess.informe_empleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(723, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datos_Empleados
            // 
            this.datos_Empleados.DataSetName = "Datos_Empleados";
            this.datos_Empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosEmpleadosBindingSource
            // 
            this.datosEmpleadosBindingSource.DataSource = this.datos_Empleados;
            this.datosEmpleadosBindingSource.Position = 0;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.datosEmpleadosBindingSource;
            // 
            // Frm_Informe_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Informe_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Informe_Empleados";
            this.Load += new System.EventHandler(this.Frm_Informe_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.BindingSource datosEmpleadosBindingSource;
        private Datos.datos_empleados datos_Empleados;
    }
}