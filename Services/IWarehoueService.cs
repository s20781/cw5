using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw5.Services
{
    interface IWarehoueService
    {

        public Task<bool> DoesProductExist(int productId);
        public Task<bool> DoesWarehouseExist(int productId);
        public Task<int> GetTheValidOrderId(int warehouseId, int productId, int amount, DateTime createdAt);
        public Task<bool> CompeleteTheOrder(int orderId, int warehouseId, int productId, int amount, int createdAt);
        public Task<double> GetTheProductPrice(int productId);
        public Task<int> StoredProcedure(int warehouseId, int productId, int amount, DateTime createdAt);
    }
}
