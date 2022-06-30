using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_presentacion;

namespace Capa_presentacion.Fromularios
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            frm_usuarios frm = new frm_usuarios();
            frm.Show();
        }

        private void btn_vehiculos_Click(object sender, EventArgs e)
        {
            frm_vehiculo frm = new frm_vehiculo();
            frm.Show();
        }

        private void btn_renta_Click(object sender, EventArgs e)
        {
            txt_descuento frm = new txt_descuento();
            frm.Show();
        }
    }
}
