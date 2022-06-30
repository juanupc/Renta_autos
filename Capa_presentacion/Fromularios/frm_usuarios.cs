using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_logica.Modelos;
using Capa_logica.Valor;

namespace Capa_presentacion.Fromularios
{
    public partial class frm_usuarios : Form
    {
        private UsuarioModelo modelo = new UsuarioModelo();
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txt_documento.Clear();
            txt_nombreusuario.Clear();
            txt_buscar.Clear();
        }
        private void ListaUsuarios()
        {
            try
            {
                dgv_datos.DataSource = modelo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_documento.Text = " ";
            txt_nombreusuario.Text = " ";
            txt_buscar.Text = " ";
            modelo.estado = Entidad_Estado.Agregado;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            modelo.Documento_ = txt_documento.Text;
            modelo.NombreCompleto_ = txt_nombreusuario.Text;
            bool valida = new Validacion.V_Datos(modelo).validated();
            if (valida == true)
            {
                string resultado = modelo.GuardarCambio();
                MessageBox.Show(resultado);
                ListaUsuarios();
                Limpiar();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.SelectedRows.Count > 0)
            {
                modelo.estado = Entidad_Estado.Eliminado;
                modelo.Idusuario_ = int.Parse(dgv_datos.CurrentRow.Cells[0].Value.ToString());
                string resultado = modelo.GuardarCambio();
                MessageBox.Show(resultado);
                ListaUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if(dgv_datos.SelectedRows.Count > 0)
            {
                modelo.estado = Entidad_Estado.Editado;
                modelo.Idusuario_ = int.Parse(dgv_datos.CurrentRow.Cells[0].Value.ToString());
                txt_documento.Text = dgv_datos.CurrentRow.Cells[1].Value.ToString();
                txt_nombreusuario.Text = dgv_datos.CurrentRow.Cells[2].Value.ToString();
                cb_tipodeafiliacion.Text = dgv_datos.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgv_datos.DataSource = modelo.BuscarClientes(txt_buscar.Text);
        }

    }
}
