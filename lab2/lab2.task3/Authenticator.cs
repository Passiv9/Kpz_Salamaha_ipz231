using System;

public class Authenticator
{
    private static readonly object _lock = new object();
    private static Authenticator _instance;

    protected Authenticator()
    {
        Console.WriteLine("Authenticator created.");
    }

    public static Authenticator Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
    }

    public void Authenticate()
    {
        Console.WriteLine("User authenticated.");
    }
}
