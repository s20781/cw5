using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw5.Services
{
    public class WarehouseService : IWarehoueService
    {
        public Task<bool> CompeleteTheOrder(int orderId, int warehouseId, int productId, int amount, int createdAt)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesProductExist(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesWarehouseExist(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<double> GetTheProductPrice(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTheValidOrderId(int warehouseId, int productId, int amount, DateTime createdAt)
        {
            throw new NotImplementedException();
        }

        public Task<int> StoredProcedure(int warehouseId, int productId, int amount, DateTime createdAt)
        {
            throw new NotImplementedException();
        }
    }
}
