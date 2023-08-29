using roastreview.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roastreview.data
{
    public static class StockManager
    {
        public static List<StockItem> StockItems = new List<StockItem>()
        {
            new StockItem{ Id=1, Name="Red Eye Coffee", Rating=4},
            new StockItem{ Id=2, Name="Mocha", Rating=2}
        };

        public static List<StockItem> GetStocks()
        {
            return StockItems;
        }
    }
}
