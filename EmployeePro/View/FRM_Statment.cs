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
using EmployeePro.Controller;
using EmployeePro.Model;
namespace EmployeePro.View
{
    public partial class FRM_Statment : DevExpress.XtraEditors.XtraForm
    {
        CmdEmployee cmdEmployee = new CmdEmployee();
        public FRM_Statment()
        {
            InitializeComponent();
            GetAllEmployee();
        }


        void GetAllEmployee()
        {
         List<CLS_Employee> employees=   cmdEmployee.GetAllEmployee();
            gcEmployee.DataSource = employees;
        }

        private void barButtonIAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRM_Employee frm = new FRM_Employee();
            frm.barButtonAddWage.Enabled = false;
            frm.barButtonEditEmployee.Enabled = false;
            frm.Show();
            this.Hide();
        }

      

        private void repPreview_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void repPreview_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.Hide();

            FRM_Employee frm = new FRM_Employee();
            frm.txtId.Text = gvEmployee.GetFocusedRowCellValue("EmpId").ToString();
            frm.txtFirstName.Text = gvEmployee.GetFocusedRowCellValue("FName").ToString();
            frm.txtLastName.Text = gvEmployee.GetFocusedRowCellValue("LName").ToString();
            frm.txtAddress.Text = gvEmployee.GetFocusedRowCellValue("Address").ToString();
            frm.txtFinalTotal.Text = gvEmployee.GetFocusedRowCellValue("FinalTotal").ToString();

            byte[] image = (byte[])gvEmployee.GetFocusedRowCellValue("Image");
            HelperClass.retrieveImage(image, frm.pictureEdit1);
            HelperClass.NotEnableControls(frm.tableLayoutEmployee);
            frm.btnAddEmployee.Enabled = false;
            frm.loadWage();
            frm.Show();
        }
    }
}