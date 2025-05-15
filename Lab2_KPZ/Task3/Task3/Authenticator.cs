using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance = new(() => new Authenticator());

        public static Authenticator Instance => _instance.Value;

        public string Token { get; private set; }

        private Authenticator()
        {
            Token = Guid.NewGuid().ToString();
            Console.WriteLine("Authenticator created with token: " + Token);
        }

        public void Authenticate(string user)
        {
            Console.WriteLine($"{user} authenticated with token: {Token}");
        }
    }
}