using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Aplicada1.UI.Consulta
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(checkBoxFecha.Checked == true)
            {
                   dataGridView1.DataSource = BLL.EmpleadosBLL.GetListWhere(em => em.FechaNacimiento >= dateTimeDesde.Value && em.FechaNacimiento <= dateTimeHasta.Value);
            }
        }
    }
}
