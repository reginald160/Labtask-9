using System;

namespace BankAccount
{
	class MainClass
	{
		public static void Main (string[] args)
		{ 
			var savingsAccount = new SavingsAccount ("james", "obi", 22222222, 12322m);

			var currentAccount = new  CurrentAccount ("kalu", "ezei", 22222222, 433322m);

			//savingsAccount.Debit ();
			//savingsAccount.credit ();

			Account[] account = new Account[2] {
				savingsAccount,
				currentAccount

			};
			Console.WriteLine (" Enter your Account Number");
			string accountNumber = Console.ReadLine ();

			Console.WriteLine (" press 1 for current account or press 2 for savings account");
			int typeOfAccount = Convert.ToInt32 (Console.ReadLine ());

			if (typeOfAccount == 1) {
				Console.WriteLine (" Press 1 for deposit or 2 for withdrawal");
				int typeOfTransaction = Convert.ToInt32 (Console.ReadLine ());

				if (typeOfTransaction == 1) {
					account [1].Debit ();


				} else if (typeOfTransaction == 2) {
					account [1].credit ();


				} else {
					throw new ArgumentOutOfRangeException ("Value out of range");
				}	
			}


			if (typeOfAccount == 2) {
				Console.WriteLine (" Press 1 for deposit or 2 for withdrawal");
				int typeOfTransaction = Convert.ToInt32 (Console.ReadLine ());

				if (typeOfTransaction == 1) {
					account [0].Debit ();


				} else if (typeOfTransaction == 2) {
					account [0].credit ();


				} else {
					throw new ArgumentOutOfRangeException ("Value out of range");
				}	
			}
		}

	}






}

