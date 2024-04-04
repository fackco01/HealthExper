using BussinessObject.Model.Authen;
using BussinessObject.Model.ModelUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IAccountRepository
    {
        Account Authenticate(UserLogin login);
        bool CheckAccount(string userName, string password);
        List<Account> GetListAccount();
        Account GetAccountById(Guid id);
        void AddAccount(Account account);
        void UpdateAccount(Guid id,Account account);
        void DeleteAccount(Guid id);
        Guid GetAccountId(string userName);
    }
}
