using EntityFramework.Data;
using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework.Customers
{
    public partial class frmCustomers : Form
    {
        private AutoLotContext _context;
        public frmCustomers()
        {
            InitializeComponent();
            _context = new AutoLotContext();
            LoadCustomers();
        }

        //Metodo para cargar las personas que estan en Customers en el DataGrid
        private void LoadCustomers()
        {
            try
            {
                dgvCustomers.DataSource = _context.Customers.ToList();
                EsconderColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar Customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EsconderColumnas()
        {
            //Escondiendo Columnas TimeStamp y CreditRisks ya que daban excepciones y daba problemas
            // a la hora de correr el programa y cargar el DataGrid
            if (dgvCustomers.Columns.Contains("TimeStamp"))
            {
                dgvCustomers.Columns["TimeStamp"].Visible = false;
            }
            if (dgvCustomers.Columns.Contains("CreditRisks"))
            {
                dgvCustomers.Columns["CreditRisks"].Visible = false;
            }

        }

        // Creando una nueva persona para Customers
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text
                };
                _context.Customers.Add(customer);
                _context.SaveChanges();
                LoadCustomers();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al crear Customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Actualizando cambios que se realize en una persona que este en Customers
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int id = (int)dgvCustomers.SelectedRows[0].Cells[0].Value;
                    var customer = _context.Customers.Find(id);
                    if (customer != null)
                    {
                        customer.FirstName = txtFirstName.Text;
                        customer.LastName = txtLastName.Text;
                        _context.SaveChanges();
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar Customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Eliminando una persona que este en Customers
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
                    var customer = _context.Customers.Find(id);
                    if (customer != null)
                    {
                        _context.Customers.Remove(customer);
                        _context.SaveChanges();
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar Customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      // Evento para que al momento de darle click a una fila aparezcan los datos en los textbox y sea mas facil la interaccion
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
                    var customer = _context.Customers.Find(id);
                    if (customer != null)
                    {
                        txtFirstName.Text = customer.FirstName;
                        txtLastName.Text = customer.LastName;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al seleccionar Customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
