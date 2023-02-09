using System;
using System.Xml.Linq;

namespace TypesRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Égalité de valeur
            //comparaison de deux instances différentes du même type de record
            var personne1 = new Personne("Said", "WAHID");
            var personne2 = new Personne("Said", "WAHID");

            var areEqual = personne1.Equals(personne2);

            //Création de deux types différents d'un record
            Animal animal = new Animal("lolo", 7);
            Chat chat = new Chat(7, "lolo");
            var areEqualAnimal = animal.Equals(chat);
            //Dans ce cas, l'instruction areEqual renverra false car Animal et Chat
            //ne sont pas du même type de record.


            //Mutation non-destructive
            //, les types record immuables ne permettent aucune modification une fois qu'ils sont initialisés.
            //Prenons l'exemple d'un type record immuable avec des setters init uniquement :
            //Déclaration d'un type record immuable avec des setters init uniquement
            Client clientA = new Client() { FirstName = "oumdin" };
            var clientB = clientA;
            //clientB.FirstName = "Oumdin";

            //L'extrait de code ci-dessus ne sera pas exécuté car toutes ses propriétés ont
            //des paramètres d'initialisation uniquement :
            //les valeurs de propriété de newPet ne peuvent pas être modifiées après
            //l'initialisation de la variable.
            //Par conséquent, les valeurs de propriété pour newPet ne sont pas définies.


            //Mutation non destructive utilisant with
            Personne personneC = new Personne("Said", "WAHID");
            var personneB = personneC with { LastName = "OUMDIN" };
            Console.WriteLine(personneB.ToString());



        }
    }

    /// <summary>
    /// Propriété mutable
    /// Exemple 1 : Déclaration avec paramètres positionnels
    /// Les records sont principalement destinés à être utilisés avec des modèles de données immuables, 
    /// mais ils ne sont pas nécessairement immuables.
    /// </summary>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    public record Personne(string FirstName, string LastName);

    /// <summary>
    /// Setters d'initialisation uniquement
    /// Ou
    /// Getters 
    /// </summary>
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

    public record Animal(string Name, int Age);
    public record Chat(int Age, string Name) : Animal(Name, Age);

}
