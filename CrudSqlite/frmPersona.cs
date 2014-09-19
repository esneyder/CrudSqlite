using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
using System.IO;
using System.Data.SQLite;


namespace CrudSqlite
{
	public partial class frmPersona : Form
	{
		private static string conexion = "Data Source=crudTdea.db";
		private static string bd = "crudTdea.db";
		private static int idcedula;
		public frmPersona()
		{
			InitializeComponent();
		}

		private void btnguardar_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.cedula = txtcedula.Text;
			persona.nombre = txtnombre.Text;
			persona.apellido = txtapellido.Text;
			persona.edad =Convert.ToInt32( txtedad.Text);
			persona.direccion = txtdireccion.Text;

			SQLiteConnection con = new SQLiteConnection(conexion);

			if (con.State==ConnectionState.Closed)
			{
				con.Open();
				SQLiteCommand cmd = new SQLiteCommand("INSERT INTO tblPersona (cedula,nombre,apellido,edad,direccion) values(@cedula,@nombre,@apellido,@edad,@direccion)", con);

				cmd.Parameters.AddWithValue("cedula",persona.cedula.Trim());
				cmd.Parameters.AddWithValue("nombre", persona.nombre.Trim());
				cmd.Parameters.AddWithValue("apellido", persona.apellido.Trim());
				cmd.Parameters.AddWithValue("edad", persona.edad.ToString());
				cmd.Parameters.AddWithValue("direccion", persona.direccion.Trim());

				try
				{
					cmd.ExecuteNonQuery();
					MessageBox.Show("Registro insertado correctamente");
					txtcedula.Text = string.Empty;
					txtnombre.Text = string.Empty;
					txtapellido.Text = string.Empty;
					txtedad.Text = string.Empty;
					txtdireccion.Text = string.Empty;

					cargar();
				}
				catch (Exception ex)
				{
					MessageBox.Show("error al intentar registrar una nueva persona");					
				
				}
			

			}

		}

		private void frmPersona_Load(object sender, EventArgs e)
		{
			if (!File.Exists(bd))
			{
				SQLiteConnection.CreateFile(bd);
				SQLiteConnection con = new SQLiteConnection(conexion);
				con.Open();
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("CREATE TABLE  if not exists tblPersona ([cedula] varchar(20),");
				sql.AppendLine("[nombre] varchar(50),");
				sql.AppendLine("[apellido] varchar(50),");
				sql.AppendLine("[edad] int,");
				sql.AppendLine("[direccion] varchar(50))");
				

				SQLiteCommand cmd = new SQLiteCommand(sql.ToString(),con);
				cmd.ExecuteNonQuery();

				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{

					MessageBox.Show("error al crear la base de datos" + ex.Message);
				}
			}
				cargar();

		}

		private void btnsalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cargar() {
			SQLiteConnection con = new SQLiteConnection(conexion);
			if (con.State==ConnectionState.Closed)
			{
				con.Open();
				SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tblPersona",con );

				SQLiteDataReader dr = cmd.ExecuteReader();
				List<Persona> lista = new List<Persona>();
				while (dr.Read())
				{
					lista.Add(new Persona {cedula=dr["cedula"].ToString(),
						nombre=dr["nombre"].ToString(),
						apellido=dr["apellido"].ToString(),
						edad=Convert.ToInt32(dr["edad"]),
						direccion=dr["direccion"].ToString()});
				}
				dgpersona.DataSource = lista;

			}

		}

		private void btneliminar_Click(object sender, EventArgs e)
		{
					SQLiteConnection con = new SQLiteConnection(conexion);
					if (con.State == ConnectionState.Closed)
					{
						con.Open();
						SQLiteCommand cmd = new SQLiteCommand("DELETE FROM tblPersona WHERE cedula=@cedula", con);
						cmd.Parameters.AddWithValue("@cedula", dgpersona.CurrentRow.Cells[0].Value);
						try
						{
							cmd.ExecuteNonQuery();
							MessageBox.Show("Registro eliminado");
							cargar();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error al eliminar el registro");
							
						}

					}
		}

		private void dgpersona_DockChanged(object sender, EventArgs e)
		{
			idcedula = 0;
			idcedula =Convert.ToInt32( dgpersona.CurrentRow.Cells[0].Value);			 
			txtnombre.Text = dgpersona.CurrentRow.Cells[1].Value.ToString();
			txtapellido.Text = dgpersona.CurrentRow.Cells[2].Value.ToString();
			txtedad.Text =  dgpersona.CurrentRow.Cells[3].Value.ToString();
			txtdireccion.Text = dgpersona.CurrentRow.Cells[4].Value.ToString();
		}

		private void btnactualizar_Click(object sender, EventArgs e)
		{
			if (idcedula > 0)
			{
				SQLiteConnection con = new SQLiteConnection(conexion);
				if (con.State == ConnectionState.Closed)
				{
					con.Open();
					SQLiteCommand cmd = new SQLiteCommand("UPDATE  tblPersona SET  nombre=@nombre,apellido=@apellido,edad=@edad,direccion=@direccion where cedula=@cedula", con);
					cmd.Parameters.AddWithValue("@cedula", idcedula);
					cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
					cmd.Parameters.AddWithValue("@edad",txtedad.Text);
					cmd.Parameters.AddWithValue("@direccion",txtdireccion.Text);
					MessageBox.Show("Registro Actualizado");

					try
					{
						cmd.ExecuteNonQuery();
						MessageBox.Show("Registro al actualizar");
						cargar();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al eliminar el registro");

					}

				}
			}
		}
			 
	}
}
