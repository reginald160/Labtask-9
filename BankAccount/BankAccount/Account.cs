using System;

namespace BankAccount
{
	public abstract class Account
	{

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public long AccountNumber { get; set; }

		private decimal accountBalance;




		public Account (string firstName, string lastName, long accountNumber, decimal accountBalance)
		{
			FirstName = firstName;

			LastName = lastName;

			AccountNumber = accountNumber;

			Balance = accountBalance;

		}





		public decimal Balance {

			get { return accountBalance; }

			set {
				if (value > 0M) {
					accountBalance = value;
				} else {
					throw new ArgumentOutOfRangeException ("Account Balance must not be less than zero [Balance be a positive Number]");
				}

			}
		}

		public abstract void credit ();

		public abstract void Debit ();


	}
}

