using System;
using SharkBank;
class Program
{
  static void Main(string[] args)
  {
    // Create Users
    List<Account> users = new List<Account>();
    users.Add(new Account(1, "Jim", 0000, 200));
    users.Add(new Account(2, "Pam", 0000, 200));
    users.Add(new Account(3, "Dwight", 0000, 200));

    // Login
    Account current_user;
    int user_option;

    while (true)
    {
      // Ask user what they want to do
      Console.WriteLine("Please enter user name: \n");
      string user_name = Console.ReadLine();
      current_user = users.Find(x => x.user_name == user_name);
      if (current_user != null) { break; }
      else { Console.WriteLine("Invalid username. Please try again \n"); }
    }

    while (true)
    {
      // Ask user for pin
      Console.WriteLine("Enter your pin: \n");
      int user_pin = int.Parse(Console.ReadLine());
      if (current_user.user_pin == user_pin) { break; }
      else { Console.WriteLine("Incorrect Pin. Please try again \n"); }
    }

    Console.WriteLine($"Welcome, {current_user.user_name} \n");

    do
    {
      Console.WriteLine("Please choose from the following options.");
      Console.WriteLine("1. Deposit");
      Console.WriteLine("2. Withdraw");
      Console.WriteLine("3. View balance");
      Console.WriteLine("4. Logout\n\n");

      user_option = int.Parse(Console.ReadLine());

      switch (user_option)
      {
        case 1:
          Console.WriteLine("How much would you like to deposit?");
          double deposit = double.Parse(Console.ReadLine());
          ATMMachine.makeDeposit(current_user, deposit);
          break;
        case 2:
          Console.WriteLine("How much would you like to withdraw?");
          double withdraw = double.Parse(Console.ReadLine());
          ATMMachine.makeWithdraw(current_user, withdraw);
          break;
        case 3:
          Console.WriteLine($"Your current balance is: {ATMMachine.getBalance(current_user)}");
          break;
        case 4:
          Console.WriteLine("Thank you for using ShakBank \n\n");
          break;
      }
    } while (user_option != 4);

  } // method Main()

} // class Program