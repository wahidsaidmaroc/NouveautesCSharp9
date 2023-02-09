using System;

namespace TypesRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public record Personne(string FirstName, string LastName);

    public record Client
    {
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
    };

    public record Fournisseur
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    };


}
