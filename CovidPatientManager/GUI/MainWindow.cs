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
            this.WindowState = FormWindowState.Maximized;
        }

        void UpForm(Form F)
        {
            F.MdiParent = this;
            F.FormBorderStyle = FormBorderStyle.None;
            F.WindowState = FormWindowState.Maximized;
            F.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            PatientForm BNF = new PatientForm("NV01");
            UpForm(BNF);
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CSDieuTri CS = new CSDieuTri("NV01");
            UpForm(CS);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            TaiKhoanForm TKF = new TaiKhoanForm("NV01");
            UpForm(TKF);
        }
    }
}