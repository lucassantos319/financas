using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Domain.Interfaces.IServices;

namespace FinancasAPI.Applications.Services
{
    public class ItensService : IItensService
    {
        private readonly IItensRepository _repository;

        public ItensService(IItensRepository repo)
        {
            _repository = repo;
        }

        public List<ItensModel> GetItensByAccount(int accountId)
        {
            if (accountId == 0)
                throw new ArgumentOutOfRangeException(nameof(accountId)); 

            return _repository.GetItensByAccountId(accountId);
        }
    }
}
