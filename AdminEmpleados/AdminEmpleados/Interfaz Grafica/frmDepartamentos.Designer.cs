namespace AdminEmpleados.Interfaz_Grafica
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnAgregar_Dep = new System.Windows.Forms.Button();
            this.btnModificar_Dep = new System.Windows.Forms.Button();
            this.btnEliminar_Dep = new System.Windows.Forms.Button();
            this.btnCancelar_Dep = new System.Windows.Forms.Button();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(156, 48);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(277, 20);
            this.txtDepartamento.TabIndex = 2;
            // 
            // btnAgregar_Dep
            // 
            this.btnAgregar_Dep.Location = new System.Drawing.Point(40, 90);
            this.btnAgregar_Dep.Name = "btnAgregar_Dep";
            this.btnAgregar_Dep.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar_Dep.TabIndex = 3;
            this.btnAgregar_Dep.Text = "Agregar";
            this.btnAgregar_Dep.UseVisualStyleBackColor = true;
            this.btnAgregar_Dep.Click += new System.EventHandler(this.btnAgregar_Dep_Click);
            // 
            // btnModificar_Dep
            // 
            this.btnModificar_Dep.Location = new System.Drawing.Point(143, 90);
            this.btnModificar_Dep.Name = "btnModificar_Dep";
            this.btnModificar_Dep.Size = new System.Drawing.Size(75, 23);
            this.btnModificar_Dep.TabIndex = 4;
            this.btnModificar_Dep.Text = "Modificar";
            this.btnModificar_Dep.UseVisualStyleBackColor = true;
            this.btnModificar_Dep.Click += new System.EventHandler(this.btnModificar_Dep_Click);
            // 
            // btnEliminar_Dep
            // 
            this.btnEliminar_Dep.Location = new System.Drawing.Point(247, 90);
            this.btnEliminar_Dep.Name = "btnEliminar_Dep";
            this.btnEliminar_Dep.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar_Dep.TabIndex = 5;
            this.btnEliminar_Dep.Text = "Eliminar";
            this.btnEliminar_Dep.UseVisualStyleBackColor = true;
            this.btnEliminar_Dep.Click += new System.EventHandler(this.btnEliminar_Dep_Click);
            // 
            // btnCancelar_Dep
            // 
            this.btnCancelar_Dep.Location = new System.Drawing.Point(358, 90);
            this.btnCancelar_Dep.Name = "btnCancelar_Dep";
            this.btnCancelar_Dep.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_Dep.TabIndex = 6;
            this.btnCancelar_Dep.Text = "Cancelar";
            this.btnCancelar_Dep.UseVisualStyleBackColor = true;
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(40, 135);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.Size = new System.Drawing.Size(393, 183);
            this.dgvDepartamento.TabIndex = 7;
            this.dgvDepartamento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Departamento:";
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 340);
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
            this.Text = "frmDepartamentos";
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
    }
}