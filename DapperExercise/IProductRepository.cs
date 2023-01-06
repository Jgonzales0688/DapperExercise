using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExercise
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(); //stubbed out 

        public void CreateProduct(string name, double price, int categoryID)
        { 
            throw new NotImplementedException();
        }
    }
}
