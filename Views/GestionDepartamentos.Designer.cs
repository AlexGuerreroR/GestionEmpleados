namespace GestionEmpleados.Views
{
    partial class GestionDepartamentos
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_extension = new System.Windows.Forms.TextBox();
            this.txt_JefeDepartamento = new System.Windows.Forms.TextBox();
            this.txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Extensión = new System.Windows.Forms.Label();
            this.lbl_JefeDepartamento = new System.Windows.Forms.Label();
            this.lbl_Ubicacion = new System.Windows.Forms.Label();
            this.lbl_Departamentos = new System.Windows.Forms.Label();
            this.lst_Departamentos = new System.Windows.Forms.ListBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(35, 159);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(81, 25);
            this.lbl_Nombre.TabIndex = 32;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(198, 37);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(412, 39);
            this.lbl_Titulo.TabIndex = 31;
            this.lbl_Titulo.Text = "Gestor De Departamentos";
            // 
            // txt_extension
            // 
            this.txt_extension.Location = new System.Drawing.Point(33, 388);
            this.txt_extension.Name = "txt_extension";
            this.txt_extension.Size = new System.Drawing.Size(299, 30);
            this.txt_extension.TabIndex = 30;
            // 
            // txt_JefeDepartamento
            // 
            this.txt_JefeDepartamento.Location = new System.Drawing.Point(33, 315);
            this.txt_JefeDepartamento.Name = "txt_JefeDepartamento";
            this.txt_JefeDepartamento.Size = new System.Drawing.Size(299, 30);
            this.txt_JefeDepartamento.TabIndex = 29;
            // 
            // txt_Ubicacion
            // 
            this.txt_Ubicacion.Location = new System.Drawing.Point(33, 256);
            this.txt_Ubicacion.Name = "txt_Ubicacion";
            this.txt_Ubicacion.Size = new System.Drawing.Size(299, 30);
            this.txt_Ubicacion.TabIndex = 28;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(33, 187);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(299, 30);
            this.txt_Nombre.TabIndex = 27;
            // 
            // lbl_Extensión
            // 
            this.lbl_Extensión.AutoSize = true;
            this.lbl_Extensión.Location = new System.Drawing.Point(28, 360);
            this.lbl_Extensión.Name = "lbl_Extensión";
            this.lbl_Extensión.Size = new System.Drawing.Size(98, 25);
            this.lbl_Extensión.TabIndex = 26;
            this.lbl_Extensión.Text = "Extensión";
            // 
            // lbl_JefeDepartamento
            // 
            this.lbl_JefeDepartamento.AutoSize = true;
            this.lbl_JefeDepartamento.Location = new System.Drawing.Point(28, 289);
            this.lbl_JefeDepartamento.Name = "lbl_JefeDepartamento";
            this.lbl_JefeDepartamento.Size = new System.Drawing.Size(178, 25);
            this.lbl_JefeDepartamento.TabIndex = 25;
            this.lbl_JefeDepartamento.Text = "Jefe Departamento";
            // 
            // lbl_Ubicacion
            // 
            this.lbl_Ubicacion.AutoSize = true;
            this.lbl_Ubicacion.Location = new System.Drawing.Point(28, 228);
            this.lbl_Ubicacion.Name = "lbl_Ubicacion";
            this.lbl_Ubicacion.Size = new System.Drawing.Size(98, 25);
            this.lbl_Ubicacion.TabIndex = 24;
            this.lbl_Ubicacion.Text = "Ubicación";
            // 
            // lbl_Departamentos
            // 
            this.lbl_Departamentos.AutoSize = true;
            this.lbl_Departamentos.Location = new System.Drawing.Point(450, 97);
            this.lbl_Departamentos.Name = "lbl_Departamentos";
            this.lbl_Departamentos.Size = new System.Drawing.Size(218, 25);
            this.lbl_Departamentos.TabIndex = 23;
            this.lbl_Departamentos.Text = "Lista de Departamentos";
            // 
            // lst_Departamentos
            // 
            this.lst_Departamentos.FormattingEnabled = true;
            this.lst_Departamentos.ItemHeight = 25;
            this.lst_Departamentos.Location = new System.Drawing.Point(356, 125);
            this.lst_Departamentos.Name = "lst_Departamentos";
            this.lst_Departamentos.Size = new System.Drawing.Size(507, 329);
            this.lst_Departamentos.TabIndex = 22;
            this.lst_Departamentos.DoubleClick += new System.EventHandler(this.lst_Departamentos_DoubleClick);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(533, 498);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(123, 43);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(379, 498);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(123, 43);
            this.btn_Eliminar.TabIndex = 20;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(220, 498);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(123, 43);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(56, 498);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(123, 43);
            this.btn_Guardar.TabIndex = 18;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(693, 498);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(123, 43);
            this.btn_Regresar.TabIndex = 33;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // GestionDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 589);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_extension);
            this.Controls.Add(this.txt_JefeDepartamento);
            this.Controls.Add(this.txt_Ubicacion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Extensión);
            this.Controls.Add(this.lbl_JefeDepartamento);
            this.Controls.Add(this.lbl_Ubicacion);
            this.Controls.Add(this.lbl_Departamentos);
            this.Controls.Add(this.lst_Departamentos);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Guardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GestionDepartamentos";
            this.Text = "Gestión de Departamentos";
            this.Load += new System.EventHandler(this.GestionDepartamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_extension;
        private System.Windows.Forms.TextBox txt_JefeDepartamento;
        private System.Windows.Forms.TextBox txt_Ubicacion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Extensión;
        private System.Windows.Forms.Label lbl_JefeDepartamento;
        private System.Windows.Forms.Label lbl_Ubicacion;
        private System.Windows.Forms.Label lbl_Departamentos;
        private System.Windows.Forms.ListBox lst_Departamentos;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Regresar;
    }
}