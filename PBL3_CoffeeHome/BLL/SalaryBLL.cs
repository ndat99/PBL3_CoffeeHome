using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.BLL
{
    public class SalaryBLL
    {
        private readonly SalaryDAL _salaryDAL;
        public SalaryBLL()
        {
            _salaryDAL = new SalaryDAL();
        }
        public List<SalaryDTO> GetAllSalaries()
        {
            return _salaryDAL.GetAllSalary();
        }
        public List<string> GetYearBySalary()
        {
            return _salaryDAL.GetYearBySalary();
        }
   
        public List<SalaryDTO> SearchSalary(string thang, string nam, string txtsearch)
        {
            return _salaryDAL.SearchSalary(thang, nam, txtsearch);
        }

        public void UpdateStatusSalary(string salaryId)
        {
            _salaryDAL.UpdateStatusSalary(salaryId);
        }
    }
}
