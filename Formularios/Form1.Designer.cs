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
            btnBuscar = new Button();
            txtProfesion = new TextBox();
            cmbBuscar = new ComboBox();
            cmbProfesion = new ComboBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            btnupdate = new Button();
            btnmodificar = new Button();
            txtNombre = new TextBox();
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
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtProfesion);
            groupBox1.Controls.Add(cmbBuscar);
            groupBox1.Controls.Add(cmbProfesion);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnupdate);
            groupBox1.Controls.Add(btnmodificar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLegajo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(458, 177);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 35);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(358, 218);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(254, 25);
            txtProfesion.TabIndex = 19;
            txtProfesion.TextChanged += txtProfesion_TextChanged;
            // 
            // cmbBuscar
            // 
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(431, 128);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(121, 25);
            cmbBuscar.TabIndex = 18;
            cmbBuscar.SelectedIndexChanged += cmbBuscar_SelectedIndexChanged;
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Location = new Point(173, 170);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(121, 25);
            cmbProfesion.TabIndex = 17;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(171, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(123, 25);
            txtApellido.TabIndex = 16;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = SystemColors.ButtonHighlight;
            lblApellido.BorderStyle = BorderStyle.Fixed3D;
            lblApellido.Location = new Point(65, 128);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(458, 25);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 45);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(525, 264);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 35);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.Location = new Point(246, 262);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 35);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(338, 262);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(431, 262);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 35);
            btnupdate.TabIndex = 10;
            btnupdate.Text = "Modificar";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(147, 262);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(75, 35);
            btnmodificar.TabIndex = 9;
            btnmodificar.Text = "Imprimir";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnImprimir_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(171, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 25);
            txtNombre.TabIndex = 8;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(171, 218);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(123, 25);
            txtSueldo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(65, 221);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 5;
            label4.Text = "Sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(65, 176);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 4;
            label3.Text = "Profesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(65, 76);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(171, 22);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(123, 25);
            txtLegajo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(65, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 1;
            label1.Text = "Legajo";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Lime;
            btnCargar.Location = new Point(49, 262);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 35);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Nuevo";
            btnCargar.UseVisualStyleBackColor = false;
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
            ClientSize = new Size(696, 564);
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
        private Button btnGuardar;
        private Button btnupdate;
        private Button btnmodificar;
        private TextBox txtNombre;
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
        private ComboBox cmbBuscar;
        private ComboBox cmbProfesion;
        private Button btnBuscar;
        private TextBox txtProfesion;
    }
}
