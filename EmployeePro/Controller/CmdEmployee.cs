using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePro.Factory;
using EmployeePro.Model;

namespace EmployeePro.Controller
{
    class CmdEmployee
    {
        Repository<CLS_Employee> cmd = new Repository<CLS_Employee>();

       public List<CLS_Employee> GetAllEmployee()
        {
            try
            {
                return cmd.GetAll("SP_GetAllEmployee").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        
     public  void AddEmployee(int empId,string fname,string lname,string address,byte[] image,double finalTotal)
        {
            try
            {
                List<CLS_Employee> emp = new List<CLS_Employee>();
                emp.Add(new CLS_Employee
                {
                    EmpId =empId,
                    FName = fname,
                    LName = lname,
                    Address = address,
                    Image = image,
                    FinalTotal = finalTotal
                });
                cmd.ExecuteParam("SP_InsertEmployee @EmpId,@FName,@LName,@Address,@Image,@FinalTotal", emp);
                              
            }
            catch (Exception)
            {
                
                
            }
        }

      public  bool EditEmployee(string fname, string lname, string address, byte[] image, double finalTotal, int empId)
        {
            try
            {
                List<CLS_Employee> emp = new List<CLS_Employee>();
                emp.Add(new CLS_Employee
                {
                    FName = fname,
                    LName = lname,
                    Address = address,
                    Image = image,
                    FinalTotal =finalTotal,
                    EmpId = empId
                });
                cmd.ExecuteParam("SP_UpdateEmployee @FName,@LName,@Address,@Image,@FinalTotal,@EmpId", emp);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        bool RemoveEmployee(int empId)
        {
            try
            {
                //List<CLS_Employee> emp = new List<CLS_Employee>();
                //emp.Add(new CLS_Employee
                //{
                //    EmpId = empId
                //});
                cmd.ExecuteParam("SP_DeleteEmployee @EmpId", new CLS_Employee { EmpId = empId });
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
