﻿namespace Veterinaria.Formularios
{
    partial class Frm_Reporte_Laboratorios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datoslaboratoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_laboratorios = new Veterinaria.Datos.datos_laboratorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.datoslaboratoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_laboratorios)).BeginInit();
            this.SuspendLayout();
            // 
            // datoslaboratoriosBindingSource
            // 
            this.datoslaboratoriosBindingSource.DataSource = this.datos_laboratorios;
            this.datoslaboratoriosBindingSource.Position = 0;
            // 
            // datos_laboratorios
            // 
            this.datos_laboratorios.DataSetName = "datos_laboratorios";
            this.datos_laboratorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.datoslaboratoriosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Informes.informe_laboratorios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Frm_Reporte_Laboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Laboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Reporte_Laboratorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datoslaboratoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_laboratorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datoslaboratoriosBindingSource;
        private Datos.datos_laboratorios datos_laboratorios;
    }
}