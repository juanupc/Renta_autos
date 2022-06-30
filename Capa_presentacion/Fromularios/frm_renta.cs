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
using Capa_datos.Entidades;

namespace Capa_presentacion
{
    public partial class txt_descuento : Form
    {
        UsuarioModelo modelocliente = new UsuarioModelo();
        VehiculoModelo modelovehiculo = new VehiculoModelo();
        RentaModelo modeloalquiler = new RentaModelo();
        private Usuarios Usuarios;
        private Vehiculo Vehiculo;
        public txt_descuento()
        {
            InitializeComponent();
        }

        private void frm_renta_Load(object sender, EventArgs e)
        {
            ListaRenta();
        }
        private void ListaRenta()
        {
            try
            {
                dgv_datos.DataSource = modeloalquiler.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_datos.SelectedRows.Count > 0)
            { 
                modeloalquiler.estado = Entidad_Estado.Editado;
                modeloalquiler.IdRenta = int.Parse(dgv_datos.CurrentRow.Cells[0].Value.ToString());
                txt_idusuario.Enabled = false;
                txt_idvehiculo.Enabled = false;
                txt_documento.Enabled = false;
                txt_nombreusuario.Enabled = false;
                txt_placa.Enabled = false;
                txt_klrecepcion.Text = dgv_datos.CurrentRow.Cells[5].Value.ToString();
                txt_klrecorridos.Text = dgv_datos.CurrentRow.Cells[6].Value.ToString();
                dtp_fechaentrega.Text = dgv_datos.CurrentRow.Cells[7].Value.ToString();
                dtp_fechavuelta.Text = dgv_datos.CurrentRow.Cells[11].Value.ToString();
                txt_valorkl.Text = dgv_datos.CurrentRow.Cells[8].Value.ToString();
                txt_desc.Text = dgv_datos.CurrentRow.Cells[9].Value.ToString();
                txt_totalpagar.Text = dgv_datos.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            modeloalquiler.estado = Entidad_Estado.Agregado;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var descuento = double.Parse(txt_totalpagar.Text);
            modeloalquiler.estado = Entidad_Estado.Agregado;
            modeloalquiler.Usuario = Usuarios;
            modeloalquiler.Vehiculo = Vehiculo;
            modeloalquiler.Fecha_entrega = dtp_fechaentrega.Value;
            modeloalquiler.Kl_Entrega = int.Parse(txt_klrecepcion.Text);
            modeloalquiler.Kl_Recorrido = int.Parse(txt_klrecorridos.Text);
            modeloalquiler.Descuento = double.Parse(txt_desc.Text);
            if (modeloalquiler.Usuario._TipoAfiliacion == "Contrato")
            {
                modeloalquiler.AplicarDescuento(descuento);
                descuento = double.Parse(txt_desc.Text);
            }
            else
            {
                modeloalquiler.Total_pagar = int.Parse(txt_totalpagar.Text);
            }
            modeloalquiler.Fecha_devuelta = dtp_fechavuelta.Value;
            string mensaje = modeloalquiler.GuardarCambio();
            MessageBox.Show(mensaje);
            Limpiar();
        }
        private void Limpiar()
        {
            txt_idusuario.Clear();
            txt_documento.Clear();
            txt_nombreusuario.Clear();
            txt_idvehiculo.Clear();
            txt_placa.Clear();
            txt_klrecepcion.Clear();
            txt_klrecorridos.Clear();
            txt_tipoafiliacion.Clear();
            txt_totalpagar.Clear();
            txt_valorkl.Clear();
        }

        private void btn_busuario_Click(object sender, EventArgs e)
        {
            var Idusuario = int.Parse(txt_idusuario.Text);
            Usuarios = modelocliente.BuscarPorIdCliente(Idusuario);
            txt_nombreusuario.Text = Usuarios._NombreCompleto;
            txt_tipoafiliacion.Text = Usuarios._TipoAfiliacion;
        }

        private void btn_bvehiculo_Click(object sender, EventArgs e)
        {
            var IdVehiculo = int.Parse(txt_idvehiculo.Text);
            Vehiculo = modelovehiculo.BuscarPorIdVehiculo(IdVehiculo);
            txt_placa.Text = Vehiculo._Placa;
        }
    }
}
