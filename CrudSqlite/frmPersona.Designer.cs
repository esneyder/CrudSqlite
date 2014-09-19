namespace CrudSqlite
{
	partial class frmPersona
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
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
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersona));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtedad = new System.Windows.Forms.TextBox();
			this.txtapellido = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtcedula = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btneliminar = new System.Windows.Forms.Button();
			this.btnactualizar = new System.Windows.Forms.Button();
			this.btnguardar = new System.Windows.Forms.Button();
			this.dgpersona = new System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgpersona)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.GroupBox1.Controls.Add(this.PictureBox1);
			this.GroupBox1.Controls.Add(this.txtdireccion);
			this.GroupBox1.Controls.Add(this.txtedad);
			this.GroupBox1.Controls.Add(this.txtapellido);
			this.GroupBox1.Controls.Add(this.txtnombre);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtcedula);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(33, 26);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(581, 215);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Mantenimiento persona";
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackgroundImage = global::CrudSqlite.Properties.Resources._1411099425_config_users;
			this.PictureBox1.Location = new System.Drawing.Point(358, 55);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(120, 122);
			this.PictureBox1.TabIndex = 10;
			this.PictureBox1.TabStop = false;
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(100, 170);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(172, 20);
			this.txtdireccion.TabIndex = 9;
			// 
			// txtedad
			// 
			this.txtedad.Location = new System.Drawing.Point(100, 139);
			this.txtedad.Name = "txtedad";
			this.txtedad.Size = new System.Drawing.Size(172, 20);
			this.txtedad.TabIndex = 8;
			// 
			// txtapellido
			// 
			this.txtapellido.Location = new System.Drawing.Point(100, 108);
			this.txtapellido.Name = "txtapellido";
			this.txtapellido.Size = new System.Drawing.Size(172, 20);
			this.txtapellido.TabIndex = 7;
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(100, 67);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(172, 20);
			this.txtnombre.TabIndex = 6;
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label5.Location = new System.Drawing.Point(15, 168);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(79, 20);
			this.Label5.TabIndex = 5;
			this.Label5.Text = "Dirección:";
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(15, 139);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(51, 20);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Edad:";
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(15, 106);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(69, 20);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Apellido:";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(15, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(69, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Nombre:";
			// 
			// txtcedula
			// 
			this.txtcedula.Location = new System.Drawing.Point(100, 35);
			this.txtcedula.Name = "txtcedula";
			this.txtcedula.Size = new System.Drawing.Size(172, 20);
			this.txtcedula.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(15, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(63, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Cedula:";
			// 
			// GroupBox2
			// 
			this.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.GroupBox2.Controls.Add(this.btnsalir);
			this.GroupBox2.Controls.Add(this.btneliminar);
			this.GroupBox2.Controls.Add(this.btnactualizar);
			this.GroupBox2.Controls.Add(this.btnguardar);
			this.GroupBox2.Location = new System.Drawing.Point(33, 247);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(581, 100);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Acciones";
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(272, 30);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(75, 42);
			this.btnsalir.TabIndex = 4;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.Location = new System.Drawing.Point(181, 30);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(75, 42);
			this.btneliminar.TabIndex = 3;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.UseVisualStyleBackColor = true;
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// btnactualizar
			// 
			this.btnactualizar.Location = new System.Drawing.Point(100, 30);
			this.btnactualizar.Name = "btnactualizar";
			this.btnactualizar.Size = new System.Drawing.Size(75, 42);
			this.btnactualizar.TabIndex = 2;
			this.btnactualizar.Text = "Actualizar";
			this.btnactualizar.UseVisualStyleBackColor = true;
			this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(19, 30);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(75, 42);
			this.btnguardar.TabIndex = 0;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
			// 
			// dgpersona
			// 
			this.dgpersona.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
			this.dgpersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgpersona.Location = new System.Drawing.Point(33, 368);
			this.dgpersona.Name = "dgpersona";
			this.dgpersona.Size = new System.Drawing.Size(581, 173);
			this.dgpersona.TabIndex = 5;
			this.dgpersona.DockChanged += new System.EventHandler(this.dgpersona_DockChanged);
			// 
			// frmPersona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.BackgroundImage = global::CrudSqlite.Properties.Resources.neote;
			this.ClientSize = new System.Drawing.Size(672, 564);
			this.Controls.Add(this.dgpersona);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPersona";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmPersona_Load);
			this.MouseCaptureChanged += new System.EventHandler(this.btnguardar_Click);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.GroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgpersona)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TextBox txtdireccion;
		internal System.Windows.Forms.TextBox txtedad;
		internal System.Windows.Forms.TextBox txtapellido;
		internal System.Windows.Forms.TextBox txtnombre;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtcedula;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button btnsalir;
		internal System.Windows.Forms.Button btneliminar;
		internal System.Windows.Forms.Button btnactualizar;
		internal System.Windows.Forms.Button btnguardar;
		internal System.Windows.Forms.DataGridView dgpersona;
	}
}

