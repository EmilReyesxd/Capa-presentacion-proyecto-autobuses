namespace Capa_presentacion_proyecto_autobuses
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.tbruta = new System.Windows.Forms.TextBox();
            this.tbchofer = new System.Windows.Forms.TextBox();
            this.tbautobus = new System.Windows.Forms.TextBox();
            this.lblchofer = new System.Windows.Forms.Label();
            this.lblruta = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.TablaSistema = new System.Windows.Forms.DataGridView();
            this.lblautobus = new System.Windows.Forms.Label();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, -32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sistema de autobuses";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigo.Location = new System.Drawing.Point(660, 146);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(171, 44);
            this.tbcodigo.TabIndex = 41;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(703, 99);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(71, 24);
            this.lblcodigo.TabIndex = 40;
            this.lblcodigo.Text = "Codigo";
            // 
            // tbruta
            // 
            this.tbruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbruta.Location = new System.Drawing.Point(660, 414);
            this.tbruta.Name = "tbruta";
            this.tbruta.Size = new System.Drawing.Size(171, 44);
            this.tbruta.TabIndex = 39;
            // 
            // tbchofer
            // 
            this.tbchofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbchofer.Location = new System.Drawing.Point(660, 325);
            this.tbchofer.Name = "tbchofer";
            this.tbchofer.Size = new System.Drawing.Size(171, 44);
            this.tbchofer.TabIndex = 38;
            // 
            // tbautobus
            // 
            this.tbautobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbautobus.Location = new System.Drawing.Point(660, 235);
            this.tbautobus.Name = "tbautobus";
            this.tbautobus.Size = new System.Drawing.Size(171, 44);
            this.tbautobus.TabIndex = 37;
            // 
            // lblchofer
            // 
            this.lblchofer.AutoSize = true;
            this.lblchofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchofer.Location = new System.Drawing.Point(707, 282);
            this.lblchofer.Name = "lblchofer";
            this.lblchofer.Size = new System.Drawing.Size(66, 24);
            this.lblchofer.TabIndex = 36;
            this.lblchofer.Text = "Chofer";
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruta.Location = new System.Drawing.Point(716, 387);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(48, 24);
            this.lblruta.TabIndex = 35;
            this.lblruta.Text = "Ruta";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(370, 108);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(60, 34);
            this.btneditar.TabIndex = 34;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(527, 110);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(68, 35);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(297, 108);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(67, 35);
            this.btnlimpiar.TabIndex = 32;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // TablaSistema
            // 
            this.TablaSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaSistema.Location = new System.Drawing.Point(12, 152);
            this.TablaSistema.Name = "TablaSistema";
            this.TablaSistema.Size = new System.Drawing.Size(605, 397);
            this.TablaSistema.TabIndex = 31;
            // 
            // lblautobus
            // 
            this.lblautobus.AutoSize = true;
            this.lblautobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautobus.Location = new System.Drawing.Point(694, 193);
            this.lblautobus.Name = "lblautobus";
            this.lblautobus.Size = new System.Drawing.Size(80, 24);
            this.lblautobus.TabIndex = 30;
            this.lblautobus.Text = "Autobus";
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(12, 117);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(275, 20);
            this.tbbuscar.TabIndex = 29;
            this.tbbuscar.TextChanged += new System.EventHandler(this.tbbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sistema de autobuses";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(447, 108);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(74, 34);
            this.btnguardar.TabIndex = 44;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.tbruta);
            this.Controls.Add(this.tbchofer);
            this.Controls.Add(this.tbautobus);
            this.Controls.Add(this.lblchofer);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.TablaSistema);
            this.Controls.Add(this.lblautobus);
            this.Controls.Add(this.tbbuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox tbruta;
        private System.Windows.Forms.TextBox tbchofer;
        private System.Windows.Forms.TextBox tbautobus;
        private System.Windows.Forms.Label lblchofer;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DataGridView TablaSistema;
        private System.Windows.Forms.Label lblautobus;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
    }
}

