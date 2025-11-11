namespace WindowsFormsConection
{
    partial class FormEJ05
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaxSalary = new System.Windows.Forms.TextBox();
            this.tbxMinSalary = new System.Windows.Forms.TextBox();
            this.tbxJobTitle = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tbxEstadoDeConeccion = new System.Windows.Forms.TextBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Max Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Min Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Job Title";
            // 
            // tbxMaxSalary
            // 
            this.tbxMaxSalary.Location = new System.Drawing.Point(107, 242);
            this.tbxMaxSalary.Name = "tbxMaxSalary";
            this.tbxMaxSalary.Size = new System.Drawing.Size(218, 20);
            this.tbxMaxSalary.TabIndex = 19;
            // 
            // tbxMinSalary
            // 
            this.tbxMinSalary.Location = new System.Drawing.Point(107, 216);
            this.tbxMinSalary.Name = "tbxMinSalary";
            this.tbxMinSalary.Size = new System.Drawing.Size(218, 20);
            this.tbxMinSalary.TabIndex = 20;
            // 
            // tbxJobTitle
            // 
            this.tbxJobTitle.Location = new System.Drawing.Point(107, 190);
            this.tbxJobTitle.Name = "tbxJobTitle";
            this.tbxJobTitle.Size = new System.Drawing.Size(218, 20);
            this.tbxJobTitle.TabIndex = 21;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(36, 276);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(289, 39);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "Insertar Datos";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // tbxEstadoDeConeccion
            // 
            this.tbxEstadoDeConeccion.BackColor = System.Drawing.Color.LightCoral;
            this.tbxEstadoDeConeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEstadoDeConeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEstadoDeConeccion.Location = new System.Drawing.Point(36, 35);
            this.tbxEstadoDeConeccion.Name = "tbxEstadoDeConeccion";
            this.tbxEstadoDeConeccion.Size = new System.Drawing.Size(289, 23);
            this.tbxEstadoDeConeccion.TabIndex = 17;
            this.tbxEstadoDeConeccion.Text = "Desconectado";
            this.tbxEstadoDeConeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(199, 85);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(126, 36);
            this.btnDesconectar.TabIndex = 15;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(36, 85);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(126, 36);
            this.btnConectar.TabIndex = 16;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // FormEJ05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMaxSalary);
            this.Controls.Add(this.tbxMinSalary);
            this.Controls.Add(this.tbxJobTitle);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbxEstadoDeConeccion);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "FormEJ05";
            this.Text = "FormEJ05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaxSalary;
        private System.Windows.Forms.TextBox tbxMinSalary;
        private System.Windows.Forms.TextBox tbxJobTitle;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tbxEstadoDeConeccion;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
    }
}