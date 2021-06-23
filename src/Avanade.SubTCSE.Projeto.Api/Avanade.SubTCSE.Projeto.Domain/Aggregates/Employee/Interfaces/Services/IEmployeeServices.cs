using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeServices
    {
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
