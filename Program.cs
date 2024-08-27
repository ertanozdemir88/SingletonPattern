using SingletonPattern;

Logger logger1 = Logger.Instance;
logger1.Log("First log message.");

// Retrieve the same instance of Logger
Logger logger2 = Logger.Instance;
logger2.Log("Second log message.");

// Demonstrate that both instances are the same
bool sameInstance = ReferenceEquals(logger1, logger2);
Console.WriteLine($"Are both instances the same? {sameInstance}");

Console.ReadLine();