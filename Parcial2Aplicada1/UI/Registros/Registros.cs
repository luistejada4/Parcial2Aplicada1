﻿using Parcial2Aplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Aplicada1.UI.Registros
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private bool Validar(int validation)
        {
            int errorCount = 0;
            switch (tabControlRegistros.SelectedIndex)
            {
                case 0:
                    {
                        switch (validation)
                        {
                            case 0:
                                {
                                    if (!Utils.NoWhiteNoSpace(textBoxEmpleadoId.Text))
                                    {
                                        errorProvider.SetError(textBoxEmpleadoId, "Invalido!");
                                        errorCount++;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (!Utils.NoWhiteNoSpace(textBoxEmpleadoNombre.Text))
                                    {
                                        errorCount++;
                                        errorProvider.SetError(textBoxEmpleadoNombre, "Invalido!");
                                    }
                                    if (!Utils.NoWhiteNoSpace(maskedTextBoxEmpleadoSueldo.Text))
                                    {
                                        errorCount++;
                                        errorProvider.SetError(maskedTextBoxEmpleadoSueldo, "Invalido!");
                                    }
                                    break;
                                }
                        }
                        break;

                    }
                case 1:
                    {
                        switch (validation)
                        {
                            case 0:
                                {
                                    if (!Utils.NoWhiteNoSpace(textBoxRetencionId.Text))
                                    {
                                        errorProvider.SetError(textBoxRetencionId, "Invalido!");
                                        errorCount++;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (!Utils.NoWhiteNoSpace(textBoxRetencionDescripcion.Text))
                                    {
                                        errorCount++;
                                        errorProvider.SetError(textBoxRetencionDescripcion, "Invalido!");
                                    }
                                    if (!Utils.NoWhiteNoSpace(textBoxRetencionValor.Text))
                                    {
                                        errorCount++;
                                        errorProvider.SetError(textBoxRetencionValor, "Invalido!");
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (validation)
                        {
                            case 0:
                                {
                                    if (!Utils.NoWhiteNoSpace(textBoxTipoEmailId.Text))
                                    {
                                        errorProvider.SetError(textBoxTipoEmailId, "Invalido!");
                                        errorCount++;
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (!Utils.NoWhiteNoSpace(textBoxTipoEmailDescripcion.Text))
                                    {
                                        errorCount++;
                                        errorProvider.SetError(textBoxTipoEmailDescripcion, "Invalido!");
                                    }
                                    break;
                                }
                        }
                        break;
                    }

            }
            if (errorCount == 0) return true;
            return false;

        }

        private void Limpiar()
        {
            switch (tabControlRegistros.SelectedIndex)
            {
                case 0:
                    {


                        textBoxEmpleadoId.Clear();
                        textBoxEmpleadoNombre.Clear();
                        dateTimePickerEmpleadoNacimiento.Value = DateTime.Today;
                        maskedTextBoxEmpleadoSueldo.Clear();
                        errorProvider.Clear();
                        break;
                    }
                case 1:
                    {
                        textBoxRetencionId.Clear();
                        textBoxRetencionDescripcion.Clear();
                        textBoxRetencionValor.Clear();
                        errorProvider.Clear();
                        break;
                    }
                case 2:
                    {
                        textBoxTipoEmailId.Clear();
                        textBoxTipoEmailDescripcion.Clear();
                        errorProvider.Clear();
                        break;
                    }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            switch (tabControlRegistros.SelectedIndex)
            {
                case 0:
                    {
                        if (Validar(1))
                        {
                            int id;
                            int.TryParse(textBoxEmpleadoId.Text, out id);
                            Empleado empleado = new Empleado(id, textBoxEmpleadoNombre.Text, dateTimePickerEmpleadoNacimiento.Value, int.Parse(maskedTextBoxEmpleadoSueldo.Text));
                            if (BLL.EmpleadosBLL.Guardar(empleado))
                            {
                                MessageBox.Show("Se guardo el empleado!");
                                textBoxEmpleadoId.Text = BLL.EmpleadosBLL.empleadoReturn.EmpleadoId.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No see guardo el empleado!");
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        if (Validar(1))
                        {
                            int id;
                            int.TryParse(textBoxRetencionId.Text, out id);
                            Retencion retencion = new Retencion(id, textBoxRetencionDescripcion.Text, int.Parse(textBoxRetencionValor.Text));
                            if (BLL.RetencionesBLL.Guardar(retencion))
                            {
                                MessageBox.Show("Se guardo la retencion!");
                                textBoxRetencionId.Text = BLL.RetencionesBLL.retencionReturn.RetencionId.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se guardo la retencion!");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (Validar(1))
                        {
                            int id;
                            int.TryParse(textBoxTipoEmailId.Text, out id);
                            TipoEmail tipoEmail = new TipoEmail(id, textBoxTipoEmailDescripcion.Text);
                            if (BLL.TiposEmailsBLL.Guardar(tipoEmail))
                            {
                                MessageBox.Show("Se guardo el tipo de email!");
                                textBoxTipoEmailId.Text = BLL.TiposEmailsBLL.tipoEmailReturn.TipoEmailId.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se guardo el tipo de email!");
                            }
                        }
                        break;
                    }

            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            switch (tabControlRegistros.SelectedIndex)
            {
                case 0:
                    {


                        if (Validar(0))
                        {
                            if (BLL.EmpleadosBLL.Buscar(int.Parse(textBoxEmpleadoId.Text)))
                            {
                                textBoxEmpleadoNombre.Text = BLL.EmpleadosBLL.empleadoReturn.Nombre;
                                dateTimePickerEmpleadoNacimiento.Value = BLL.EmpleadosBLL.empleadoReturn.FechaNacimiento;
                                maskedTextBoxEmpleadoSueldo.Text = BLL.EmpleadosBLL.empleadoReturn.Sueldo.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encuentra un empleado con ese Id!");
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        if (Validar(0))
                        {


                            if (BLL.RetencionesBLL.Buscar(int.Parse(textBoxRetencionId.Text)))
                            {
                                textBoxRetencionDescripcion.Text = BLL.RetencionesBLL.retencionReturn.Descripcion;
                                textBoxRetencionValor.Text = BLL.RetencionesBLL.retencionReturn.Valor.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encuentra unaa retencion con ese Id!");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (Validar(0))
                        {


                            if (BLL.TiposEmailsBLL.Buscar(int.Parse(textBoxTipoEmailId.Text)))
                            {
                                textBoxTipoEmailDescripcion.Text = BLL.TiposEmailsBLL.tipoEmailReturn.Descripcion;
                            }
                            else
                            {
                                MessageBox.Show("No se encuentra un tipo de email con ese Id!");
                            }
                        }
                        break;
                    }

            }

        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            switch (tabControlRegistros.SelectedIndex)
            {
                case 0:
                    {
                        if (Validar(0))
                        {
                            int id = int.Parse(textBoxEmpleadoId.Text);
                            if (BLL.EmpleadosBLL.Buscar(id))
                            {
                                BLL.EmpleadosBLL.Eliminar(id);
                                MessageBox.Show("Empleado eliminado");
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("El empleado no existe!");
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        if (Validar(0))
                        {


                            int id = int.Parse(textBoxRetencionId.Text);
                            if (BLL.RetencionesBLL.Buscar(id))
                            {
                                BLL.RetencionesBLL.Eliminar(id);
                                MessageBox.Show("Retencion eliminada");
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Esta retencion no existe!");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (Validar(0))
                        {


                            int id = int.Parse(textBoxTipoEmailId.Text);
                            if (BLL.TiposEmailsBLL.Buscar(id))
                            {
                                BLL.TiposEmailsBLL.Eliminar(id);
                                MessageBox.Show("tipo de email eliminada");
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Este tipo de Email no existe!");
                            }
                        }
                        break;
                    }
            }
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parcial2DBDataSet.Empleados' table. You can move, or remove it, as needed.;

        }

        private void tabControlRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlRegistros.SelectedIndex == 3)
            {
                comboBoxEmpleadosId.DataSource = BLL.EmpleadosBLL.GetList();
                comboBoxEmpleadosId.DisplayMember = "Nombre";
                comboBoxEmpleadosId.ValueMember = "EmpleadoId";

                comboBoxTipoEmailId.DataSource = BLL.TiposEmailsBLL.GetList();
                comboBoxTipoEmailId.DisplayMember = "Descripcion";
                comboBoxTipoEmailId.ValueMember = "TipoEmailId";
                dataGridView1.DataSource = BLL.TiposEmailsBLL.GetList();

            }
        }
    }
   }