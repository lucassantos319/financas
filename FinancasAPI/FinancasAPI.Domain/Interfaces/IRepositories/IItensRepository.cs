using FinancasAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasAPI.Domain.Interfaces.IRepositories
{
    public interface IItensRepository
    {
        List<ItensModel> GetAllItem();
        ItensModel GetItemById(int itensId);
        void CreateItem(ItensModel newItem);
        void UpdateItem(ItensModel item);
        void DeleteItem(ItensModel item);
        List<ItensModel> GetItensByAccountId(int accountId);

    }
}
