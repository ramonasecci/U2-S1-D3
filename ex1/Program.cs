using System.Reflection.Metadata.Ecma335;

namespace Esercizio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto su EpiBank");
            Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine(); 
            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine(); 
            Console.WriteLine("Inserisci l'importo iniziale");
            int versamento1 = int.Parse(Console.ReadLine());
            bool end =false; 
            if(versamento1<1000)
            {
                end = true;
                Console.WriteLine("Sborsa di più!");                
            }
            BankAccount userBank1 = new BankAccount(nome,cognome,versamento1);
            while (!end)
            {
                //Costrutto switch
                Console.WriteLine("Per poter prelevare digita 1");
                Console.WriteLine("Per poter verificare il tuo saldo disponibile digita 2");
                Console.WriteLine("Per poter effetuare un versamento digita 3");
                Console.WriteLine("Se hai terminato digita 4");

                Console.Write("Scegli l'opzione: ");
                string option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":
                        userBank1.Prelievo();
                        Console.WriteLine("Hai terminato ? Rispondi si/no");
                        string resp = Console.ReadLine();
                        if(resp == "si"){
                            end = true;
                        }

                        break;

                    case "2":
                        Console.WriteLine("Il saldo disponibile è: "+userBank1.Saldo+"€");
                        Console.WriteLine("Hai terminato ? Rispondi si/no");
                        resp = Console.ReadLine();
                        if(resp == "si"){
                            end = true;
                        }
                        break;


                    case "3":
                        userBank1.Versamento();
                        Console.WriteLine("Hai terminato ? Rispondi si/no");
                        resp = Console.ReadLine();
                        if(resp == "si"){
                            end = true;
                        }
                        break;

                    case "4": 
                        end=true; //anche in questo modo il ciclo si interrompe 
                        break;
                    

                    default:
                        Console.WriteLine("Non ci sono altre operazioni disponibili");
                        break;
                }

            }
            

        }


    }

    class BankAccount
    {
        string _name;
        string _surname;
        int _idConto;
        int _saldo;

        public string Name
        {
            get{return _name;}
            set{_name=value;}
        }

        public string Surname
        {
            get{return _surname;}
            set {_surname=value;}
        }

        public int IdConto
        {
            get{return _idConto;}
            set{
                Random random = new Random();
                _idConto= random.Next(100000, 1000000);
            }
        }

        public int Saldo
        {
            get{return _saldo;}
            set
            {
                _saldo = value;
            }

        }

        public BankAccount(string name, string surname, int saldo)
        {
            Name=name;
            Surname=surname;
            Saldo=saldo;
        }

        public void Prelievo()
        {
            Console.WriteLine($"Quanto vuoi prelevare? Il tuo saldo disponibile è {Saldo}€");
            int tot = int.Parse(Console.ReadLine());
            if(tot > Saldo)
            {
                Console.WriteLine("Fondi insufficienti");

            }else if(tot == 0)
            {
                Console.WriteLine("Inserisci un importo maggiore a 0");
            }else{
                Saldo = Saldo - tot;
                Console.WriteLine($"Hai prelevato {tot}€, il tuo saldo disponibile è:{Saldo}");
            }
        }

        public void Versamento()
        {
            Console.WriteLine($"Quanto vuoi versare? Il tuo saldo disponibile è {Saldo}€");
            int tot = int.Parse(Console.ReadLine());
            if(tot == 0)
            {
                Console.WriteLine("Importo insufficiente");
            }else{
                Saldo = Saldo + tot;
                Console.WriteLine($"Hai versato {tot}€, il tuo saldo disponibile è:{Saldo}");
            }
        }
    }

}