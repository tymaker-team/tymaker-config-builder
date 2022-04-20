using System;

public class Program
{
	public static void Main()
	{
		//Prints version and title into console
		Console.Write("Thank-you note bot");
		Console.Write('\n');
		Console.Write("Version 1.0.0");
		Console.Write('\n');
		//sets up restart counter
		int attempts = 0;
		bool done = false;
		//Sets up restart loop
		while (!done)
		{
			//sets up restart counter (attempts)
			if (attempts > 1)
			{
				Console.Write("You have redone this section " + attempts + " times.");
				Console.Write('\n');
			}

			//Asks who the letter is directed to
			Console.Write('\n');
			Console.Write("Who are you writing to?");
			Console.Write('\n');
			//Reads answer to varible "reciever"
			string reciever = Console.ReadLine();
			Console.Write('\n');
			//Asks what gift was recieved
			Console.Write("What gift did you get from " + reciever + "?");
			Console.Write('\n');
			//Reads answer to varible "gift"
			string gift = Console.ReadLine();
			Console.Write('\n');
			//Asks what type party the person went to
			Console.Write("What party did you invite " + reciever + " to? (Just write the noun with no connectors)");
			Console.Write('\n');
			//Reads answer to "party"
			string party = Console.ReadLine();
			Console.Write('\n');
			//Prints part 1 of the letter
			Console.Write("Here is your letter so far:");
			Console.Write('\n');
			Console.Write("Dear " + reciever + "," + '\n' + '\n' + "Thank you so much for coming to my " + party + ". Thank you so much for the " + gift + ".");
			Console.Write('\n');
			Console.Write('\n');
			//Asks the user if they like the letter so far
			Console.Write("Do you like it so far? Type in \"yes\" or \"no\". \nTyping in \"no\" will restart this part of the creation process, and typing in \"yes\" will move you on to the next part of the creation process. \n");
			string continue1 = Console.ReadLine();
			Console.Write('\n');
			//checks the user's response
			switch (continue1)
			{
				case "yes":
					//stops the restart loop
					done = true;
					break;
				case "no":
					//leaves the restart loop on
					done = false;
					//clears the console and adds 1 to the restart cunter
					Console.Clear();
					attempts++;
					Console.Write("You have redone this section 1 time.");
					Console.Write('\n');
					Console.Write('\n');
					break;
			//restarts the program
			}
		}
	}
}
