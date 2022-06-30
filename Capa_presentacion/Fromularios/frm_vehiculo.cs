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
    public partial class frm_vehiculo : Form
    {
        private VehiculoModelo vehiculo = new VehiculoModelo();
        public frm_vehiculo()
        {
            InitializeComponent();
        }

        private void frm_vehiculo_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txt_placa.Clear();
            txt_marca.Clear();
            txt_klactual.Clear();
            txt_buscar.Clear();
        }
        private void ListaVehiculos()
        {
            try
            {
                dgv_datos.DataSource = vehiculo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_placa.Text = " ";
            txt_marca.Text = " ";
            txt_klactual.Text = " ";
            txt_buscar.Text = " ";
            vehiculo.estado = Entidad_Estado.Agregado;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            vehiculo.Placa = txt_placa.Text;
            vehiculo.Marca = txt_marca.Text;
            vehiculo.Kl_Inicial = txt_klactual.Text;
            bool valid = new Validacion.V_Datos(vehiculo).validated();
            if (valid == true)
            {
                string resultado = vehiculo.GuardarCambio();
                MessageBox.Show(resultado);
                ListaVehiculos();
                Limpiar();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.SelectedRows.Count > 0)
            {
                vehiculo.estado = Entidad_Estado.Editado;
                vehiculo.IdVehiculo = int.Parse(dgv_datos.CurrentRow.Cells[0].Value.ToString());
                txt_placa.Text = dgv_datos.CurrentRow.Cells[1].Value.ToString();
                txt_marca.Text = dgv_datos.CurrentRow.Cells[2].Value.ToString();
                txt_klactual.Text = dgv_datos.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (dgv_datos.SelectedRows.Count > 0)
            {
                
                vehiculo.estado = Entidad_Estado.Eliminado;
                vehiculo.IdVehiculo = int.Parse(dgv_datos.CurrentRow.Cells[0].Value.ToString());
                string resultado = vehiculo.GuardarCambio();
                MessageBox.Show(resultado);
                ListaVehiculos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
