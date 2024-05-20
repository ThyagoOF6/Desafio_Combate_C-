using System;
using System.Globalization;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            var sc = new System.IO.StreamReader(Console.OpenStandardInput());

            Console.WriteLine("Digite os dados do primeiro campeão: ");

            Console.Write("Nome: ");
            string name = sc.ReadLine();

            Console.Write("Vida inicial: ");
            int life = int.Parse(sc.ReadLine());

            Console.Write("Ataque: ");
            int attack = int.Parse(sc.ReadLine());

            Console.Write("Armadura: ");
            int armor = int.Parse(sc.ReadLine());

            Champion championA = new Champion(name, life, attack, armor);
            championA.Initialize(name, life, attack, armor);
            Console.WriteLine();

            Console.WriteLine("Digite os dados do segundo campeão: ");

            Console.Write("Nome: ");
            name = sc.ReadLine();

            Console.Write("Vida inicial: ");
            life = int.Parse(sc.ReadLine());

            Console.Write("Ataque: ");
            attack = int.Parse(sc.ReadLine());

            Console.Write("Armadura: ");
            armor = int.Parse(sc.ReadLine());

            Champion championB = new Champion(name, life, attack, armor);
            championB.Initialize(name, life, attack, armor);

            Console.WriteLine();
            Console.Write("Quantos turnos você deseja executar? ");
            int shifts = int.Parse(sc.ReadLine());

            for (int i = 1; i <= shifts; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Resultado do turno " + i + ":");

                championA.TakeDamage(championB);
                Console.WriteLine(championA.Status());

                championB.TakeDamage(championA);
                Console.WriteLine(championB.Status());

                if (championA.Life == 0 || championB.Life == 0)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("FIM DE COMBATE");
        }
    }
}