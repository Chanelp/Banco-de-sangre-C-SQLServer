
namespace Proyecto_Final
{
    partial class ReporteDonantes
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
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnVolver3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbFactorRH = new System.Windows.Forms.ComboBox();
            this.cmbGrupoS = new System.Windows.Forms.ComboBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblRH = new System.Windows.Forms.Label();
            this.lblGS = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporte
            // 
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(-2, 184);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(741, 328);
            this.dgvReporte.TabIndex = 25;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Salmon;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(304, 133);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(131, 35);
            this.btnReporte.TabIndex = 23;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnVolver3
            // 
            this.btnVolver3.BackColor = System.Drawing.Color.Salmon;
            this.btnVolver3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver3.Location = new System.Drawing.Point(262, 518);
            this.btnVolver3.Name = "btnVolver3";
            this.btnVolver3.Size = new System.Drawing.Size(95, 35);
            this.btnVolver3.TabIndex = 21;
            this.btnVolver3.Text = "Volver";
            this.btnVolver3.UseVisualStyleBackColor = false;
            this.btnVolver3.Click += new System.EventHandler(this.btnVolver3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final.Properties.Resources.icon62;
            this.pictureBox2.Location = new System.Drawing.Point(262, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Salmon;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(808, 497);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Actualizar datos";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(936, 497);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 35);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // cmbFactorRH
            // 
            this.cmbFactorRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactorRH.FormattingEnabled = true;
            this.cmbFactorRH.Items.AddRange(new object[] {
            "A negativo",
            "A positivo",
            "B negativo",
            "B positivo",
            "AB negativo",
            "AB positivo",
            "0 negativo",
            "0 positivo"});
            this.cmbFactorRH.Location = new System.Drawing.Point(767, 398);
            this.cmbFactorRH.Name = "cmbFactorRH";
            this.cmbFactorRH.Size = new System.Drawing.Size(289, 24);
            this.cmbFactorRH.TabIndex = 38;
            // 
            // cmbGrupoS
            // 
            this.cmbGrupoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupoS.FormattingEnabled = true;
            this.cmbGrupoS.Items.AddRange(new object[] {
            "Grupo A",
            "Grupo B",
            "Grupo AB",
            "Grupo 0"});
            this.cmbGrupoS.Location = new System.Drawing.Point(767, 346);
            this.cmbGrupoS.Name = "cmbGrupoS";
            this.cmbGrupoS.Size = new System.Drawing.Size(289, 24);
            this.cmbGrupoS.TabIndex = 37;
            // 
            // txtTelef
            // 
            this.txtTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelef.Location = new System.Drawing.Point(767, 455);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(289, 24);
            this.txtTelef.TabIndex = 36;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(767, 295);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(289, 24);
            this.txtApellido.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(767, 244);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 24);
            this.txtNombre.TabIndex = 34;
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTelef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(773, 436);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(60, 14);
            this.lblTelef.TabIndex = 33;
            this.lblTelef.Text = "Teléfono";
            // 
            // lblRH
            // 
            this.lblRH.AutoSize = true;
            this.lblRH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRH.Location = new System.Drawing.Point(773, 381);
            this.lblRH.Name = "lblRH";
            this.lblRH.Size = new System.Drawing.Size(66, 14);
            this.lblRH.TabIndex = 32;
            this.lblRH.Text = "Factor RH";
            // 
            // lblGS
            // 
            this.lblGS.AutoSize = true;
            this.lblGS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGS.Location = new System.Drawing.Point(773, 328);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(116, 14);
            this.lblGS.TabIndex = 31;
            this.lblGS.Text = "Grupo Sanguíneo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(773, 276);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 14);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(773, 225);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 14);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(767, 192);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 24);
            this.txtID.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(773, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // ReporteDonantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 582);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFactorRH);
            this.Controls.Add(this.cmbGrupoS);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelef);
            this.Controls.Add(this.lblRH);
            this.Controls.Add(this.lblGS);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnVolver3);
            this.Name = "ReporteDonantes";
            this.Text = "ReporteDonantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnVolver3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbFactorRH;
        private System.Windows.Forms.ComboBox cmbGrupoS;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblRH;
        private System.Windows.Forms.Label lblGS;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}