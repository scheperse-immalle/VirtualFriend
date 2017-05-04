using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirualFriend
{


    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime voor = DateTime.Now;

            Console.WriteLine("Computer zegt : Wat is jou naam? ");
            Console.Write("Jij zegt : ");
            string naam = Console.ReadLine();

            DateTime na = DateTime.Now;
            TimeSpan verschil = na - voor;

            Console.WriteLine("Computer zegt : Dag {0}. Je hebt er {1} seconden over gedaan om je naam van {2} karakters in te typen!",
                naam,
                verschil.TotalSeconds,
                naam.Length);

            double timePerCharacter = verschil.TotalSeconds / naam.Length;

            if (timePerCharacter > 0.50 && naam.Length < 10)
            {
                Console.WriteLine("Computer zegt : Jij bent wel een trage typer!");
            }
            if (timePerCharacter > 0.70 && naam.Length > 10)
            {
                Console.WriteLine("Computer zegt : Jij bent wel een trage typer!");
            }
            Console.WriteLine("Computer zegt : Wat is uw leeftijd? Geef enkel het getal.");
            Console.Write("{0} zegt : ", naam);
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            if (leeftijd < 18)
            {
                Console.WriteLine("Computer zegt : U bent {0} jaar en bent dus nog niet volwasse.", leeftijd);

            }
            else
            {
                Console.WriteLine("Computer zegt : U bent {0} jaar en bent dus volwasse.", leeftijd);
            }
            Console.WriteLine("Computer zegt : Wilt u praten met een virtuele vriend? ");
            Console.Write("{0} zegt : ", naam);
            string antwoord = Console.ReadLine();
            if (antwoord.ToLower().Contains("nee"))
            {
                Console.WriteLine("Computer zegt : Jammer, miesschien volgende keer, tot ziens {0}!", naam);
            }
            else
            {
                Console.WriteLine("Computer zegt : Leuk, laten we beginnen.");
                Console.WriteLine("Comuter zegt : Wilt u graag praten met een man of vrouw? ");
                Console.Write("{0} zegt : ", naam);
                string geslacht = Console.ReadLine();
                if (geslacht.ToLower().Contains("man"))
                {
                    Console.WriteLine("Computer zegt : U hebt gekozen voor een man, Wilt u praten met een volwasse man of een Tiener?");
                    Console.Write("{0} zegt : ", naam);
                    string leeftijdMan = Console.ReadLine();
                    if (leeftijdMan.ToLower().Contains("volwassene") || leeftijdMan.ToLower().Contains("volwasse"))
                    {
                        Console.WriteLine("Eric zegt : Hallo ik ben Eric en ik ben 30 jaar, Gaat alles goed {0}? ", naam);
                        Console.Write("{0} zegt : ", naam);
                        string gevoel = Console.ReadLine();
                        if (gevoel.ToLower().Contains("ja"))
                        {
                            Console.Write("Eric zegt : Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? "); Console.Write("{0} zegt : ", naam);
                            Console.Write("{0} zegt : ", naam);
                            string hobby0 = Console.ReadLine();
                            if (hobby0 == hobby0)
                            {
                                Console.WriteLine("Eric zegt : Wauw! {0}! Je bent echt een intressant persoon {1}! Heeft u een relatie?", hobby0, naam);
                                string yorn = Console.ReadLine();
                                if (yorn.ToLower().Contains("ja"))
                                {
                                    Console.Write("Eric zegt : Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                    Console.Write("{0} zegt : ", naam);
                                    string vriend = Console.ReadLine();
                                    if (vriend.ToLower().Contains("ja"))
                                    {
                                        Console.WriteLine("Eric zegt : Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                    }
                                }



                                if (yorn.ToLower().Contains("nee"))
                                {
                                    Console.WriteLine("Eric zegt : heb ik even geluk! Ik vindt je echt zo leuk! hoe kan iemand als jij nu geen relatie hebben. Ik zou het wel weten ;) Of ben ik je type niet?");
                                    Console.Write("{0} zegt : ", naam);
                                    string type = Console.ReadLine();
                                    if (type.ToLower().Contains("nee"))
                                    {
                                        Console.WriteLine("Eric zegt : Pff, je hoeft niet zo onbeleefd te zijn hoor! Nog een fijne dag, i guess.. ");
                                    }
                                }
                            }
                        }


                        else
                        {
                            Console.Write("Eric zegt : Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ", naam);
                            Console.Write("{0} zegt : ", naam);
                            string hobby1 = Console.ReadLine();
                            if (hobby1 == hobby1)
                            {
                                Console.WriteLine("Eric zegt : Wauw! Je bent echt een intressant persoon {0}! Ik moet wel terug beginnen werken. Ik ben namelijk baas van Apple, hopelijk hoor ik je nog eens!", naam);
                            }
                        }
                    }
                    if (leeftijdMan.ToLower().Contains("(tiener"))
                    {
                        Console.Write("Jonas zegt : Hallo ik ben Jonas en ik ben 17 jaar, Gaat alles goed {0}? ", naam);
                        Console.Write("{0} zegt : ", naam);
                        string gevoel = Console.ReadLine();
                        if (gevoel.ToLower().Contains("ja"))
                        {
                            Console.Write("Jonas zegt : Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                            Console.Write("{0} zegt : ", naam);
                            string hobby2 = Console.ReadLine();
                            if (hobby2 == hobby2)
                            {
                                Console.WriteLine("Jonas zegt : Wauw!{1} Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam, hobby2);
                                Console.Write("{0} zegt : ", naam);
                                string yorn = Console.ReadLine();
                                if (yorn.ToLower().Contains("ja"))
                                {
                                    Console.Write("Jonas zegt : Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                    Console.Write("{0} zegt : ", naam);
                                    string vriend = Console.ReadLine();
                                    if (vriend.ToLower().Contains("ja"))
                                    {
                                        Console.WriteLine("Jonas zegt : Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                    }
                                }
                            }
                            else
                            {
                                Console.Write("Jonas zegt : Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ", naam);
                                Console.Write("{0} zegt : ", naam);
                                string hobby3 = Console.ReadLine();
                                if (hobby3 == hobby3)
                                {
                                    Console.WriteLine("Jonas zegt : Wauw! {1}! Je bent echt een intressant persoon {0}! Ik moet wel door, hopelijk hoor ik je nog eens!", naam, hobby3);
                                }
                            }
                        }
                    }
                }

                if (geslacht.ToLower().Contains("vrouw"))
                {
                    Console.WriteLine("Computer zegt : U hebt gekozen voor een vrouw, Wilt u praten met een volwasse vrouw of een Tiener?");
                    Console.Write("{0} zegt : ", naam);
                    string leeftijdVrouw = Console.ReadLine();
                    if (leeftijdVrouw.ToLower().Contains("volwasse"))
                    {
                        Console.Write("Sarah zegt : Hallo ik ben Sarah en ik ben 24 jaar, Gaat alles goed {0}? ", naam);
                        Console.Write("{0} zegt : ", naam);
                        string gevoelV = Console.ReadLine();
                        if (gevoelV.ToLower().Contains("ja"))
                        {
                            Console.Write("Sarah zegt : Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                            Console.Write("{0} zegt : ", naam);
                            string hobby4 = Console.ReadLine();
                            if (hobby4 == hobby4)
                            {
                                Console.WriteLine("Sarah zegt : Wauw! {1}! Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam, hobby4);
                                Console.Write("{0} zegt : ", naam);
                                string yorn = Console.ReadLine();
                                if (yorn.ToLower().Contains("ja"))
                                {
                                    Console.Write("Sarah zegt : Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                    Console.Write("{0} zegt : ", naam);
                                    string vriend = Console.ReadLine();
                                    if (vriend.ToLower().Contains("ja"))
                                    {
                                        Console.WriteLine("Sarah zegt : Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                    }
                                }
                            }
                            else
                            {
                                Console.Write("Sarah zegt : Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's?", naam);
                                Console.Write("{0} zegt : ", naam);
                                string hobby5 = Console.ReadLine();
                                if (hobby5 == hobby5)
                                {
                                    Console.WriteLine("Sarah zegt : Wauw! {1}! Je bent echt een intressant persoon {0}! Ik moet wel door, ik ga mijn haar laten kleuren bij de kapper. Hopelijk hoor ik je nog eens! ;)", naam, hobby5);
                                }
                            }

                        }
                    }
                        if (leeftijdVrouw.ToLower().Contains("tiener"))
                        {
                            Console.WriteLine("Elise zegt : Hallo ik ben Elise en ik ben 16 jaar, Gaat alles goed {0}? ", naam);
                            Console.Write("{0} zegt : ", naam);
                            string gevoel = Console.ReadLine();
                        if (gevoel.ToLower().Contains("ja"))
                        {
                            Console.WriteLine("Elise zegt : Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                            Console.Write("{0} zegt : ", naam);
                            string hobby6 = Console.ReadLine();
                            if (hobby6 == hobby6)
                            {
                                Console.WriteLine("Elise zegt : Wauw! {1} Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam, hobby6);
                                Console.Write("{0} zegt : ", naam);
                                string yorn = Console.ReadLine();
                                if (yorn.ToLower().Contains("ja"))
                                {
                                    Console.Write("Elise zegt : Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                    Console.Write("{0} zegt : ", naam);
                                    string vriend = Console.ReadLine();
                                    if (vriend.ToLower().Contains("ja"))
                                    {
                                        Console.WriteLine("Elise zegt : Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.Write("Elise zegt : Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ", naam);
                            Console.Write("{0} zegt : ", naam);
                            string hobby7 = Console.ReadLine();
                            if (hobby7 == hobby7)
                            {
                                Console.WriteLine("Elise zegt : Wauw! {1}! Je bent echt een intressant persoon {0}! Ik moet wel door, ik ga shoppen met een vriendin. Hopelijk hoor ik je nog eens!", naam, hobby7);
                            }
                        }
                                }
                            }


                        }
                    }
                }
            }
        
    

            
        

    






