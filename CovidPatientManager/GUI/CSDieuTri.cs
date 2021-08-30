using CovidPatientManager.DTO;
using DevExpress.XtraEditors;
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
    public partial class CSDieuTri : DevExpress.XtraEditors.XtraForm
    {
        bool isAdd = false;
        string userQuanLy = "";
        DiaDiemDieuTri currentDD = new DiaDiemDieuTri();
        public CSDieuTri(string UserQuanLy)
        {
            this.userQuanLy = UserQuanLy;
            InitializeComponent();
        }

        private void CSDieuTri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidPatientManagerDTBDataSet2.DiaDiemDieuTri' table. You can move, or remove it, as needed.
            this.diaDiemDieuTriTableAdapter.Fill(this.covidPatientManagerDTBDataSet2.DiaDiemDieuTri);
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                diaDiemDieuTriBindingSource.AddNew();
                isAdd = true;
                txtID.ReadOnly = false;
                txtHienTai.Text = "0";
            }
            catch (Exception) { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
                LichSuTaiKhoan newLSTK = new LichSuTaiKhoan();
                newLSTK.IDDiaDiemDieuTri = txtID.Text.Trim();
                newLSTK.TaiKhoan = userQuanLy.Trim();
                newLSTK.NgayThang = DateTime.Now.ToString();

                if (isAdd == false)
                {
                    int checkk = 0;
                    if (currentDD.TenDiemDieuTri.Trim().CompareTo(txtDiemDT.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSTK.LichSu = "Đổi tên từ '" + currentDD.TenDiemDieuTri.Trim() + "' thành '" + txtDiemDT.Text.Trim() + "'";
                        DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                        DB.SubmitChanges();
                    }
                    if (currentDD.SucChua.Trim().CompareTo(txtSucChua.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSTK.LichSu = "Thay sức chứa từ '" + currentDD.SucChua.Trim() + "' thành '" + txtSucChua.Text.Trim() + "'";
                        DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                        DB.SubmitChanges();
                    }
                    
                    if (checkk == 1)
                    {
                        diaDiemDieuTriBindingSource.EndEdit();
                        diaDiemDieuTriTableAdapter.Update(this.covidPatientManagerDTBDataSet2.DiaDiemDieuTri);
                        gridControl1.Update();
                        gridControl1.Refresh();
                        XtraMessageBox.Show("Chỉnh sửa địa điểm điều trị thành công!");
                    }
                    
                }
                else
                {
                    XtraMessageBox.Show("Thêm điểm điều trị thành công!");
                    isAdd = false;
                    newLSTK.LichSu = "Thêm địa điểm điều trị '" + txtID.Text.Trim() + "'";
                    DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                    DB.SubmitChanges();
                    txtID.ReadOnly = true;
                }

                LoadCurDDT();
            }
            catch (Exception)
            {
                
            }
        }

        void LoadCurDDT()
        {
            currentDD.IDDiaDiemDieuTri = txtID.Text;
            currentDD.TenDiemDieuTri = txtDiemDT.Text;
            currentDD.HienTai = txtHienTai.Text;
            currentDD.SucChua = txtSucChua.Text;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            diaDiemDieuTriBindingSource.CancelEdit();
            txtID.ReadOnly = true;
            isAdd = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn xóa địa điểm này? Lưu ý: Tất cả thông tin liên quan đến địa điểm này sẽ bị xóa bao gồm bệnh nhân, lịch sử thao tác với tài khoản. Xác nhận xóa " + txtID.Text + "?", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (XtraMessageBox.Show("Thật không? Xóa " + txtID.Text + " nha?", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (XtraMessageBox.Show("Chắc chắn??", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
                        LichSuTaiKhoan newLSTK = new LichSuTaiKhoan();
                        newLSTK.IDDiaDiemDieuTri = txtID.Text.Trim();
                        newLSTK.TaiKhoan = userQuanLy.Trim();
                        newLSTK.NgayThang = DateTime.Now.ToString();
                        newLSTK.LichSu = "Xóa địa điểm điều trị " + txtID.Text.Trim() + " - " + txtDiemDT.Text.Trim();
                        DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                        DB.SubmitChanges();
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        diaDiemDieuTriTableAdapter.Update(this.covidPatientManagerDTBDataSet2.DiaDiemDieuTri);
                        XtraMessageBox.Show("Xóa địa điểm điều trị " + txtID.Text.Trim() + " - " + txtDiemDT.Text.Trim() + " thành công!");
                    }
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadCurDDT();
        }

        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else if (e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void txtDiemDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}