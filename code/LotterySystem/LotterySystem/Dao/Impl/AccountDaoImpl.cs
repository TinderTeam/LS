using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotterySystem.Po;
using LotterySystem.Test.Stub;
namespace LotterySystem.Dao
{
    public class AccountDaoImpl :AccountDao
    {


        public List<Account> getAll()
        {
            return null;
        }
        public Account getAccountByUserName(String userName)
        {
            List<Account> list= DBStub.getDBStub().getAccountList();
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].UserName.Equals(userName)){
                    return list[i];
                }
            }
            return null;
        }
        public void creatAccount(Account account)
        {
        }
        public void deleteAccountByUserName(String userName)
        {
        }
        public void updateAccount(Account account)
        {
        }
    }
}