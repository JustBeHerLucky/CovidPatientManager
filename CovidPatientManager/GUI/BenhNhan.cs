using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidPatientManager.GUI
{
    public partial class BenhNhan : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        public BenhNhan()
        {
            InitializeComponent();
        }

        private void BenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidPatientManagerDTBDataSet1.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter1.Fill(this.covidPatientManagerDTBDataSet1.BenhNhan);
            //adapter = new SqlDataAdapter("", Properties.Settings.Default.CovidPatientManagerDTBConnectionString);
            //ds = new DataSet();
            //adapter.Fill(ds, "BenhNhan");


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            benhNhanBindingSource1.AddNew();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            benhNhanBindingSource1.EndEdit();
            dataGridView1.Update();
            dataGridView1.Refresh();
            
        }
    }
}
