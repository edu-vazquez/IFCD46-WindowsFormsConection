namespace WindowsFormsConection
{
    partial class FormEJ03
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
            this.tbxEstadoDeConeccion = new System.Windows.Forms.TextBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tbxJobTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMinSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaxSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEstadoDeConeccion
            // 
            this.tbxEstadoDeConeccion.BackColor = System.Drawing.Color.LightCoral;
            this.tbxEstadoDeConeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEstadoDeConeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEstadoDeConeccion.Location = new System.Drawing.Point(34, 29);
            this.tbxEstadoDeConeccion.Name = "tbxEstadoDeConeccion";
            this.tbxEstadoDeConeccion.Size = new System.Drawing.Size(289, 23);
            this.tbxEstadoDeConeccion.TabIndex = 4;
            this.tbxEstadoDeConeccion.Text = "Desconectado";
            this.tbxEstadoDeConeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(197, 79);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(126, 36);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(34, 79);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(126, 36);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(34, 327);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(289, 39);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar Datos";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tbxJobTitle
            // 
            this.tbxJobTitle.Location = new System.Drawing.Point(105, 241);
            this.tbxJobTitle.Name = "tbxJobTitle";
            this.tbxJobTitle.Size = new System.Drawing.Size(218, 20);
            this.tbxJobTitle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job Title";
            // 
            // tbxMinSalary
            // 
            this.tbxMinSalary.Location = new System.Drawing.Point(105, 267);
            this.tbxMinSalary.Name = "tbxMinSalary";
            this.tbxMinSalary.Size = new System.Drawing.Size(218, 20);
            this.tbxMinSalary.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min Salary";
            // 
            // tbxMaxSalary
            // 
            this.tbxMaxSalary.Location = new System.Drawing.Point(105, 293);
            this.tbxMaxSalary.Name = "tbxMaxSalary";
            this.tbxMaxSalary.Size = new System.Drawing.Size(218, 20);
            this.tbxMaxSalary.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Salary";
            // 
            // FormEJ03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
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
            this.Name = "FormEJ03";
            this.Text = "FormEJ03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEstadoDeConeccion;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tbxJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMinSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaxSalary;
        private System.Windows.Forms.Label label3;
    }
}