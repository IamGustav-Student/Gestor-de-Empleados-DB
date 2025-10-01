namespace GestorEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnBorrar = new Button();
            btnimprimirprofesion = new Button();
            btnupdate = new Button();
            btnImprimir = new Button();
            txtNombre = new TextBox();
            txtProfesion = new TextBox();
            txtSueldo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtLegajo = new TextBox();
            label1 = new Label();
            btnCargar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnimprimirprofesion);
            groupBox1.Controls.Add(btnupdate);
            groupBox1.Controls.Add(btnImprimir);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtProfesion);
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLegajo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(171, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(123, 23);
            txtApellido.TabIndex = 16;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(65, 128);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label5_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(420, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 38);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(530, 264);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 38);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(431, 264);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 38);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnimprimirprofesion
            // 
            btnimprimirprofesion.Location = new Point(332, 264);
            btnimprimirprofesion.Name = "btnimprimirprofesion";
            btnimprimirprofesion.Size = new Size(75, 38);
            btnimprimirprofesion.TabIndex = 11;
            btnimprimirprofesion.Text = "Buscar Por Profesion";
            btnimprimirprofesion.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(241, 264);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 38);
            btnupdate.TabIndex = 10;
            btnupdate.Text = "Modificar";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(146, 264);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 38);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(171, 173);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(123, 23);
            txtProfesion.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(171, 218);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(123, 23);
            txtSueldo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 221);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 176);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Profesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(171, 22);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(123, 23);
            txtLegajo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Legajo";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(52, 264);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 38);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 179);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 588);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalir;
        private Button btnBorrar;
        private Button btnimprimirprofesion;
        private Button btnupdate;
        private Button btnImprimir;
        private TextBox txtNombre;
        private TextBox txtProfesion;
        private TextBox txtSueldo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtLegajo;
        private Label label1;
        private Button btnCargar;
        private Button btnLimpiar;
        private DataGridView dataGridView1;
        private Label lblApellido;
        private TextBox txtApellido;
    }
}
