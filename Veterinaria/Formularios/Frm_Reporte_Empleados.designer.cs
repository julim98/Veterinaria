﻿namespace Veterinaria.Formularios
{
    partial class Frm_Reporte_Empleados
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
            this.datosempleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_empleados = new Veterinaria.Datos.datos_empleados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.datosempleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // datosempleadosBindingSource
            // 
            this.datosempleadosBindingSource.DataSource = this.datos_empleados;
            this.datosempleadosBindingSource.Position = 0;
            // 
            // datos_empleados
            // 
            this.datos_empleados.DataSetName = "datos_empleados";
            this.datos_empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosempleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Informes.informe_empleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Frm_Reporte_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Reporte_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosempleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Datos.datos_empleados datos_empleados;
        private System.Windows.Forms.BindingSource datosempleadosBindingSource;
    }
}