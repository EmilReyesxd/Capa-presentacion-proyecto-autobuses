using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using Negocios;
using System.Data.SqlClient;
using System.Configuration;




namespace Capa_presentacion_proyecto_autobuses
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.DataGridViewColumnCollection Columns { get; }
        private string idsistema;
        private bool Editarse = false;
        Entidad_Sistema objEntidad = new Entidad_Sistema();
        Negocios_Sistema objNegocios =  new Negocios_Sistema();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
           }

        public void AccionesTabla()
        {
            TablaSistema.Columns[0].Visible = false;
            TablaSistema.Columns[1].Width = 60;
            TablaSistema.Columns[2].Width = 170;

            TablaSistema.ClearSelection();
            

        }
        public void MostrarBuscarTabla(string buscar)
        {
            Negocios_Sistema objNegocio = new Negocios_Sistema();
            TablaSistema.DataSource = objNegocio.ListarSistema(buscar);
        }

        private void tbbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(tbbuscar.Text);
        }

        private void LimpiarCaja()
        {
            Editarse = false;
            tbcodigo.Text = "";
            tbautobus.Text = "";
            tbchofer.Text = "";
            tbruta.Text = "";
            tbautobus.Focus();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            LimpiarCaja();  
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(TablaSistema.SelectedRows.Count> 0)
            {
            Editarse = true;
            idsistema = TablaSistema.CurrentRow.Cells[0].Value.ToString();
            tbcodigo.Text = TablaSistema.CurrentRow.Cells[1].Value.ToString();
            tbautobus.Text = TablaSistema.CurrentRow.Cells[2].Value.ToString();
            tbchofer.Text = TablaSistema.CurrentRow.Cells[3].Value.ToString();
            tbruta.Text = TablaSistema.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Editarse = false)
            {
                try
                {
                    objEntidad.Autobuses = tbautobus.Text.ToUpper();
                    objEntidad.Choferes = tbchofer.Text.ToUpper();
                    objEntidad.Rutas = tbruta.Text.ToUpper();

                    objNegocios.InsertandoSistema(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    MostrarBuscarTabla("");
                    LimpiarCaja();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                    
                }
            }
            if(Editarse == true)
            {
                try
                {
                    objEntidad.IdSistema = Convert.ToInt32(idsistema);
                    objEntidad.Autobuses = tbautobus.Text.ToUpper();
                    objEntidad.Choferes = tbchofer.Text.ToUpper();
                    objEntidad.Rutas = tbruta.Text.ToUpper();

                    objNegocios.InsertandoSistema(objEntidad);

                    MessageBox.Show("Se agrego un registro");
                    MostrarBuscarTabla("");
                    LimpiarCaja();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar g el registro" + ex);

                }

            }
        }
    }
}
