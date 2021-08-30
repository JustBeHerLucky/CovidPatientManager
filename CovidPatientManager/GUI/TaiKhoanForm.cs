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
    public partial class TaiKhoanForm : DevExpress.XtraEditors.XtraForm
    {
        string userQuanLy;
        TaiKhoan TKHienTai = new TaiKhoan();
        bool isAdd = false;


        public TaiKhoanForm(string user)
        {
            InitializeComponent();
            this.userQuanLy = user;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidPatientManagerDTBDataSet3.TaiKhoan' table. You can move, or remove it, as needed.
            UpdateCbbQuyen();
            UpdateCbbTrangThai();
            // TODO: This line of code loads data into the 'covidPatientManagerDTBDataSet3.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.covidPatientManagerDTBDataSet3.TaiKhoan);

        }

        void UpdateCbbQuyen()
        {
            txtQuyen.Properties.Items.Add("ADMIN");
            txtQuyen.Properties.Items.Add("QUẢN LÝ");
        }
        void UpdateCbbTrangThai()
        {
            txtTrangThai.Properties.Items.Add("HOẠT ĐỘNG");
            txtTrangThai.Properties.Items.Add("KHÓA");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.AddNew();
            txtTaiKhoan.ReadOnly = false;
            isAdd = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.CancelEdit();
            txtTaiKhoan.ReadOnly = true;
            isAdd = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
                LichSuTaiKhoan newLSTK = new LichSuTaiKhoan();
                newLSTK.IDDiaDiemDieuTri = txtTaiKhoan.Text.Trim();
                newLSTK.TaiKhoan = userQuanLy.Trim();
                newLSTK.NgayThang = DateTime.Now.ToString();
                if (!isAdd)
                {
                    int check = 0;
                    if (TKHienTai.TaiKhoan1.CompareTo(txtTaiKhoan.Text.Trim()) == 0)
                    {
                        if (txtTrangThai.Text.CompareTo("KHÓA") == 0)
                        {
                            XtraMessageBox.Show("Bạn không thể khóa tài khoản của chính bạn!");
                            return;
                        }
                    }
                    if (TKHienTai.MatKhau.CompareTo(txtMatKhau.Text) != 0)
                    {
                        newLSTK.LichSu = "Đổi mật khẩu tài khoản " + txtTaiKhoan.Text.Trim() + " từ '" + TKHienTai.MatKhau + "' thành '" + txtMatKhau.Text.Trim() + "'";
                        DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                        DB.SubmitChanges();
                        check = 1;
                    }
                    if (TKHienTai.Quyen.CompareTo(txtQuyen.Text) != 0)
                    {
                        newLSTK.LichSu = "Đổi quyền tài khoản " + txtTaiKhoan.Text.Trim() + " từ '" + TKHienTai.Quyen + "' thành '" + txtQuyen.Text.Trim() + "'";
                        DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                        DB.SubmitChanges();
                        check = 1;
                    }
                    if (TKHienTai.Active.CompareTo(txtTrangThai.Text) != 0)
                    {
                        newLSTK.LichSu = "Đổi trạng thái tài khoản " + txtTaiKhoan.Text.Trim() + " từ '" + TKHienTai.Active + "' thành '" + txtTrangThai.Text.Trim() + "'";
                        DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                        DB.SubmitChanges();
                        check = 1;
                    }
                    if (check == 1)
                    {
                        XtraMessageBox.Show("Chỉnh sửa tài khoản thành công!");
                        taiKhoanBindingSource.EndEdit();
                        taiKhoanTableAdapter.Update(this.covidPatientManagerDTBDataSet3.TaiKhoan);
                        gridControl2.Update();
                        gridControl2.Refresh();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Thêm tài khoản thành công!");
                    isAdd = false;
                    newLSTK.LichSu = "Thêm tài khoản '" + txtTaiKhoan.Text.Trim() + "'";
                    DB.LichSuTaiKhoans.InsertOnSubmit(newLSTK);
                    DB.SubmitChanges();
                    taiKhoanBindingSource.EndEdit();
                    taiKhoanTableAdapter.Update(this.covidPatientManagerDTBDataSet3.TaiKhoan);
                }
            }
            catch (Exception)
            {
                
            }
        }

        void loadLichSuTK(string TK)
        {
            CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
            gridControl1.DataSource = DB.LichSuTaiKhoans.Where(dd => dd.TaiKhoan.CompareTo(TK) == 0).Select(dd => new { dd.NgayThang, dd.LichSu, dd.IDDiaDiemDieuTri }).ToList();
        }
        
        void loadCrurentTK()
        {
            TKHienTai.MatKhau = txtMatKhau.Text.Trim();
            TKHienTai.Quyen = txtQuyen.Text.Trim();
            TKHienTai.Active = txtTrangThai.Text.Trim();
            TKHienTai.TaiKhoan1 = txtTaiKhoan.Text.Trim();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            loadCrurentTK();
            loadLichSuTK(txtTaiKhoan.Text.Trim());
            groupControl2.Text = "LỊCH SỬ HOẠT ĐỘNG CỦA " + txtTaiKhoan.Text;

        }
    }
}