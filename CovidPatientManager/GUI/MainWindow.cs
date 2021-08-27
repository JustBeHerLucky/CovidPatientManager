using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidPatientManager.GUI
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            BenhNhan BNF = new BenhNhan();
            BNF.MdiParent = this;
            BNF.Show();
            
        }
    }
}