using Avanade.SubTCSE.Projeto.Application.DTOs.EmployeeRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        public void AddEmployeeRole(EmployeeRoleDTO employeeRoleDTO);
    }
}
