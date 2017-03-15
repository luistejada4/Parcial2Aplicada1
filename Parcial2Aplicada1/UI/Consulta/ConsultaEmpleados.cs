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
            
        }

        private void checkBoxText_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxText.Checked == true)
            {
                textBoxSearch.Enabled = true;
            }
            else
            {
                textBoxSearch.Enabled = false;
            }
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFecha.Checked == true)
            {
                dateTimePickerDesde.Enabled = true;
                dateTimePickerHasta.Enabled = true;
            }
            else
            {
                    dateTimePickerDesde.Enabled = false;
                    dateTimePickerHasta.Enabled = false;
            }
        }

        private void ConsultaEmpleados_Load(object sender, EventArgs e)
        {
            textBoxSearch.Enabled = false;
            dateTimePickerDesde.Enabled = false;
            dateTimePickerHasta.Enabled = false;
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            if(checkBoxText.Checked && checkBoxFecha.Checked)
            {
                dataGridView1.DataSource = BLL.EmpleadosBLL.GetListWhere(em => em.Nombre.Contains(textBoxSearch.Text) && em.FechaNacimiento >= dateTimePickerDesde.Value && em.FechaNacimiento <= dateTimePickerHasta.Value);
            }
            else
            {
                if(checkBoxFecha.Checked)
                {
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetListWhere(em => em.FechaNacimiento >= dateTimePickerDesde.Value && em.FechaNacimiento <= dateTimePickerHasta.Value);

                }
                else if(checkBoxText.Checked)
                {
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetListWhere(em => em.Nombre.Contains(textBoxSearch.Text));
                }
                else
                {
                    dataGridView1.DataSource = BLL.EmpleadosBLL.GetList();
                }
            }
        }
    }
}
