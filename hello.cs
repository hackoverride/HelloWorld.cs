using System;

namespace HelloWorld{
class Test {
				/* Hello World - Starwars edition */
	static void Main() {
	Console.Clear();
	Console.WriteLine("What is your name?");
	String name = Console.ReadLine();

	Console.WriteLine("Hello, " + name);

	/* Imperial March */
	Console.Beep(440,500);
	Console.Beep(440,500);
	Console.Beep(440,500);
	Console.Beep(349,350);	
	Console.Beep(523,150);
	Console.Beep(440,500);
	Console.Beep(349,350);	
	Console.Beep(523,150);
	Console.Beep(440,1000);
	Console.WriteLine("Dum dum!");
	Console.Beep(659,500);
	Console.Beep(659,500);	
	Console.Beep(659,500);
	Console.Beep(698,350);
	Console.Beep(523,150);
	Console.Beep(415,500);
	Console.Beep(349,350);	
	Console.Beep(523,150);
	Console.Beep(440,1000);
  Console.WriteLine("Press enter to exit.");
	Console.ReadLine();
	
}
}
}
