using BussinessObject.Model.Authen;
using BussinessObject.Model.ModelUser;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public Account Authenticate(UserLogin login) => AccountDAO.Authenticate(login);

        public bool CheckAccount(string userName, string password) => AccountDAO.CheckAccount(userName, password);

        public List<Account> GetListAccount() => AccountDAO.GetListAccount();

        public Account GetAccountById(Guid id) => AccountDAO.GetAccountById(id);

        public void UpdateAccount(Guid id, Account account) => AccountDAO.UpdateAccount(id, account);

        public void DeleteAccount(Guid id)  => AccountDAO.DeleteAccount(id);

        public void AddAccount(Account account) => AccountDAO.AddAccount(account);

        public Guid GetAccountId(string userName)
        {
            return AccountDAO.GetAccountId(userName);
        }
    }
}
