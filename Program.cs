using System;

public class Program
{
	public static void Main()
	{
		//Prints version and title into console
		Console.Write("Thank-you note bot");
		Console.Write('\n');
		Console.Write("Version 0.1.2");
		Console.Write('\n');
		//sets up restart counter
		int attempts = 0;
        int attempts1 = 0;
		bool done = false;
		//Sets up restart loop
		string reciever = "placeholder";
		string gift = "placeholder";
		string party = "placeholder";
		string title = "placeholder";
        string recognize = "placeholder";
        string article = "placeholder";
        string sender = "placeholder";
        string address = "placeholder";
		while (!done)
		{
			//sets up restart counter (attempts)
			if (attempts > 1)
			{
				Console.Write("You have redone this section " + attempts + " times.");
				Console.Write('\n');
			}
			if (attempts == 1)
			{
				Console.Write("You have redone this section " + attempts + " time.");
				Console.Write('\n');
			}

			//Asks who the letter is directed to
			Console.Write('\n');
			Console.Write("Who are you writing to?");
			Console.Write('\n');
			//Reads answer to varible "reciever"
			reciever = Console.ReadLine();
			Console.Write('\n');
			//Asks what gift was recieved
			Console.Write("What gift did you get from " + reciever + "?");
			Console.Write('\n');
			//Reads answer to varible "gift"
			gift = Console.ReadLine();
			Console.Write('\n');
			//Asks what type party the person went to
			Console.Write("What party did you invite " + reciever + " to? (Just write the noun with no connectors)");
			Console.Write('\n');
			//Reads answer to "party"
			party = Console.ReadLine();
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
					Console.Write('\n');
					Console.Write('\n');
					break;
			//restarts the program
			}
		}
        //Tells the user that they are in Section 2
		Console.Write("Section 2 \n\n");
		bool done1 = false;
		while (!done1)
		{
            if (attempts1 > 1)
			{
				Console.Write("You have redone this section " + attempts1 + " times.");
				Console.Write('\n');
			}
			if (attempts1 == 1)
			{
				Console.Write("You have redone this section " + attempts1 + " time.");
				Console.Write('\n');
			}
			Console.Write("What do you recognize " + reciever + " as? (e.g: \"aunt\", \"friend\", \"grandfather\") \n");
			title = Console.ReadLine();
            Console.Write('\n');
            Console.Write('\n');
            Console.Write("How do you describe " + reciever + " as? (Context: 'answer' " + title + ")\n");
            recognize = Console.ReadLine();
            Console.Write('\n');
            Console.Write('\n');
            Console.Write("What article do you want to use? (Context: You are 'answer' " + recognize + " " + title + ".)\n");
            article = Console.ReadLine();
            Console.Write('\n');
            Console.Write('\n');
            Console.Write("How would you like to address " + reciever + "? (e.g: Love, From, Regards)\n");
            address = Console.ReadLine();
            Console.Write('\n');
            Console.Write('\n');
            Console.Write("What is your name?\n");
            sender = Console.ReadLine();
            Console.Write('\n');
            Console.Write('\n');
			Console.Write("Here is your letter so far:");
			Console.Write('\n');
			Console.Write("Dear " + reciever + "," + '\n' + '\n' + "Thank you so much for coming to my " + party + ". Thank you so much for the " + gift + ". You are " + article + " " + recognize + " " + title + ".\n\n" + address + ", " + sender + ".");
			Console.Write('\n');
			Console.Write('\n');
            Console.Write("Do you like it so far? Type in \"yes\" or \"no\". \nTyping in \"no\" will restart this part of the creation process, and typing in \"yes\" will move you on to the next part of the creation process. \n");
			string continue2 = Console.ReadLine();
			Console.Write('\n');
			//checks the user's response
			switch (continue2)
			{
				case "yes":
					//stops the restart loop
					done1 = true;
					break;
				case "no":
					//leaves the restart loop on
					done1 = false;
					//clears the console and adds 1 to the restart cunter
					Console.Clear();
					attempts1++;
					Console.Write('\n');
					Console.Write('\n');
					break;
			//restarts the program
			}
		}
	}
}