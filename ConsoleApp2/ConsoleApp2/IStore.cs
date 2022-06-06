using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IStore
    {
        string Products { get; }

        int ProductLimit { get; }

        int TotalIncome { get; }

      void AddProduct(Product[] product) 
        {
           
        }
        void SellProduct(string no) 
        {
        
        
        }
        


    
    
    }
}
