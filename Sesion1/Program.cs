Console.WriteLine("Ingrese su nombre:");
string name = Console.ReadLine();
Console.WriteLine("Buenos días " + name);

string time = DateTime.Now.ToString("h:mm:ss tt");
Console.WriteLine("La hora actual: " + time);