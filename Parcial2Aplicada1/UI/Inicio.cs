using Parcial2Aplicada1.Entidades;
using Parcial2Aplicada1.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Aplicada1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Registros.Registros().Show();
        }

        private void buttonBuscarDetalle_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(textBoxEmpleadoIdDetalle.Text, out id);

            if(BLL.EmpleadosBLL.Buscar(id))
            {

                textBoxEmpleadoNombreDetalle.Text = BLL.EmpleadosBLL.empleadoReturn.Nombre;
                dateTimePickerEmpleadoNacDetalle.Value = BLL.EmpleadosBLL.empleadoReturn.FechaNacimiento;
                textBoxEmpleadoSueldoDetalle.Text = BLL.EmpleadosBLL.empleadoReturn.Sueldo.ToString();

                List<EmpleadoEmail> empleadosEmails = BLL.EmpleadosEmailsBLL.GetListWhere(em => em.EmpleadoId == id);
                List<EmpleadoRetencion> empleadosRetenciones = BLL.EmpleadosRetencionesBLL.GetListWhere(er => er.EmpleadoId == id);

                dataGridViewEmpleadoCorreosDetalle.Rows.Clear();
                dataGridViewEmpleadoCorreosDetalle.Refresh();

                dataGridViewEmpleadoRetencionesDetalle.Rows.Clear();
                dataGridViewEmpleadoRetencionesDetalle.Refresh();


                for (int i = 0; i < empleadosEmails.Count; i++)
                {
                    BLL.TiposEmailsBLL.Buscar(empleadosEmails[i].TipoId);
                    dataGridViewEmpleadoCorreosDetalle.Rows.Add();
                    dataGridViewEmpleadoCorreosDetalle.Rows[i].Cells[0].Value = empleadosEmails[i].Email;
                    dataGridViewEmpleadoCorreosDetalle.Rows[i].Cells[1].Value = BLL.TiposEmailsBLL.tipoEmailReturn.Descripcion;
                    
                }

                for(int i = 0; i < empleadosRetenciones.Count; i++)
                {
                    BLL.RetencionesBLL.Buscar(empleadosRetenciones[i].RetencionId);
                    dataGridViewEmpleadoRetencionesDetalle.Rows.Add();
                    dataGridViewEmpleadoRetencionesDetalle.Rows[i].Cells[0].Value = BLL.RetencionesBLL.retencionReturn.Descripcion;
                    dataGridViewEmpleadoRetencionesDetalle.Rows[i].Cells[1].Value = BLL.RetencionesBLL.retencionReturn.Valor;
                    
                }
            }


            else
            {
                MessageBox.Show("Este empleado no existe!");
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Consulta.ConsultaEmpleados().Show();
        }
    }
}
