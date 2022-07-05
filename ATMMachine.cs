using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkBank
{
  static class ATMMachine
  {
    public static void makeDeposit(Account current_user, double cash)
    {
      current_user.balance += cash;
    }

    public static void makeWithdraw(Account current_user, double cash)
    {
      current_user.balance -= cash;
    }

    public static double getBalance(Account current_user)
    {
      return current_user.balance;
    }

  } // class ATMMachine

} // namesoace SharkBank
