using BussinessObject.ContextData;
using BussinessObject.Model.Authen;
using BussinessObject.Model.ModelUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AccountDAO
    {
        //Check Account Data
        public static bool CheckAccount(string userName, string password)
        {
            using var db = new HealthExpertContext();
            var account = db.accounts.FirstOrDefault(account => account.userName == userName && account.password == password);
            return account != null;
        }

        //Get Account Data
        public static Account Authenticate(UserLogin login)
        {
            var account = new Account();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    account = ctx.accounts.FirstOrDefault(account => account.userName == login.userName && account.password == login.password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return account;
        }

        //Get List Account Data
        public static List<Account> GetListAccount()
        {
            var listAccount = new List<Account>();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    listAccount = ctx.accounts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listAccount;
        }

        //Get Account Data by Id
        public static Account GetAccountById(Guid id)
        {
            var account = new Account();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    account = ctx.accounts.FirstOrDefault(account => account.accountId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return account;
        }

        //Add Account Data
        public static void AddAccount(Account account)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    ctx.accounts.Add(account);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Update Account Data
        public static void UpdateAccount(Guid id, Account account)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    if (GetAccountById(id) != null)
                    {
                        ctx.accounts.Add(account);
                        ctx.Entry(account).State =
                            Microsoft.EntityFrameworkCore.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Delete Account Data
        public static void DeleteAccount(Guid id)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var account = GetAccountById(id);
                    if (account != null)
                    {
                        ctx.accounts.Remove(account);
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
