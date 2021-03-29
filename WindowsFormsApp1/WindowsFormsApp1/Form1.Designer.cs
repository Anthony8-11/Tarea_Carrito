
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClaxon = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonFrenar2 = new System.Windows.Forms.Button();
            this.buttonCambio = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.labelDatos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.labelCambios = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonCinturon = new System.Windows.Forms.Button();
            this.buttonBrisas = new System.Windows.Forms.Button();
            this.listCansiones = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClaxon
            // 
            this.buttonClaxon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.buttonClaxon.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClaxon.ForeColor = System.Drawing.Color.Black;
            this.buttonClaxon.Location = new System.Drawing.Point(166, 311);
            this.buttonClaxon.Name = "buttonClaxon";
            this.buttonClaxon.Size = new System.Drawing.Size(72, 44);
            this.buttonClaxon.TabIndex = 0;
            this.buttonClaxon.Text = "Claxon";
            this.buttonClaxon.UseVisualStyleBackColor = false;
            this.buttonClaxon.Click += new System.EventHandler(this.buttonClaxon_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.buttonCrear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.ForeColor = System.Drawing.Color.Black;
            this.buttonCrear.Location = new System.Drawing.Point(12, 25);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(126, 61);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "Crear Carro";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonFrenar2
            // 
            this.buttonFrenar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.buttonFrenar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFrenar2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrenar2.ForeColor = System.Drawing.Color.Black;
            this.buttonFrenar2.Location = new System.Drawing.Point(31, 618);
            this.buttonFrenar2.Name = "buttonFrenar2";
            this.buttonFrenar2.Size = new System.Drawing.Size(88, 35);
            this.buttonFrenar2.TabIndex = 5;
            this.buttonFrenar2.Text = "Frenar";
            this.buttonFrenar2.UseVisualStyleBackColor = false;
            this.buttonFrenar2.Click += new System.EventHandler(this.buttonFrenar2_Click);
            // 
            // buttonCambio
            // 
            this.buttonCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(185)))));
            this.buttonCambio.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambio.ForeColor = System.Drawing.Color.Black;
            this.buttonCambio.Location = new System.Drawing.Point(543, 554);
            this.buttonCambio.Name = "buttonCambio";
            this.buttonCambio.Size = new System.Drawing.Size(91, 60);
            this.buttonCambio.TabIndex = 4;
            this.buttonCambio.Text = "Cambio";
            this.buttonCambio.UseVisualStyleBackColor = false;
            this.buttonCambio.Click += new System.EventHandler(this.buttonCambio_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.buttonApagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.Color.Black;
            this.buttonApagar.Location = new System.Drawing.Point(348, 468);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(67, 39);
            this.buttonApagar.TabIndex = 7;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.buttonFrenar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrenar.ForeColor = System.Drawing.Color.Black;
            this.buttonFrenar.Location = new System.Drawing.Point(161, 618);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(103, 50);
            this.buttonFrenar.TabIndex = 6;
            this.buttonFrenar.Text = "Frenar un poco";
            this.buttonFrenar.UseVisualStyleBackColor = false;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.BackColor = System.Drawing.Color.Transparent;
            this.labelDatos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatos.ForeColor = System.Drawing.Color.Black;
            this.labelDatos.Location = new System.Drawing.Point(245, 40);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(44, 27);
            this.labelDatos.TabIndex = 8;
            this.labelDatos.Text = "    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(158, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datos :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(177)))), ((int)(((byte)(195)))));
            this.labelVelocidad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidad.ForeColor = System.Drawing.Color.Black;
            this.labelVelocidad.Location = new System.Drawing.Point(110, 138);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(43, 16);
            this.labelVelocidad.TabIndex = 11;
            this.labelVelocidad.Text = "       ";
            // 
            // labelCambios
            // 
            this.labelCambios.AutoSize = true;
            this.labelCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(177)))), ((int)(((byte)(195)))));
            this.labelCambios.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambios.ForeColor = System.Drawing.Color.Black;
            this.labelCambios.Location = new System.Drawing.Point(145, 208);
            this.labelCambios.Name = "labelCambios";
            this.labelCambios.Size = new System.Drawing.Size(43, 16);
            this.labelCambios.TabIndex = 12;
            this.labelCambios.Text = "       ";
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.buttonEncender.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.Color.Black;
            this.buttonEncender.Location = new System.Drawing.Point(348, 428);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(67, 38);
            this.buttonEncender.TabIndex = 13;
            this.buttonEncender.Text = "Encender";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.buttonAcelerar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.ForeColor = System.Drawing.Color.Black;
            this.buttonAcelerar.Location = new System.Drawing.Point(267, 618);
            this.buttonAcelerar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(88, 35);
            this.buttonAcelerar.TabIndex = 14;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(1042, 92);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(43, 46);
            this.Reproductor.TabIndex = 15;
            // 
            // buttonCinturon
            // 
            this.buttonCinturon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.buttonCinturon.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinturon.ForeColor = System.Drawing.Color.Black;
            this.buttonCinturon.Location = new System.Drawing.Point(12, 428);
            this.buttonCinturon.Name = "buttonCinturon";
            this.buttonCinturon.Size = new System.Drawing.Size(122, 33);
            this.buttonCinturon.TabIndex = 16;
            this.buttonCinturon.Text = "Cinturon";
            this.buttonCinturon.UseVisualStyleBackColor = false;
            this.buttonCinturon.Click += new System.EventHandler(this.buttonCinturon_Click);
            // 
            // buttonBrisas
            // 
            this.buttonBrisas.AutoSize = true;
            this.buttonBrisas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.buttonBrisas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrisas.ForeColor = System.Drawing.Color.Black;
            this.buttonBrisas.Location = new System.Drawing.Point(12, 467);
            this.buttonBrisas.Name = "buttonBrisas";
            this.buttonBrisas.Size = new System.Drawing.Size(122, 38);
            this.buttonBrisas.TabIndex = 17;
            this.buttonBrisas.Text = "Limpiaparabrisas";
            this.buttonBrisas.UseVisualStyleBackColor = false;
            this.buttonBrisas.Click += new System.EventHandler(this.buttonBrisas_Click);
            // 
            // listCansiones
            // 
            this.listCansiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(197)))), ((int)(((byte)(212)))));
            this.listCansiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCansiones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCansiones.ForeColor = System.Drawing.Color.Black;
            this.listCansiones.FormattingEnabled = true;
            this.listCansiones.ItemHeight = 19;
            this.listCansiones.Location = new System.Drawing.Point(466, 223);
            this.listCansiones.Name = "listCansiones";
            this.listCansiones.Size = new System.Drawing.Size(233, 76);
            this.listCansiones.TabIndex = 18;
            this.listCansiones.SelectedIndexChanged += new System.EventHandler(this.listCansiones_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(534, 433);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(612, 435);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(573, 435);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 782);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.listCansiones);
            this.Controls.Add(this.buttonBrisas);
            this.Controls.Add(this.buttonCinturon);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.labelCambios);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonFrenar2);
            this.Controls.Add(this.buttonCambio);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonClaxon);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClaxon;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonFrenar2;
        private System.Windows.Forms.Button buttonCambio;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label labelCambios;
        private System.Windows.Forms.Button buttonEncender;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Button buttonCinturon;
        private System.Windows.Forms.Button buttonBrisas;
        private System.Windows.Forms.ListBox listCansiones;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

