using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkBank
{
  internal class Account
  {

    // Fields
    public int user_id = 0;
    public string user_name = "";
    public int user_pin = 0000;
    public double balance = 0;

    // Constructor / Methods
    public Account(int userID, string userNAME, int userPIN, double userBALANCE)
    {
      this.user_id = userID;
      this.user_name = userNAME;
      this.user_pin = userPIN;
      this.balance = userBALANCE;
    }

  }
}
