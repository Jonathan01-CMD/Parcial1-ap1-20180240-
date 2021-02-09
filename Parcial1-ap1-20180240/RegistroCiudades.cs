using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_ap1_20180240.BLL;
using Parcial1_ap1_20180240.Dal;
using Parcial1_ap1_20180240.Entidades;

namespace Parcial1_ap1_20180240
{
    public partial class RegistroCiudad : Form
    {
        public RegistroCiudad()
        {
            InitializeComponent();
        }
        private void LlenarCampo(Ciudades ciudad)
        {
            NumericUpDown.Value = ciudad.CiudadId;
            NombreCiudad.Text = ciudad.NombreCiudad;
        }
        private void Limpiar()
        {
            NumericUpDown.Value = 0;
            NombreCiudad.Clear();
        }
        private Ciudades LlenarClase()
        {
            Ciudades ciudades = new Ciudades();
            ciudades.CiudadId = (int)NumericUpDown.Value;
            ciudades.NombreCiudad = NombreCiudad.Text;

            return ciudades;
        }

        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Ciudades ciudades;
            bool paso = false;

            if (!Validar())
                return;

            ciudades = LlenarClase();

            paso = CiudadBLL.Guardar(ciudades);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se guardo", "Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se Guardo ID", "incorecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            int id;

            int.TryParse(NumericUpDown.Text, out id);

            Limpiar();

            if(CiudadBLL.Eliminar(id))
                MessageBox.Show("Se a eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("No hay que eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool Validar()
        {
            bool pasos = true;

            if(NombreCiudad.Text == string.Empty)
            {
                errorProvider1.SetError(NombreCiudad, "El campo esta vacio");
                NombreCiudad.Focus();
                pasos = false;
            }
            return pasos;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            int id;

            Ciudades ciudades = new Ciudades();
            int.TryParse(NumericUpDown.Text, out id);

            Limpiar();

            ciudades = CiudadBLL.Buscar(id);

            if(ciudades!=null)
            {
                MessageBox.Show("Ciudad encontrada");
                LlenarCampo(ciudades);
            }
            else
            {
                MessageBox.Show("Ciudad no esta en base de datos");
            }
        }
    }
}
