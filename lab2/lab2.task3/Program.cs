using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Authenticator singleton in multi-threaded environment:\n");

        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(() =>
            {
                Authenticator auth = Authenticator.Instance;
                auth.Authenticate();
            });
            t.Start();
        }

     
    }
}
