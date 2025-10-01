
namespace GestorEmpleados
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            groupBoxUsuario = new GroupBox();
            groupBoxUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 84);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(202, 35);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(202, 81);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(123, 127);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // groupBoxUsuario
            // 
            groupBoxUsuario.Controls.Add(txtContraseña);
            groupBoxUsuario.Controls.Add(btnIngresar);
            groupBoxUsuario.Controls.Add(label1);
            groupBoxUsuario.Controls.Add(label2);
            groupBoxUsuario.Controls.Add(txtUsuario);
            groupBoxUsuario.Location = new Point(23, 14);
            groupBoxUsuario.Name = "groupBoxUsuario";
            groupBoxUsuario.Size = new Size(327, 156);
            groupBoxUsuario.TabIndex = 5;
            groupBoxUsuario.TabStop = false;
            groupBoxUsuario.Text = "Ingresar Usuario";
            groupBoxUsuario.Enter += groupBoxUsuario_Enter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 182);
            Controls.Add(groupBoxUsuario);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBoxUsuario.ResumeLayout(false);
            groupBoxUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private GroupBox groupBoxUsuario;
    }
}