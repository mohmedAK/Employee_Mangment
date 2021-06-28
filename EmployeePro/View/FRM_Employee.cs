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
using EmployeePro.Model;
using EmployeePro.Controller;
namespace EmployeePro.View
{
    public partial class FRM_Employee : DevExpress.XtraEditors.XtraForm
    {
        CmdEmployee cmdEmployee = new CmdEmployee();
        CmdWage cmdWage = new CmdWage();
        public FRM_Employee()
        {
            InitializeComponent();
            HelperClass.NotEnableControls(tableLayoutWage);
            btnAddWage.Enabled = false;
        }

        private void FRM_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddWage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDate.Text) || string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                XtraMessageBox.Show("يرجى ملئ جميع الحقول");
            }
            else if (btnAddWage.Text == "Add Wage")
            {
                AddWage();
                loadWage();
                HelperClass.ClearValue(tableLayoutWage);
            }
            else if (btnAddWage.Text == "Edit Wage")
            {
                EditWage();
                loadWage();
                HelperClass.ClearValue(tableLayoutWage);
                HelperClass.NotEnableControls(tableLayoutWage);
                btnAddWage.Enabled = false;
                btnAddWage.Text = "Add Wage";

            }
           
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text)||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||string.IsNullOrWhiteSpace(txtFinalTotal.Text)|| pictureEdit1.Image == null)
            {
                XtraMessageBox.Show("Please fill All Fildes");
            }
            else
            {
                AddEmployee();
                HelperClass.EnableControls(tableLayoutWage);
                btnAddWage.Enabled = true;

                XtraMessageBox.Show("Add Done");
            }
        }

        //Add Employee
        void AddEmployee()
        {
            byte[] image = HelperClass.saveImage(pictureEdit1);
            cmdEmployee.AddEmployee(int.Parse(txtId.Text),txtFirstName.Text,txtLastName.Text,txtAddress.Text,image,double.Parse(txtFinalTotal.Text));
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ==DialogResult.OK)
            {
                pictureEdit1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

      public  void loadWage()
        {
            List<CLS_Wage> wages = cmdWage.GetWageById(int.Parse(txtId.Text));
            gcWage.DataSource = wages;
        }

        void AddWage()
        {
            
                double total = double.Parse(txtSalary.Text) - double.Parse(txtDiscount.Text);
                if (cmdWage.AddWage(int.Parse(txtId.Text), txtDate.DateTime, double.Parse(txtSalary.Text), double.Parse(txtDiscount.Text), total))
                {
                    XtraMessageBox.Show("تمت الاضافة بنجاح");
                }
                else
                {
                    XtraMessageBox.Show("لم تتم الاضافة بنجاح");
                }
            
        }

        void EditWage()
        {
            double total = double.Parse(txtSalary.Text) - double.Parse(txtDiscount.Text);
            if (cmdWage.EditWage(int.Parse(txtId.Text), txtDate.DateTime, double.Parse(txtSalary.Text), double.Parse(txtDiscount.Text), total))
            {
                XtraMessageBox.Show("تمت التعديل بنجاح");
            }
            else
            {
                XtraMessageBox.Show("لم يتم التعديل بنجاح");
            }
        }

        private void barButtonHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FRM_Statment frm = new FRM_Statment();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Statment frm = new FRM_Statment();
            frm.Show();
        }

        private void repEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtDate.Text = gvWage.GetFocusedRowCellValue("EntryDate").ToString();
            txtSalary.Text = gvWage.GetFocusedRowCellValue("Salary").ToString();
            txtDiscount.Text = gvWage.GetFocusedRowCellValue("Discount").ToString();
            btnAddWage.Text = "Edit Wage";
            HelperClass.EnableControls(tableLayoutWage);
            btnAddWage.Enabled = true;

            
        }
    }
}