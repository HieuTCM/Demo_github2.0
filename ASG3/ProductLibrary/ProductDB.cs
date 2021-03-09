using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class ProductDB
    {
        string strConnection;
        public ProductDB()
        {
            strConnection = getConnectionString();
        }
        private string getConnectionString()
        {
            string strConnection = "Server=SE140040\\SQLEXPRESS;database=SaleDB;uid=sa;pwd=01687961788hieu";
            return strConnection;
        }

        bool AddNewProduct(Product p)
        {
            return false;
        }
        bool RemoveProduct(Product p)
        {
            
            return false;
        }
        bool UpdateProduct(Product p)
        {
            
            return false;
        }
        
    }
}
