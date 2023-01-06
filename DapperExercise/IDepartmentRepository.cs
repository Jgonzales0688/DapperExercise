using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExercise
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); //stubbed out method
    }
}
