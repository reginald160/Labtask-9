using System;

namespace BankAccount
{
	public  class SavingsAccount : Account
	{
		protected decimal interest;

		public SavingsAccount (string firstName, string lastName, long accountNumber, decimal accountBalance)
			: base (firstName, lastName, accountNumber, accountBalance)
		{



		}

		public void CalculateInterest ()
		{
			interest = Balance * 1.10M;

		}

		public override void Debit ()
		{
			Console.WriteLine ("Enter Amount to withdraw");
			decimal debitAmount = Convert.ToDecimal (Console.ReadLine ());
			decimal bal = Balance - debitAmount;
			decimal totalbal = interest + bal;
			if (debitAmount > Balance) {
				Console.WriteLine ("Debit amount exceeding account balance");

			} else {
				Console.WriteLine ("your account has been debited with " + debitAmount + " and your new account  " +
				"balance with 10% interest  is " + totalbal);
			}


		}

		public override void credit ()
		{
			CalculateInterest ();
			 
			Console.WriteLine ("Enter Amount to withdraw");
			decimal creditamout = Convert.ToDecimal (Console.ReadLine ());
			decimal creditBal = creditamout + Balance;
			decimal totalbal = interest + creditBal;
			Console.WriteLine ("your account has been credited with " + creditamout + " and your new account " +
			"balance with 10% interest is " + totalbal);
		

		}


	}
}

