﻿namespace AdminEmpleados.Interfaz_Grafica
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnAgregar_Dep = new System.Windows.Forms.Button();
            this.btnModificar_Dep = new System.Windows.Forms.Button();
            this.btnEliminar_Dep = new System.Windows.Forms.Button();
            this.btnCancelar_Dep = new System.Windows.Forms.Button();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(32, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(148, 29);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(277, 20);
            this.txtDepartamento.TabIndex = 2;
            // 
            // btnAgregar_Dep
            // 
            this.btnAgregar_Dep.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar_Dep.Image")));
            this.btnAgregar_Dep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar_Dep.Location = new System.Drawing.Point(32, 63);
            this.btnAgregar_Dep.Name = "btnAgregar_Dep";
            this.btnAgregar_Dep.Size = new System.Drawing.Size(79, 39);
            this.btnAgregar_Dep.TabIndex = 3;
            this.btnAgregar_Dep.Text = "Agregar";
            this.btnAgregar_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar_Dep.UseVisualStyleBackColor = true;
            this.btnAgregar_Dep.Click += new System.EventHandler(this.btnAgregar_Dep_Click);
            // 
            // btnModificar_Dep
            // 
            this.btnModificar_Dep.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar_Dep.Image")));
            this.btnModificar_Dep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar_Dep.Location = new System.Drawing.Point(127, 63);
            this.btnModificar_Dep.Name = "btnModificar_Dep";
            this.btnModificar_Dep.Size = new System.Drawing.Size(88, 39);
            this.btnModificar_Dep.TabIndex = 4;
            this.btnModificar_Dep.Text = "Modificar";
            this.btnModificar_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar_Dep.UseVisualStyleBackColor = true;
            this.btnModificar_Dep.Click += new System.EventHandler(this.btnModificar_Dep_Click);
            // 
            // btnEliminar_Dep
            // 
            this.btnEliminar_Dep.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Dep.Image")));
            this.btnEliminar_Dep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar_Dep.Location = new System.Drawing.Point(235, 63);
            this.btnEliminar_Dep.Name = "btnEliminar_Dep";
            this.btnEliminar_Dep.Size = new System.Drawing.Size(83, 39);
            this.btnEliminar_Dep.TabIndex = 5;
            this.btnEliminar_Dep.Text = "Eliminar";
            this.btnEliminar_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar_Dep.UseVisualStyleBackColor = true;
            this.btnEliminar_Dep.Click += new System.EventHandler(this.btnEliminar_Dep_Click);
            // 
            // btnCancelar_Dep
            // 
            this.btnCancelar_Dep.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar_Dep.Image")));
            this.btnCancelar_Dep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar_Dep.Location = new System.Drawing.Point(339, 63);
            this.btnCancelar_Dep.Name = "btnCancelar_Dep";
            this.btnCancelar_Dep.Size = new System.Drawing.Size(86, 39);
            this.btnCancelar_Dep.TabIndex = 6;
            this.btnCancelar_Dep.Text = "Cancelar";
            this.btnCancelar_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar_Dep.UseVisualStyleBackColor = true;
            this.btnCancelar_Dep.Click += new System.EventHandler(this.btnCancelar_Dep_Click);
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(32, 116);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.Size = new System.Drawing.Size(393, 183);
            this.dgvDepartamento.TabIndex = 7;
            this.dgvDepartamento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Departamento:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(339, 305);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 37);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 344);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDepartamento);
            this.Controls.Add(this.btnCancelar_Dep);
            this.Controls.Add(this.btnEliminar_Dep);
            this.Controls.Add(this.btnModificar_Dep);
            this.Controls.Add(this.btnAgregar_Dep);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmDepartamentos";
            this.Text = "Gestion de Departamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnAgregar_Dep;
        private System.Windows.Forms.Button btnModificar_Dep;
        private System.Windows.Forms.Button btnEliminar_Dep;
        private System.Windows.Forms.Button btnCancelar_Dep;
        private System.Windows.Forms.DataGridView dgvDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
    }
}