namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti nomi vorresti inserire????");
            int nNames = int.Parse(Console.ReadLine());
            string[] names = new string[nNames];
            for (int i = 0; i < nNames; i++)
            {
                Console.WriteLine($"Inserisci nome{i}:");
                string nome = Console.ReadLine();
                names[i] = nome;
            }
            Console.WriteLine($"Inserisci nome da ricercare");
            string searchQuery = Console.ReadLine();
            foreach (var name in names)
            {
                if (searchQuery == name)
                {
                    Console.WriteLine("Il nome è presente");
                }
            }

            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            int[] values = new int[n];
            int tot = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserisci il valore{i}:");
                int value = int.Parse(Console.ReadLine());
                values[i] = value;
            }

            foreach (var value in values)
            {
                tot = tot + value;
            }

            int media = tot / n;

            Console.WriteLine($"Il totale degli elementi è: {tot}");
            Console.WriteLine($"La media degli elementi è: {media}");

        }
    }
}
