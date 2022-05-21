using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Infra.data;

namespace FinancasAPI.Infra.Repositories
{
    public class ItensRepository : IItensRepository
    {
        private readonly Context _context;
        public ItensRepository(Context context)
        {
            _context = context; 
        }

        public List<ItensModel> GetAllItem()
        {
            return _context.Itens.ToList();
        }

        public ItensModel GetItemById(int itensId)
        {
            return _context.Itens.FirstOrDefault(x => x.Id == itensId);
        }

        public void CreateItem(ItensModel newItem)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Itens.Add(newItem);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public void UpdateItem(ItensModel item)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Itens.Update(item);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public void DeleteItem(ItensModel item)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Itens.Add(item);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public List<ItensModel> GetItensByAccountId(int accountId)
        {
            return _context.Itens.Where(x => x.AccountId == accountId).ToList();
        }

    }
}
