
namespace Proyecto_Final
{
    partial class BuscarDonante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarDonante));
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.donantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_20211120DataSet = new Proyecto_Final.BD_20211120DataSet();
            this.donantesTableAdapter = new Proyecto_Final.BD_20211120DataSetTableAdapters.DonantesTableAdapter();
            this.nuevoDonanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_20211120DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoDonanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.Location = new System.Drawing.Point(318, 419);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(95, 35);
            this.btnLimpiar2.TabIndex = 16;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Salmon;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(438, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver2
            // 
            this.btnVolver2.BackColor = System.Drawing.Color.Salmon;
            this.btnVolver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver2.Location = new System.Drawing.Point(217, 419);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(95, 35);
            this.btnVolver2.TabIndex = 14;
            this.btnVolver2.Text = "Volver";
            this.btnVolver2.UseVisualStyleBackColor = false;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final.Properties.Resources.search_magnifyng_glass_find_locate_icon_123485;
            this.pictureBox2.Location = new System.Drawing.Point(108, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources._9qkvh;
            this.pictureBox1.Location = new System.Drawing.Point(69, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // donantesBindingSource
            // 
            this.donantesBindingSource.DataMember = "Donantes";
            this.donantesBindingSource.DataSource = this.bD_20211120DataSet;
            // 
            // bD_20211120DataSet
            // 
            this.bD_20211120DataSet.DataSetName = "BD_20211120DataSet";
            this.bD_20211120DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donantesTableAdapter
            // 
            this.donantesTableAdapter.ClearBeforeFill = true;
            // 
            // nuevoDonanteBindingSource
            // 
            this.nuevoDonanteBindingSource.DataSource = typeof(Proyecto_Final.NuevoDonante);
            // 
            // conexionBindingSource
            // 
            this.conexionBindingSource.DataSource = typeof(Proyecto_Final.Conexion);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(203, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 29);
            this.txtID.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID";
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
            this.cmbFactorRH.Location = new System.Drawing.Point(165, 315);
            this.cmbFactorRH.Name = "cmbFactorRH";
            this.cmbFactorRH.Size = new System.Drawing.Size(289, 24);
            this.cmbFactorRH.TabIndex = 50;
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
            this.cmbGrupoS.Location = new System.Drawing.Point(165, 263);
            this.cmbGrupoS.Name = "cmbGrupoS";
            this.cmbGrupoS.Size = new System.Drawing.Size(289, 24);
            this.cmbGrupoS.TabIndex = 49;
            // 
            // txtTelef
            // 
            this.txtTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelef.Location = new System.Drawing.Point(165, 372);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(289, 24);
            this.txtTelef.TabIndex = 48;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(165, 212);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(289, 24);
            this.txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(165, 161);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 24);
            this.txtNombre.TabIndex = 46;
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTelef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(171, 353);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(60, 14);
            this.lblTelef.TabIndex = 45;
            this.lblTelef.Text = "Teléfono";
            // 
            // lblRH
            // 
            this.lblRH.AutoSize = true;
            this.lblRH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRH.Location = new System.Drawing.Point(171, 298);
            this.lblRH.Name = "lblRH";
            this.lblRH.Size = new System.Drawing.Size(66, 14);
            this.lblRH.TabIndex = 44;
            this.lblRH.Text = "Factor RH";
            // 
            // lblGS
            // 
            this.lblGS.AutoSize = true;
            this.lblGS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGS.Location = new System.Drawing.Point(171, 245);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(116, 14);
            this.lblGS.TabIndex = 43;
            this.lblGS.Text = "Grupo Sanguíneo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(171, 193);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 14);
            this.lblApellido.TabIndex = 42;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(171, 142);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 14);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre";
            // 
            // BuscarDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 469);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarDonante";
            this.Text = "Buscar Donante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_20211120DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoDonanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BD_20211120DataSet bD_20211120DataSet;
        private System.Windows.Forms.BindingSource donantesBindingSource;
        private BD_20211120DataSetTableAdapters.DonantesTableAdapter donantesTableAdapter;
        private System.Windows.Forms.BindingSource nuevoDonanteBindingSource;
        private System.Windows.Forms.BindingSource conexionBindingSource;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
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
    }
}