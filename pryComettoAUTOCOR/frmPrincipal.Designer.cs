﻿namespace pryComettoAUTOCOR
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mrcRepuesto = new System.Windows.Forms.GroupBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcRepuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // mrcRepuesto
            // 
            this.mrcRepuesto.Controls.Add(this.lblOrigen);
            this.mrcRepuesto.Controls.Add(this.optNacional);
            this.mrcRepuesto.Controls.Add(this.optImportado);
            this.mrcRepuesto.Controls.Add(this.txtPrecio);
            this.mrcRepuesto.Controls.Add(this.lblMarca);
            this.mrcRepuesto.Controls.Add(this.txtNombre);
            this.mrcRepuesto.Controls.Add(this.lblPrecio);
            this.mrcRepuesto.Controls.Add(this.lblNombre);
            this.mrcRepuesto.Controls.Add(this.txtCodigo);
            this.mrcRepuesto.Controls.Add(this.cmbMarca);
            this.mrcRepuesto.Controls.Add(this.lblCodigo);
            this.mrcRepuesto.Location = new System.Drawing.Point(12, 12);
            this.mrcRepuesto.Name = "mrcRepuesto";
            this.mrcRepuesto.Size = new System.Drawing.Size(243, 201);
            this.mrcRepuesto.TabIndex = 1;
            this.mrcRepuesto.TabStop = false;
            this.mrcRepuesto.Text = "Repuesto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 115);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(62, 85);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(173, 21);
            this.cmbMarca.TabIndex = 2;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(135, 171);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 4;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 88);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(62, 112);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(80, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Checked = true;
            this.optNacional.Location = new System.Drawing.Point(62, 171);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 9;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 173);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 10;
            this.lblOrigen.Text = "Origen";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(287, 17);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(81, 44);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(287, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(81, 44);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(287, 169);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 235);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcRepuesto);
            this.Name = "frmPrincipal";
            this.Text = "Registro de Repuestos";
            this.mrcRepuesto.ResumeLayout(false);
            this.mrcRepuesto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox mrcRepuesto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
    }
}
