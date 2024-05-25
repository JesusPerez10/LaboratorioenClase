using ConexionDBMySqlWF.Data;
using ConexionDBMySqlWF.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDBMySqlWF
{
    public partial class Form1 : Form
    {
        ConexionMySql Clscone = new ConexionMySql();
        Usuario usr = new Usuario();
        List<Usuario> todos;
        ClsCursor cursor1 = new ClsCursor();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Clscone.Insertar(textBoxNombreconsola.Text, textBoxCompania.Text, dateTimePickerAnioLanzamiento.Value,textBoxgeneracion.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Clscone.Actualizar(textBoxID.Text, textBoxNombreconsola.Text, textBoxCompania.Text, dateTimePickerAnioLanzamiento.Value, textBoxgeneracion.Text);
        }

        private void buttonBuscarById_Click(object sender, EventArgs e)
        {
            DataRow resp = Clscone.LeerPorId(int.Parse(textBoxID.Text));
            if (resp != null)
            {
                textBoxNombreconsola.Text = resp["NombreConsola"].ToString();
                textBoxCompania.Text = resp["Compania"].ToString();
                dateTimePickerAnioLanzamiento.Value = (DateTime)resp["anioLanzamiento"];
                textBoxgeneracion.Text = resp["generacion"].ToString();
                
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }

        private void buttonInsertarModel_Click(object sender, EventArgs e)
        {
            //insertar usando la clase Usuario
            usr.NombreConsola = textBoxNombreconsola.Text;
            usr.Compania = textBoxCompania.Text;
            usr.AnioLanzamieto = dateTimePickerAnioLanzamiento.Value;
            usr.Generacion = textBoxgeneracion.Text;
            
            Clscone.Insertar(usr);
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            todos = Clscone.ObtenerTodosLosUsuarios();
            if (todos.Count > 0)
            {
                cursor1.totalRegistros = todos.Count;
                cursor1.current = 0;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        //funcion para mostrar el registro actual
        private void MostrarRegistro()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                Usuario u = todos[cursor1.current];
                textBoxID.Text = u.ID.ToString();
                textBoxNombreconsola.Text = u.NombreConsola;
                textBoxCompania.Text = u.Compania;
                dateTimePickerAnioLanzamiento.Value = u.AnioLanzamieto;
                textBoxgeneracion.Text = u.Generacion;
               
                //incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }
    }
}
