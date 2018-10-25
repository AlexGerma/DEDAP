using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibORM;

namespace ORM
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private string query;
        string cadena;
        DataTable bases;
        DataTable tablas;
        DataTable campos;
        string db;
        string tb;
        MySQL My = new MySQL();

        private void cbMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMotor.SelectedIndex == 0)
            {
                txtHost.Text = "127.0.0.1";
                txtUsuario.Text = "root";
                txtPuerto.Text = "3306";
            }
            else if (cbMotor.SelectedIndex == 1)
            {
                txtHost.Text = "localhost";
                txtUsuario.Text = "sa";
                txtPuerto.Text = "1433";
            }
            else if (cbMotor.SelectedIndex == 2)
            {
                txtHost.Text = "127.0.0.1";
                txtUsuario.Text = "postgres";
                txtPuerto.Text = "5432";
            }
            /*else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }*/
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            if (cbMotor.SelectedIndex == 0)
            {
                MySQL();
                btnTiposDatos.Visible = true;
            }
            else if (cbMotor.SelectedIndex == 1)
            {
                MsSQL();
                btnTiposDatos.Visible = true;
            }
            else if (cbMotor.SelectedIndex == 2)
            {
                PostgreSQL();
            }
            else if (cbMotor.SelectedIndex == 3)
            {
                Oracle();
            }
            else
            {
                MessageBox.Show("Seleccione un Motor de Base de Datos");
            }
        }

        private void MySQL()
        {
            cadena = "server=" + txtHost.Text + ";port=" + txtPuerto.Text + ";user=" + txtUsuario.Text + ";password=" + txtPass.Text;
            if (My.Conexion(cadena))
            {
                lbEstado.Text ="Conectado a Mysql";
                bases = My.ConsultaDT(cadena, "SELECT SCHEMA_NAME FROM information_schema.SCHEMATA");
                
                cbBases.DataSource = bases;
                cbBases.DisplayMember = "SCHEMA_NAME";
                cbBases.ValueMember = "SCHEMA_NAME";
                cmbBD.DataSource = bases;
                cmbBD.DisplayMember = "SCHEMA_NAME";
                cmbBD.ValueMember = "SCHEMA_NAME";
                cbTablas.Enabled = false;
            }
            else
            {
                lbEstado.Text = "Error al conectar a Mysql";
            }
        }

        private void MsSQL()
        {
            MessageBox.Show("Esta Opción Aun No Está Desarrollada.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void PostgreSQL()
        {
            MessageBox.Show("Esta Opción Aun No Está Desarrollada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Oracle()
        {
            MessageBox.Show("Esta Opción Aun No Está Desarrollada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (cbTipoDato.SelectedIndex == 0)
            {
                cbTablas.Enabled = false;
                tablas = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.COLUMNS WHERE INFORMATION_SCHEMA.COLUMNS.TABLE_SCHEMA = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = tablas;
            }
            else if (cbTipoDato.SelectedIndex == 1)
            {
                cbTablas.Enabled = true;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.columns where columns.table_NAME = '" + tb + "' AND TABLE_SCHEMA = '"+ db +"';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 2)
            {
                cbTablas.Enabled = true;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.statistics WHERE TABLE_NAME = '" + tb + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 3)
            {
                cbTablas.Enabled = true;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.table_constraints where TABLE_NAME = '" + tb + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 4)
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM INFORMATION_SCHEMA.ROUTINES where routine_schema  = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 5)            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT *  FROM information_schema.VIEWS WHERE TABLE_SCHEMA = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
            else if (cbTipoDato.SelectedIndex == 6) 
            {
                cbTablas.Enabled = false;
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; select * from information_schema.triggers where trigger_schema = '" + db + "';");
                dgvBases.AutoGenerateColumns = true;
                dgvBases.DataSource = campos;
            }
        }

        private void cbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb = cbTablas.SelectedValue.ToString();
            MostrarDatos();
        }

        private void cbBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = cbBases.SelectedValue.ToString();
            tablas = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.TABLES WHERE INFORMATION_SCHEMA.TABLES.TABLE_SCHEMA LIKE '" + db + "';"); //+  //"USE " + cbBases.SelectedText + "; SHOW TABLES;");
            cbTablas.DataSource = tablas;
            cbTablas.DisplayMember = "TABLE_NAME";
            cbTablas.ValueMember = "TABLE_NAME";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            MostrarDatos();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void StringConexion()
        {
            query = "server=" + txtHost.Text + "; port=" + txtPuerto.Text + "; user=" + txtUsuario.Text + "; password=" + txtPass.Text;
            txtStringConexion.Text = query;
        }
        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            StringConexion();
        }

        private void txtPuerto_TextChanged(object sender, EventArgs e)
        {
            StringConexion();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            StringConexion();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            StringConexion();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (pnlForm2.Visible == true)
            {
               
                pnlForm2.Visible = false;
            }
            else
            {
                this.Close();
            }
        }
        

        private void btnMini_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnTiposDatos_Click(object sender, EventArgs e)
        {
            pnlForm2.Visible = true;
            campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA;SELECT TABLE_SCHEMA,TABLE_NAME,COLUMN_NAME,DATA_TYPE,COLUMN_TYPE,COLUMN_KEY FROM information_schema.COLUMNS");
            DgridTipos.AutoGenerateColumns = true;
            DgridTipos.DataSource = campos;
            ColoreaDgrid();
           
        }
        private void ColoreaDgrid()
        {
            this.DgridTipos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.DgridTipos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.DgridTipos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.DgridTipos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.DgridTipos.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.DgridTipos.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < DgridTipos.RowCount; i++)
            {
                if (DgridTipos.Rows[i].Cells[3].Value is null)
                {

                }
                else
                {
                    if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "char" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "varchar")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Green;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Green;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "int" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "tinyint" ||
                    DgridTipos.Rows[i].Cells[3].Value.ToString() == "smallint" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "bigint" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "mediumint")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.MediumBlue;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.MediumBlue;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "double" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "float")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "text" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "mediumtext" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "longtext")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Crimson;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Crimson;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "datetime" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "date" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "year" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "timestamp" ||
                        DgridTipos.Rows[i].Cells[3].Value.ToString() == "time")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Pink;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Pink;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "binary" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "decimal")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Purple;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Purple;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "enum" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "set" || DgridTipos.Rows[i].Cells[3].Value.ToString() == "blob")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Violet;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Violet;
                    }
                    else if (DgridTipos.Rows[i].Cells[3].Value.ToString() == "varbinary")
                    {
                        DgridTipos.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        DgridTipos.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    }
                }


            }
        }

        private void cmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = cmbBD.SelectedValue.ToString();
            tablas = My.ConsultaTB(cadena, "USE INFORMATION_SCHEMA; SELECT * FROM information_schema.TABLES WHERE INFORMATION_SCHEMA.TABLES.TABLE_SCHEMA LIKE '" + db + "';"); //+  //"USE " + cbBases.SelectedText + "; SHOW TABLES;");
            cmbTb.DataSource = tablas;
            cmbTb.DisplayMember = "TABLE_NAME";
            cmbTb.ValueMember = "TABLE_NAME";
            
        }

        private void btnMostraTodas_Click(object sender, EventArgs e)
        {
            DgridTipos.Columns.Clear();
            campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA;SELECT TABLE_SCHEMA,TABLE_NAME,COLUMN_NAME,DATA_TYPE,COLUMN_TYPE,COLUMN_KEY FROM information_schema.COLUMNS");
            DgridTipos.AutoGenerateColumns = true;
            DgridTipos.DataSource = campos;
            ColoreaDgrid();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbBD.SelectedValue is null || cmbType.SelectedItem is null)
            {
                DgridTipos.Columns.Clear();
                campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA;SELECT TABLE_SCHEMA,TABLE_NAME,COLUMN_NAME,DATA_TYPE,COLUMN_TYPE,COLUMN_KEY FROM information_schema.COLUMNS");
                DgridTipos.AutoGenerateColumns = true;
                DgridTipos.DataSource = campos;
                ColoreaDgrid();
            }
            else
            {
                db = cmbBD.SelectedValue.ToString();
                tb = cmbTb.SelectedValue.ToString();
                string tp = cmbType.SelectedItem.ToString();
                if (cmbTb.SelectedIndex == 0)
                {
                    DgridTipos.Columns.Clear();
                    campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA;SELECT TABLE_SCHEMA,TABLE_NAME,COLUMN_NAME,DATA_TYPE,COLUMN_TYPE,COLUMN_KEY FROM information_schema.COLUMNS WHERE COLUMNS.DATA_TYPE = '" + tp+"' AND COLUMNS.COLUMN_TYPE LIKE '%"+txtLenght.Text+"%'");
                    DgridTipos.AutoGenerateColumns = true;
                    DgridTipos.DataSource = campos;
                    ColoreaDgrid();
                    DgridTipos.Columns[3].Visible = false;
                }
                else
                {
                    DgridTipos.Columns.Clear();
                    campos = My.ConsultaDT(cadena, "USE INFORMATION_SCHEMA;SELECT TABLE_SCHEMA,TABLE_NAME,COLUMN_NAME,DATA_TYPE,COLUMN_TYPE,COLUMN_KEY FROM information_schema.COLUMNS WHERE COLUMNS.TABLE_SCHEMA = '" + db + "' AND COLUMNS.TABLE_NAME = '" + tb + "' AND COLUMNS.DATA_TYPE = '" + tp + "' AND COLUMNS.COLUMN_TYPE LIKE '%" + txtLenght.Text + "%'");
                    DgridTipos.AutoGenerateColumns = true;
                    DgridTipos.DataSource = campos;
                    ColoreaDgrid();
                    DgridTipos.Columns[3].Visible = false;
                }
                
                
            }
            
        }

        private void txtLenght_TextChanged(object sender, EventArgs e)
        {
            if (!Validaciones.numeros(txtLenght.Text))
            {
                txtLenght.Clear();
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {

            }
        }
    }
}
