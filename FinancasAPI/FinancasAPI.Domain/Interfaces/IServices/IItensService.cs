using FinancasAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasAPI.Domain.Interfaces.IServices
{
    public interface IItensService
    {
        List<ItensModel> GetItensByAccount(int accountId);
    }
}
