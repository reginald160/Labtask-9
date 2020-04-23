using System;

namespace BankAccount
{
	class CurrentAccount : Account
	{
		public CurrentAccount (string firstName, string lastName, long accountNumber, decimal accountBalance)
			: base (firstName, lastName, accountNumber, accountBalance)
		{



		}


		public override void Debit ()
		{
			Console.WriteLine ("Enter Amount to withdraw");
			decimal debitAmount = Convert.ToDecimal (Console.ReadLine ());
			decimal bal = Balance - debitAmount;
			if (debitAmount > Balance) {
				Console.WriteLine ("Debit amount exceeding account balance");

			} else {
				Console.WriteLine ("your account has been debited with " + debitAmount + " and your new account " +
				"balance is " + bal);
			}


		}

		public override void credit ()
		{

			Console.WriteLine ("Enter Amount to withdraw");
			decimal creditamout = Convert.ToDecimal (Console.ReadLine ());
			decimal creditBal = creditamout + Balance;
			Console.WriteLine ("your account has been credited with " + creditamout + " and your new account " +
			"balance is " + creditBal);


		}


		
	}
}

