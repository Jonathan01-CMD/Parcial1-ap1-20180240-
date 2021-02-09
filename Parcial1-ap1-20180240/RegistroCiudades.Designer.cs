
namespace Parcial1_ap1_20180240
{
    partial class RegistroCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCiudad));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonNuevo = new System.Windows.Forms.Button();
            this.NombreCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.NumeroCiudad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.BotonEliminar);
            this.groupBox1.Controls.Add(this.BotonGuardar);
            this.groupBox1.Controls.Add(this.BotonNuevo);
            this.groupBox1.Controls.Add(this.NombreCiudad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BotonBuscar);
            this.groupBox1.Controls.Add(this.NumeroCiudad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.Image")));
            this.BotonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonEliminar.Location = new System.Drawing.Point(206, 220);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(85, 44);
            this.BotonEliminar.TabIndex = 7;
            this.BotonEliminar.Text = "Nuevo";
            this.BotonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonEliminar.UseVisualStyleBackColor = true;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BotonGuardar.Image")));
            this.BotonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonGuardar.Location = new System.Drawing.Point(113, 220);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(87, 44);
            this.BotonGuardar.TabIndex = 6;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonNuevo
            // 
            this.BotonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BotonNuevo.Image")));
            this.BotonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonNuevo.Location = new System.Drawing.Point(21, 220);
            this.BotonNuevo.Name = "BotonNuevo";
            this.BotonNuevo.Size = new System.Drawing.Size(86, 44);
            this.BotonNuevo.TabIndex = 5;
            this.BotonNuevo.Text = "Nuevo";
            this.BotonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonNuevo.UseVisualStyleBackColor = true;
            // 
            // NombreCiudad
            // 
            this.NombreCiudad.Location = new System.Drawing.Point(6, 162);
            this.NombreCiudad.Name = "NombreCiudad";
            this.NombreCiudad.Size = new System.Drawing.Size(161, 23);
            this.NombreCiudad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BotonBuscar.Image")));
            this.BotonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonBuscar.Location = new System.Drawing.Point(142, 69);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(92, 41);
            this.BotonBuscar.TabIndex = 2;
            this.BotonBuscar.Text = "BUSCAR";
            this.BotonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // NumeroCiudad
            // 
            this.NumeroCiudad.Location = new System.Drawing.Point(6, 79);
            this.NumeroCiudad.Name = "NumeroCiudad";
            this.NumeroCiudad.Size = new System.Drawing.Size(130, 23);
            this.NumeroCiudad.TabIndex = 1;
            // 
            // RegistroCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroCiudad";
            this.Text = "Registro de Ciudades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonNuevo;
        private System.Windows.Forms.TextBox NombreCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.TextBox NumeroCiudad;
    }
}

