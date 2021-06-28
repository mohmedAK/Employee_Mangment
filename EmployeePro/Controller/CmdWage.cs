using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePro.Factory;
using EmployeePro.Model;

namespace EmployeePro.Controller
{
    class CmdWage
    {
        Repository<CLS_Wage> cmd = new Repository<CLS_Wage>();

       public List<CLS_Wage> GetAllWage()
        {
            try
            {
                return cmd.GetAll("SP_AllWage").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

      public  List<CLS_Wage> GetWageById(int empId)
        {
            try
            {
                return cmd.GetById("SP_ByIdWage @EmpId", new CLS_Wage { EmpId = empId}).ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

      public bool AddWage(int empId,DateTime entryDate,double salary,double discount,double total)
        {
            try
            {
                List<CLS_Wage> emp = new List<CLS_Wage>()
                {
                    new CLS_Wage
                    {
                        EmpId = empId,
                        EntryDate = entryDate,
                        Salary = salary,
                        Discount = discount,
                        Total =total
                    }
                };
                cmd.ExecuteParam("SP_InsertWage @EmpId,@EntryDate,@Salary,@Discount,@Total", emp);
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public bool EditWage(int empId, DateTime entryDate, double salary, double discount, double total)
        {
            try
            {
                List<CLS_Wage> emp = new List<CLS_Wage>()
                {
                    new CLS_Wage
                    {
                        EmpId = empId,
                        EntryDate = entryDate,
                        Salary = salary,
                        Discount = discount,
                        Total =total
                    }
                };
                cmd.ExecuteParam("SP_EditWage @EmpId,@EntryDate,@Salary,@Discount,@Total", emp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
