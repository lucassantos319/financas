using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasAPI.Domain.Entities.Factory
{
    public class AccountFactory
    {
        public AccountFactory()
        {
        }

        public AccountModel CreateAccount(object newAccountObj)
        {
            var newAccount = JsonConvert.DeserializeObject<AccountModel>(newAccountObj.ToString());
            return new AccountModel
            {
                IsActive = true,
                Name = newAccount.Name,
                UserId = newAccount.UserId,
            };
        
        }

    }
}
