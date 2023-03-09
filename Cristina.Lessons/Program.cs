using System;
using static LeClassi.Program;

namespace LeClassi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(
                "Bruno",
                "Ferreira",
                27,
                92,
                29,
                false,
                4,
                false,
                true,
                900000M
                );

            person1.getValues();

            //interpolazione

        }


        internal class Person
        {
            static int counter = 0;
            string _name;
            string _surname;
            int _age;
            bool _isAdult;
            decimal _bonus;
            decimal _pilComune;
            int _maturita;
            int _universita;
            bool _fedinaPenale;
            int _figli;
            bool _militare;
            bool _debiti;
            int _punteggio;
            const int indeceBonus = 35;

            public string Name { get { return _name; } }
            public string Surname { get { return _surname; } }
            public string FullName { get { return _name + " " + _surname; } }
            public bool IsAdult { get { return _isAdult; } }


            public Person(

                string Name,
                string Surname,
                int Age,
                int Maturita,
                int Universita,
                bool FedinaPenale,
                int Figli,
                bool Militare,
                bool Debiti,
                decimal PilComune
                ) // firma del costruttore
            {
                _name = Name;
                _surname = Surname;


                // variabili per il BONUS 
                _age = Age;
                _maturita = Maturita;
                _universita = Universita;
                _fedinaPenale = FedinaPenale;
                _figli = Figli;
                _militare = Militare;
                _debiti = Debiti;
                _pilComune = PilComune;


                counter++;
                setIsAdult();
                CalcolaBonus();
            }
            public void getValues()
            {
                //Console.WriteLine(
                //$"Nome:{_name}\n " +
                //$"Cognome:{_surname}\n" +
                //$"Age:{_age}" +
                //$"Maturita:{_maturita}" +
                //$"FedinaPenale:{_fedinaPenale}" +
                //$"Debiti: {_debiti}"
                //);
                Console.WriteLine($"Nome:{_name}");
                Console.WriteLine($"Cognome:{_surname}");
                Console.WriteLine($"Age:{_age}");
                Console.WriteLine($"Maturita:{_maturita}");
                Console.WriteLine($"Universita:{_universita}");
                Console.WriteLine($"FedinaPenale:{_fedinaPenale}");
                Console.WriteLine($"Figli:{_figli}");
                Console.WriteLine($"Militare:{_militare}");
                Console.WriteLine($"Debiti:{_debiti}");
                Console.WriteLine($"PilComune:{_pilComune}");
                Console.WriteLine($"Punteggio:{_punteggio}");
                Console.WriteLine($"Bonus:{_bonus}");
            }
            public int getCounter()
            {
                return counter;
            }

            private void setIsAdult()
            {
                if (_age > 18)
                {
                    _isAdult = true;
                }
                else
                {
                    _isAdult = false;
                }
            }

            private void CalcolaBonus()
            {


                /*
                   Calcolo per il bonus cittadino
                */


                if (_age >= 18 && _age <= 28)
                {
                    _punteggio += 7;
                }
                if (_maturita >= 90)
                {
                    _punteggio += 7;
                }
                if (_universita >= 28)
                {
                    _punteggio += 6;
                }
                if (_fedinaPenale == false)
                {
                    _punteggio += 6;
                }
                //se i figli sono 2 o più entra nell'if
                if (_figli >= 2)
                {
                    //somma 4 punti per ogni figlio 
                    for (int i = 0; i < _figli; i++)
                    {
                        _punteggio += 4;
                    }
                }
                if (_militare == true)
                {
                    _punteggio += 5;
                }
                if (_debiti == false)
                {
                    _punteggio += 6;
                }
                if (_pilComune <= 1000000M)
                {
                    _punteggio += 8;
                }

                if (_punteggio >= indeceBonus && _isAdult)
                {
                    _bonus = 10000M;

                }
                else
                {
                    _bonus = 0;
                }

            }


        }

    }
}
