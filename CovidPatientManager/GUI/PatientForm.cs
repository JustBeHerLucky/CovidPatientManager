using CovidPatientManager.DTO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CovidPatientManager.GUI
{
    public partial class PatientForm : DevExpress.XtraEditors.XtraForm
    {
        string userQuanLy;
        bool isAdd = false;
        BenhNhan currentBN;
        public PatientForm(string UserQuanLy)
        {
            userQuanLy = UserQuanLy;
            currentBN = new BenhNhan();
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                benhNhanBindingSource.AddNew();
                txtDiaDiemDieuTri.Text = "";
                getGoiY();
                isAdd = true;
            }
            catch (Exception) { }
        }

        void UpdateCbbTrangThai()
        {
            cbbTrangThai.Properties.Items.Add("KHỎI BỆNH");
            cbbTrangThai.Properties.Items.Add("F0");
            cbbTrangThai.Properties.Items.Add("F1");
            cbbTrangThai.Properties.Items.Add("F2");
            cbbTrangThai.Properties.Items.Add("F3");
            cbbTrangThai.Properties.Items.Add("QUA ĐỜI");
        }

        void UpdateCbbLienQuan()
        {
            CovidPatientManagerDTBDataContext Db = new CovidPatientManagerDTBDataContext();
            var listLQ = Db.BenhNhans.ToList();
            cbbLienQuanVoi.Properties.Items.Add("CỘNG ĐỒNG");
            foreach (BenhNhan bn in listLQ)
            {
                cbbLienQuanVoi.Properties.Items.Add(bn.ID);
            }
        }

        void UpdateCbbDieuTri()
        {
            CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
            foreach (DiaDiemDieuTri dd in DB.DiaDiemDieuTris.ToList())
            {
                cbbDiaDiemDieuTri.Properties.Items.Add(dd.IDDiaDiemDieuTri);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
                LichSuBenhNhan newLSBN = new LichSuBenhNhan();
                newLSBN.ID = txtID.Text.Trim();
                newLSBN.TaiKhoan = userQuanLy.Trim();
                newLSBN.NgayThang = DateTime.Now.ToString();

                if (isAdd == false)
                {
                    int checkk = 0;
                    if (currentBN.IDDiaDiemDieuTri.Trim().CompareTo(cbbDiaDiemDieuTri.Text.Trim()) != 0)
                    {
                        if (!isMax(cbbDiaDiemDieuTri.Text))
                        {
                            checkk = 1;
                            newLSBN.LichSu = "Đổi nơi chữa trị từ '" + currentBN.IDDiaDiemDieuTri.Trim() + "' thành '" + cbbDiaDiemDieuTri.Text.Trim() + "'";
                            DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                            DB.SubmitChanges();
                            UpDateCountPatient(cbbDiaDiemDieuTri.Text);
                            UpDateCountPatient(currentBN.IDDiaDiemDieuTri.Trim());
                        }
                        else
                        {
                            XtraMessageBox.Show(txtDiaDiemDieuTri.Text + " đã đạt giới hạn");
                        }
                    }
                    if (currentBN.HoTen.Trim().CompareTo(txtHoTen.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSBN.LichSu = "Đổi họ tên từ '" + currentBN.HoTen.Trim() + "' thành " + txtHoTen.Text.Trim() + "";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                    }
                    if (currentBN.CMND.Trim().CompareTo(txtCMND.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSBN.LichSu = "Đổi CMND từ '" + currentBN.CMND.Trim() + "' thành '" + txtCMND.Text.Trim() + "'";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                    }
                    if (currentBN.NamSinh.Trim().CompareTo(txtNamSinh.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSBN.LichSu = "Đổi năm sinh từ '" + currentBN.NamSinh.Trim() + "' thành '" + txtNamSinh.Text.Trim() + "'";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                    }
                    if (currentBN.DiaChi.Trim().CompareTo(txtDiaChi.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSBN.LichSu = "Đổi địa chỉ từ '" + currentBN.DiaChi.Trim() + "' thành '" + txtDiaChi.Text.Trim() + "'";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                    }
                    if (currentBN.TrangThai.Trim().CompareTo(cbbTrangThai.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSBN.LichSu = "Đổi trạng thái từ '" + currentBN.TrangThai.Trim() + "' thành '" + cbbTrangThai.Text.Trim() + "'";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                    }
                    if (currentBN.LienQuan.Trim().CompareTo(cbbLienQuanVoi.Text.Trim()) != 0)
                    {
                        checkk = 1;
                        newLSBN.LichSu = "Đổi người tiếp xúc từ '" + currentBN.LienQuan.Trim() + "' thành '" + cbbLienQuanVoi.Text.Trim() + "'";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                    }
                    if (checkk == 1)
                    {
                        XtraMessageBox.Show("Chỉnh sửa bệnh nhân thành công!");
                        benhNhanBindingSource.EndEdit();
                        benhNhanTableAdapter.Update(this.covidPatientManagerDTBDataSet1.BenhNhan);
                        gridControl1.Update();
                        gridControl1.Refresh();
                    }
                }
                else
                {
                    if (!isMax(cbbDiaDiemDieuTri.Text))
                    {
                        XtraMessageBox.Show("Thêm bệnh nhân thành công!");
                        isAdd = false;
                        newLSBN.LichSu = "Thêm bệnh nhân '" + txtID.Text.Trim() + "'";
                        DB.LichSuBenhNhans.InsertOnSubmit(newLSBN);
                        DB.SubmitChanges();
                        UpDateCountPatient(cbbDiaDiemDieuTri.Text);
                    }
                    else
                    {
                        XtraMessageBox.Show(txtDiaDiemDieuTri.Text + " đã đạt giới hạn!");
                    }
                }


                LoadLichSu();
                LoadCurBN();
            }
            catch (Exception)
            {
                
            }
        }


        bool isMax(string IDDT)
        {
            CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
            var Num = DB.DiaDiemDieuTris.Where(dd => dd.IDDiaDiemDieuTri.CompareTo(IDDT) == 0).ToList();
            if (Num[0].SucChua == Num[0].HienTai) return true;
            return false;
        }

        void UpDateCountPatient(string IDDT)
        {
            CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
            int num = DB.BenhNhans.Where(dd => dd.IDDiaDiemDieuTri.CompareTo(IDDT) == 0 && dd.TrangThai.CompareTo("KHỎI BỆNH") != 0 && dd.TrangThai.CompareTo("QUA ĐỜI") != 0).Count();
            DiaDiemDieuTri item = DB.DiaDiemDieuTris.Where(dd => dd.IDDiaDiemDieuTri.CompareTo(IDDT) == 0).SingleOrDefault();
            item.HienTai = num.ToString();
            DB.SubmitChanges();
        }


        void LoadLichSu()
        {
            CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
            var aa = DB.LichSuBenhNhans.Where(dd => dd.ID.CompareTo(txtID.Text) == 0).Select(dd => new { dd.NgayThang, dd.LichSu, dd.TaiKhoan }).ToList();
            gridControl2.DataSource = aa;
        }

        

        private void PatientForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'covidPatientManagerDTBDataSet4.BenhNhan' table. You can move, or remove it, as needed.
            UpdateCbbTrangThai();
            UpdateCbbLienQuan();
            UpdateCbbDieuTri();
            loadCBBTP();
            
            this.benhNhanTableAdapter.Fill(this.covidPatientManagerDTBDataSet1.BenhNhan);

        }

        private void cbbDiaDiemDieuTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbbDiaDiemDieuTri.Text) == false)
            {
                CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();
                txtDiaDiemDieuTri.Text = DB.DiaDiemDieuTris.Where(dd => dd.IDDiaDiemDieuTri == cbbDiaDiemDieuTri.SelectedItem.ToString()).ToList()[0].TenDiemDieuTri;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân " + txtID.Text + "?", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (XtraMessageBox.Show("Xóa là xóa hết những gì liên quan đến cái tài khoản này á, chắc chắn xóa chưa?", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (XtraMessageBox.Show("Hỏi lại lần nữa. Thật?", "Xác nhận!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XtraMessageBox.Show("Ok xóa thì xóa!");
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                        benhNhanTableAdapter.Update(this.covidPatientManagerDTBDataSet1.BenhNhan);
                    }
                }
            }

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadCurBN();
            LoadLichSu();
            txtLS.Text = "LỊCH SỬ BỆNH NHÂN " + txtID.Text.ToString();
        }

        void LoadCurBN()
        {
            currentBN.CMND = txtCMND.Text;
            currentBN.DiaChi = txtDiaChi.Text;
            currentBN.IDDiaDiemDieuTri = cbbDiaDiemDieuTri.Text;
            currentBN.LienQuan = cbbLienQuanVoi.Text;
            currentBN.HoTen = txtHoTen.Text;
            currentBN.NamSinh = txtNamSinh.Text;
            currentBN.ID = txtID.Text;
            currentBN.TrangThai = cbbTrangThai.Text;
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            benhNhanBindingSource.CancelEdit();
            txtID.ReadOnly = true;
            isAdd = false;
        }

        void getGoiY()
        {
            CovidPatientManagerDTBDataContext Db = new CovidPatientManagerDTBDataContext();
            int num = Db.BenhNhans.ToList().Count + 1;
            string goiY = "BN";
            for (int i = 8; i > num.ToString().Length; i--)
            {
                goiY += "0";
            }
            goiY += num.ToString();
            txtID.Text = goiY;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else if (e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else if (e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        public void loadCBBTP()
        {
            CovidPatientManagerDTBDataContext Db = new CovidPatientManagerDTBDataContext();
            var aa = Db.VietNams.Select(dd => new { dd.TenThanhPho }).ToList().Distinct();
            foreach (var bn in aa)
            {
                cbbThanhPho.Properties.Items.Add(bn.TenThanhPho);
                cbbThanhPho1.Properties.Items.Add(bn.TenThanhPho);
            }
        }

        public void loadCBBQ(DevExpress.XtraEditors.ComboBoxEdit Dad, DevExpress.XtraEditors.ComboBoxEdit Son)
        {
            Son.Properties.Items.Clear();
            CovidPatientManagerDTBDataContext Db = new CovidPatientManagerDTBDataContext();
            var aa = Db.VietNams.Where(dd => dd.TenThanhPho.CompareTo(Dad.Text) == 0).Select(dd => new { dd.TenQuan }).ToList().Distinct();
            foreach (var bn in aa)
            {
                Son.Properties.Items.Add(bn.TenQuan);
            }
        }

        private void cbbThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBBQ(cbbThanhPho, cbbQuan);
            UpdateDiaChi();
        }

        public void loadCBBPhuong(DevExpress.XtraEditors.ComboBoxEdit Grand, DevExpress.XtraEditors.ComboBoxEdit Dad, DevExpress.XtraEditors.ComboBoxEdit Son)
        {
            Son.Properties.Items.Clear();
            CovidPatientManagerDTBDataContext Db = new CovidPatientManagerDTBDataContext();
            var aa = Db.VietNams.Where(dd => dd.TenThanhPho.CompareTo(Grand.Text) == 0 && dd.TenQuan.CompareTo(Dad.Text) == 0).Select(dd => new { dd.TenPhuong }).ToList().Distinct();
            foreach (var bn in aa)
            {
                Son.Properties.Items.Add(bn.TenPhuong);
            }
        }

        private void cbbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBBPhuong(cbbThanhPho, cbbQuan, cbbPhuong);
            UpdateDiaChi();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            List<string> li = txtDiaChi.Text.Split(',').ToList();
            try
            {
                cbbThanhPho.Text = li[3].Trim();
            }
            catch (Exception) { cbbThanhPho.Text = ""; };
            try
            {
                cbbQuan.Text = li[2].Trim();
            }
            catch (Exception) { cbbQuan.Text = ""; };
            try
            {
                cbbPhuong.Text = li[1].Trim();
            }
            catch (Exception) { cbbPhuong.Text = ""; };
            try
            {
                txtSo.Text = li[0].Trim();
            }
            catch (Exception) { txtSo.Text = ""; };
        }

        void UpdateDiaChi()
        {
            txtDiaChi.Text = txtSo.Text + ", " + cbbPhuong.Text + ", " + cbbQuan.Text + ", " + cbbThanhPho.Text;
        }

        private void DiaChi_TextChanged(object sender, EventArgs e)
        {
            UpdateDiaChi();
        }

        private void cbbPhuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiaChi();
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBBPhuong(cbbThanhPho1, cbbQuan1, cbbPhuong1);
        }

        private void cbbThanhPho1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBBQ(cbbThanhPho1, cbbQuan1);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = benhNhanBindingSource;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CovidPatientManagerDTBDataContext DB = new CovidPatientManagerDTBDataContext();


            string end = "";
            if (String.IsNullOrEmpty(cbbThanhPho1.Text) == false)
            {
                end = ", " + cbbThanhPho1.Text;
                if (String.IsNullOrEmpty(cbbQuan1.Text) == false)
                {
                    end = ", " + cbbQuan1.Text;
                    if (String.IsNullOrEmpty(cbbPhuong1.Text) == false)
                    {
                        end = ", " + cbbPhuong1.Text;

                    }
                }
            }
            var aa = DB.BenhNhans.Where(dd => dd.DiaChi.EndsWith(end)).ToList();
            gridControl1.DataSource = aa;
        }

        private void txtCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadCurBN();
            LoadLichSu();
            txtLS.Text = "LỊCH SỬ BỆNH NHÂN " + txtID.Text.ToString();
        }
    }
}