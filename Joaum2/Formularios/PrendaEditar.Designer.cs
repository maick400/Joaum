namespace Joaum2.Formularios
{
    partial class PrendaAgregar
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
            this.grpDatosGenerales = new System.Windows.Forms.GroupBox();
            this.grpColores = new System.Windows.Forms.GroupBox();
            this.btnColorElim = new System.Windows.Forms.Button();
            this.btnColorAgre = new System.Windows.Forms.Button();
            this.dgvColores = new System.Windows.Forms.DataGridView();
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.btnStockElim = new System.Windows.Forms.Button();
            this.btnStockEditar = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImgDrop = new System.Windows.Forms.Button();
            this.btnImgAgre = new System.Windows.Forms.Button();
            this.btnImgSiguiente = new System.Windows.Forms.Button();
            this.btnImgAnterior = new System.Windows.Forms.Button();
            this.picImagenes = new System.Windows.Forms.PictureBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTela = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ofdImagenes = new System.Windows.Forms.OpenFileDialog();
            this.cbxUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDatosGenerales.SuspendLayout();
            this.grpColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).BeginInit();
            this.grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosGenerales
            // 
            this.grpDatosGenerales.Controls.Add(this.cbxUnidad);
            this.grpDatosGenerales.Controls.Add(this.label5);
            this.grpDatosGenerales.Controls.Add(this.grpColores);
            this.grpDatosGenerales.Controls.Add(this.grpStock);
            this.grpDatosGenerales.Controls.Add(this.txtDescripcion);
            this.grpDatosGenerales.Controls.Add(this.label8);
            this.grpDatosGenerales.Controls.Add(this.cbxMaterial);
            this.grpDatosGenerales.Controls.Add(this.label7);
            this.grpDatosGenerales.Controls.Add(this.groupBox2);
            this.grpDatosGenerales.Controls.Add(this.cbxGenero);
            this.grpDatosGenerales.Controls.Add(this.label4);
            this.grpDatosGenerales.Controls.Add(this.cbxCategoria);
            this.grpDatosGenerales.Controls.Add(this.label3);
            this.grpDatosGenerales.Controls.Add(this.cbxTela);
            this.grpDatosGenerales.Controls.Add(this.label2);
            this.grpDatosGenerales.Controls.Add(this.txtNombre);
            this.grpDatosGenerales.Controls.Add(this.label1);
            this.grpDatosGenerales.Location = new System.Drawing.Point(12, 12);
            this.grpDatosGenerales.Name = "grpDatosGenerales";
            this.grpDatosGenerales.Size = new System.Drawing.Size(958, 490);
            this.grpDatosGenerales.TabIndex = 0;
            this.grpDatosGenerales.TabStop = false;
            this.grpDatosGenerales.Text = "Datos Generales ";
            this.grpDatosGenerales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpColores
            // 
            this.grpColores.Controls.Add(this.btnColorElim);
            this.grpColores.Controls.Add(this.btnColorAgre);
            this.grpColores.Controls.Add(this.dgvColores);
            this.grpColores.Location = new System.Drawing.Point(438, 235);
            this.grpColores.Name = "grpColores";
            this.grpColores.Size = new System.Drawing.Size(399, 220);
            this.grpColores.TabIndex = 10;
            this.grpColores.TabStop = false;
            this.grpColores.Text = "Colores";
            this.grpColores.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnColorElim
            // 
            this.btnColorElim.Location = new System.Drawing.Point(292, 123);
            this.btnColorElim.Name = "btnColorElim";
            this.btnColorElim.Size = new System.Drawing.Size(75, 52);
            this.btnColorElim.TabIndex = 5;
            this.btnColorElim.Text = "Eliminar";
            this.btnColorElim.UseVisualStyleBackColor = true;
            // 
            // btnColorAgre
            // 
            this.btnColorAgre.Location = new System.Drawing.Point(292, 29);
            this.btnColorAgre.Name = "btnColorAgre";
            this.btnColorAgre.Size = new System.Drawing.Size(75, 52);
            this.btnColorAgre.TabIndex = 4;
            this.btnColorAgre.Text = "Agregar";
            this.btnColorAgre.UseVisualStyleBackColor = true;
            this.btnColorAgre.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvColores
            // 
            this.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColores.Location = new System.Drawing.Point(6, 20);
            this.dgvColores.Name = "dgvColores";
            this.dgvColores.Size = new System.Drawing.Size(243, 181);
            this.dgvColores.TabIndex = 1;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.btnStockElim);
            this.grpStock.Controls.Add(this.btnStockEditar);
            this.grpStock.Controls.Add(this.dgvStock);
            this.grpStock.Location = new System.Drawing.Point(6, 235);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(399, 220);
            this.grpStock.TabIndex = 9;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Stock";
            this.grpStock.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnStockElim
            // 
            this.btnStockElim.Location = new System.Drawing.Point(301, 123);
            this.btnStockElim.Name = "btnStockElim";
            this.btnStockElim.Size = new System.Drawing.Size(75, 52);
            this.btnStockElim.TabIndex = 3;
            this.btnStockElim.Text = "Eliminar";
            this.btnStockElim.UseVisualStyleBackColor = true;
            // 
            // btnStockEditar
            // 
            this.btnStockEditar.Location = new System.Drawing.Point(301, 39);
            this.btnStockEditar.Name = "btnStockEditar";
            this.btnStockEditar.Size = new System.Drawing.Size(75, 52);
            this.btnStockEditar.TabIndex = 2;
            this.btnStockEditar.Text = "Editar";
            this.btnStockEditar.UseVisualStyleBackColor = true;
            this.btnStockEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(6, 20);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.Size = new System.Drawing.Size(278, 181);
            this.dgvStock.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 160);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(190, 53);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descripcion:";
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(412, 112);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(121, 21);
            this.cbxMaterial.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(339, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Material:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImgDrop);
            this.groupBox2.Controls.Add(this.btnImgAgre);
            this.groupBox2.Controls.Add(this.btnImgSiguiente);
            this.groupBox2.Controls.Add(this.btnImgAnterior);
            this.groupBox2.Controls.Add(this.picImagenes);
            this.groupBox2.Location = new System.Drawing.Point(560, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 194);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagenes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnImgDrop
            // 
            this.btnImgDrop.Location = new System.Drawing.Point(271, 126);
            this.btnImgDrop.Name = "btnImgDrop";
            this.btnImgDrop.Size = new System.Drawing.Size(75, 52);
            this.btnImgDrop.TabIndex = 7;
            this.btnImgDrop.Text = "Eliminar ";
            this.btnImgDrop.UseVisualStyleBackColor = true;
            this.btnImgDrop.Click += new System.EventHandler(this.btnImgDrop_Click);
            // 
            // btnImgAgre
            // 
            this.btnImgAgre.Location = new System.Drawing.Point(271, 39);
            this.btnImgAgre.Name = "btnImgAgre";
            this.btnImgAgre.Size = new System.Drawing.Size(75, 52);
            this.btnImgAgre.TabIndex = 6;
            this.btnImgAgre.Text = "Agregar ";
            this.btnImgAgre.UseVisualStyleBackColor = true;
            this.btnImgAgre.Click += new System.EventHandler(this.btnImgAgre_Click);
            // 
            // btnImgSiguiente
            // 
            this.btnImgSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImgSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgSiguiente.Font = new System.Drawing.Font("Palace Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgSiguiente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImgSiguiente.Location = new System.Drawing.Point(219, 90);
            this.btnImgSiguiente.Name = "btnImgSiguiente";
            this.btnImgSiguiente.Size = new System.Drawing.Size(26, 34);
            this.btnImgSiguiente.TabIndex = 4;
            this.btnImgSiguiente.Text = ">";
            this.btnImgSiguiente.UseVisualStyleBackColor = false;
            this.btnImgSiguiente.Click += new System.EventHandler(this.btnImgSiguiente_Click);
            // 
            // btnImgAnterior
            // 
            this.btnImgAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImgAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgAnterior.Font = new System.Drawing.Font("Palace Script MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgAnterior.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImgAnterior.Location = new System.Drawing.Point(15, 87);
            this.btnImgAnterior.Name = "btnImgAnterior";
            this.btnImgAnterior.Size = new System.Drawing.Size(26, 34);
            this.btnImgAnterior.TabIndex = 3;
            this.btnImgAnterior.Text = "<";
            this.btnImgAnterior.UseVisualStyleBackColor = false;
            this.btnImgAnterior.Click += new System.EventHandler(this.btnImgAnterior_Click);
            // 
            // picImagenes
            // 
            this.picImagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagenes.Location = new System.Drawing.Point(29, 19);
            this.picImagenes.Name = "picImagenes";
            this.picImagenes.Size = new System.Drawing.Size(201, 169);
            this.picImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenes.TabIndex = 0;
            this.picImagenes.TabStop = false;
            this.picImagenes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(106, 113);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 21);
            this.cbxGenero.TabIndex = 7;
            this.cbxGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(106, 72);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría:";
            // 
            // cbxTela
            // 
            this.cbxTela.FormattingEnabled = true;
            this.cbxTela.Location = new System.Drawing.Point(412, 69);
            this.cbxTela.Name = "cbxTela";
            this.cbxTela.Size = new System.Drawing.Size(121, 21);
            this.cbxTela.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(339, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tela:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(446, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(700, 521);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(791, 521);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button10_Click);
            // 
            // ofdImagenes
            // 
            this.ofdImagenes.FileName = "openFileDialog1";
            this.ofdImagenes.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cbxUnidad
            // 
            this.cbxUnidad.FormattingEnabled = true;
            this.cbxUnidad.Location = new System.Drawing.Point(412, 159);
            this.cbxUnidad.Name = "cbxUnidad";
            this.cbxUnidad.Size = new System.Drawing.Size(121, 21);
            this.cbxUnidad.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(339, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Unidad";
            // 
            // PrendaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(994, 565);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDatosGenerales);
            this.Name = "PrendaAgregar";
            this.Text = "Agregar Prenda ";
            this.Load += new System.EventHandler(this.PrendaEditar_Load);
            this.grpDatosGenerales.ResumeLayout(false);
            this.grpDatosGenerales.PerformLayout();
            this.grpColores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColores)).EndInit();
            this.grpStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosGenerales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnStockElim;
        private System.Windows.Forms.Button btnStockEditar;
        private System.Windows.Forms.GroupBox grpColores;
        private System.Windows.Forms.Button btnColorElim;
        private System.Windows.Forms.Button btnColorAgre;
        private System.Windows.Forms.DataGridView dgvColores;
        private System.Windows.Forms.PictureBox picImagenes;
        private System.Windows.Forms.Button btnImgAnterior;
        private System.Windows.Forms.Button btnImgDrop;
        private System.Windows.Forms.Button btnImgAgre;
        private System.Windows.Forms.Button btnImgSiguiente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog ofdImagenes;
        private System.Windows.Forms.ComboBox cbxUnidad;
        private System.Windows.Forms.Label label5;
    }
}