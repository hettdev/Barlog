using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Barlog.Models;

namespace Barlog.Data
{
    public class OrderItemDatabase
    {
        readonly SQLiteAsyncConnection db;

        public OrderItemDatabase(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<OrderItem>().Wait();
        }

        public Task<List<OrderItem>> GetItemsAsync()
        {
            return db.Table<OrderItem>().ToListAsync();
        }

        public Task<OrderItem> GetItemAsync(int id)
        {
            return db.Table<OrderItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(OrderItem item)
        {
            if (item.ID != 0)
            {
                return db.UpdateAsync(item);
            }
            else
            {
                return db.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(OrderItem item)
        {
            return db.DeleteAsync(item);
        }
    }
}
