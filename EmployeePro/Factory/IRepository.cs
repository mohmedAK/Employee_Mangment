﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePro.Factory
{
   public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll(string sqlstr);
        IEnumerable<T> GetById(string sqlstr,object param);

        void Execute(string sqlstr);
        void ExecuteParam(string sqlstr, object param);
    }
}
