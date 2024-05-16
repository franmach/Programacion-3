using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejADo
{
    public partial class Libros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarDdl();
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true";
            string queryTabla;

            switch (slcOpciones.Value)
            {
                case "autor":
                    queryTabla = "Select * from Libro join Autor on Libro.idAutor = Autor.ID where Autor.nombre like " + "'" + txtOpcion.Text + "%'";
                    break;
                case "anio":
                    queryTabla = "Select * from Libro where Libro." + slcOpciones.Value + "=" + txtOpcion.Text;
                    break;
                case "titulo":
                    queryTabla = "Select * from Libro where Libro." + slcOpciones.Value + " like '" + txtOpcion.Text + "%'";
                    break;
                default:
                    queryTabla = "";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(queryTabla, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    gvLibros.DataSource = reader;
                    gvLibros.DataBind();
                    conn.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true";

            // Obtener el ID del autor seleccionado en el DropDownList
            int autorId = int.Parse(ddlAutores.SelectedValue);

            // Verificar que se haya seleccionado un autor válido
            if (autorId == 0)
            {
                Response.Write("Por favor selecciona un autor válido.");
                return;
            }

            string query = "INSERT INTO Libro (titulo, descripcion, anio, idAutor) VALUES (@titulo, @descripcion, @anio, @idAutor)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@anio", opcAnio.Text);
                cmd.Parameters.AddWithValue("@idAutor", autorId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("Libro agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error al agregar el libro: " + ex.Message);
                }
            }
        }


        protected void llenarDdl()
        {
            string connectionString = "Data Source=FRANCISCOMACHAD;Initial Catalog=Biblioteca;Integrated Security=true";
            string query = "SELECT id, nombre + ' ' + apellido AS nombre_completo FROM Autor";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                ddlAutores.DataSource = dataSet.Tables[0];
                ddlAutores.DataTextField = "nombre_completo";
                ddlAutores.DataValueField = "id";
                ddlAutores.DataBind();

                ddlAutores.Items.Insert(0, new ListItem("--Selecciona un Autor--", "0")); // Opción por defecto
            }


        }
    }
}