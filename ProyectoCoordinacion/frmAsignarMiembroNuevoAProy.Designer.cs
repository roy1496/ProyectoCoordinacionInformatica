﻿namespace Vista
{
    partial class frmAsignarMiembroAProyecto
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
            this.lvProyectosGeneral = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProyectosAsignados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAsignarProyecto = new System.Windows.Forms.Button();
            this.btnRetitarProyecto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvProyectosGeneral
            // 
            this.lvProyectosGeneral.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProyectosGeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.nombre});
            this.lvProyectosGeneral.FullRowSelect = true;
            this.lvProyectosGeneral.GridLines = true;
            this.lvProyectosGeneral.Location = new System.Drawing.Point(38, 48);
            this.lvProyectosGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvProyectosGeneral.Name = "lvProyectosGeneral";
            this.lvProyectosGeneral.Size = new System.Drawing.Size(261, 296);
            this.lvProyectosGeneral.TabIndex = 3;
            this.lvProyectosGeneral.UseCompatibleStateImageBehavior = false;
            this.lvProyectosGeneral.View = System.Windows.Forms.View.Details;
            this.lvProyectosGeneral.SelectedIndexChanged += new System.EventHandler(this.lvProyectosGeneral_SelectedIndexChanged);
            this.lvProyectosGeneral.DoubleClick += new System.EventHandler(this.btnSalir_Click);
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            this.codigo.Width = 142;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 201;
            // 
            // lvProyectosAsignados
            // 
            this.lvProyectosAsignados.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProyectosAsignados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProyectosAsignados.FullRowSelect = true;
            this.lvProyectosAsignados.GridLines = true;
            this.lvProyectosAsignados.Location = new System.Drawing.Point(403, 48);
            this.lvProyectosAsignados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvProyectosAsignados.Name = "lvProyectosAsignados";
            this.lvProyectosAsignados.Size = new System.Drawing.Size(261, 296);
            this.lvProyectosAsignados.TabIndex = 4;
            this.lvProyectosAsignados.UseCompatibleStateImageBehavior = false;
            this.lvProyectosAsignados.View = System.Windows.Forms.View.Details;
            this.lvProyectosAsignados.SelectedIndexChanged += new System.EventHandler(this.lvProyectosAsignados_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 201;
            // 
            // btnAsignarProyecto
            // 
            this.btnAsignarProyecto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsignarProyecto.Enabled = false;
            this.btnAsignarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAsignarProyecto.FlatAppearance.BorderSize = 2;
            this.btnAsignarProyecto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAsignarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAsignarProyecto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarProyecto.ForeColor = System.Drawing.Color.Black;
            this.btnAsignarProyecto.Location = new System.Drawing.Point(310, 122);
            this.btnAsignarProyecto.Name = "btnAsignarProyecto";
            this.btnAsignarProyecto.Size = new System.Drawing.Size(77, 37);
            this.btnAsignarProyecto.TabIndex = 24;
            this.btnAsignarProyecto.Text = "Asignar";
            this.btnAsignarProyecto.UseVisualStyleBackColor = false;
            this.btnAsignarProyecto.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRetitarProyecto
            // 
            this.btnRetitarProyecto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRetitarProyecto.Enabled = false;
            this.btnRetitarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetitarProyecto.FlatAppearance.BorderSize = 2;
            this.btnRetitarProyecto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnRetitarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRetitarProyecto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetitarProyecto.ForeColor = System.Drawing.Color.Black;
            this.btnRetitarProyecto.Location = new System.Drawing.Point(310, 192);
            this.btnRetitarProyecto.Name = "btnRetitarProyecto";
            this.btnRetitarProyecto.Size = new System.Drawing.Size(77, 37);
            this.btnRetitarProyecto.TabIndex = 25;
            this.btnRetitarProyecto.Text = "Retirar";
            this.btnRetitarProyecto.UseVisualStyleBackColor = false;
            this.btnRetitarProyecto.Click += new System.EventHandler(this.btnRetitarProyecto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(586, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Listo";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Proyectos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Proyectos asignados:";
            // 
            // frmAsignarMiembroAProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCoordinacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 448);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRetitarProyecto);
            this.Controls.Add(this.btnAsignarProyecto);
            this.Controls.Add(this.lvProyectosAsignados);
            this.Controls.Add(this.lvProyectosGeneral);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAsignarMiembroAProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaRapProyecto";
            this.Load += new System.EventHandler(this.frmConsultaRapProyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvProyectosGeneral;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ListView lvProyectosAsignados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAsignarProyecto;
        private System.Windows.Forms.Button btnRetitarProyecto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}