using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;

namespace LotterySystem.Dao
{
    public interface AccountDao
    {
        List<Account> getAll();
        Account getAccountByUserName(String userName);
        void creatAccount(Account account);
        void deleteAccountByUserName(String userName);
        void updateAccount(Account account);


    }
}