// Alexander och Jesper.
internal class Program
{

    private static void Main(string[] args)
    {
        while (true)
        {
            int chooseEnvoirement;
            int choice;
            Console.Clear();
            Console.WriteLine("Hej och välkommen");
            Console.WriteLine("Tryck på Visning 1 om du vill titta på dinosaurier");
            Console.WriteLine("Tryck på Visning 2 om du vill titta på fossiler");
            Console.WriteLine("Tryck på Visning 3 om du vill gå på kafé");
            Console.WriteLine("Tryck på visning 5 för att gå hem");
            ConsoleKeyInfo userInput = Console.ReadKey();
            choice = int.Parse(userInput.KeyChar.ToString());
            



            switch (choice)
            {
                case 1:
                    Console.Clear();
                    GoToShowroom();
                    break;
                case 2:
                    Console.Clear();
                    GoToFossils();
                    break;
                case 3:
                    Console.Clear();
                    GoToCafé();
                    break;
                case 4:
                    Console.Clear();
                    GoToGiftShop();
                    break;    
                case 5:
                    Console.Clear();
                    GoToExit();
                    break;



                default:
                    break;
            }

            void GoToShowroom()
            {
                Console.WriteLine("Vill du titta på statyn eller videon?");
                Console.Write("Välj 1 för staty, 2 för video eller 3 för att gå till fossilrummet ");
                int chooseEnvoirement;
                var userInput = Console.ReadKey(); 
                chooseEnvoirement = int.Parse(userInput.KeyChar.ToString());

                if (chooseEnvoirement == 3)
                {
                GoToFossils();
                }
            }

            void GoToFossils()
            {
                Console.WriteLine("Vill du kolla på fossiler eller vill du lyssna på ljud?");
                Console.Write("Välj 1 för fossiler, välj 2 för video"); 
                int chooseEnvoirement;
                chooseEnvoirement = Convert.ToInt32(Console.ReadLine());


             }
             void GoToCafé()
             {
                Console.WriteLine("Vill du dricka kaffe och äta en bulle? Gå på toa? Eller gå till Gift Shop?");
                Console.Write("Välj 1 för kaffe och bulle, välj 2 för att gå på toa, välj 3 för att gå till the gift shop"); 
                int chooseEnvoirement;
                chooseEnvoirement = Convert.ToInt32(Console.ReadLine());
                if (chooseEnvoirement == 1 )
                {
                    Console.WriteLine("Du äter din bulle och halsar ditt kaffe din lilla gottegris"); 
                    GoToCafé();
                
                } else if (chooseEnvoirement == 2)
                {
                    GoToBathroom();
                
                }else if (chooseEnvoirement == 3)       
                { 
                    GoToGiftShop();   
                }
             }

            void GoToBathroom()
            {
                Console.WriteLine("Du har gjort klart din business. Vill du gå till kaffét eller gift shop");
                Console.Write("Välj 1 för kaffét, välj 2 för att gå till the gift shop"); 
                int chooseEnvoirement;
                chooseEnvoirement = Convert.ToInt32(Console.ReadLine());
                if (chooseEnvoirement == 1)
                {
                    GoToCafé();
                } 
                else if (chooseEnvoirement == 2)
                {
                    GoToGiftShop();
                }
                
            }

            void GoToGiftShop()
            {
                Console.WriteLine("Här kan du köpa Nyckelring, Leksak, Studsboll");
                Console.Write("Välj 1 för Nyckelring, välj 2 leksak eller välj 3 för studsboll"); 
                int chooseEnvoirement;
                chooseEnvoirement = Convert.ToInt32(Console.ReadLine());  

            } 

            void GoToExit ()
            {
                Console.WriteLine("Du har kommit till utgången");
                Console.Write("1.Vill du gå hem, 2 stanna kvar?"); 
                int chooseEnvoirement;
                chooseEnvoirement = Convert.ToInt32(Console.ReadLine());

                if (chooseEnvoirement == 1)
                {
                Environment.Exit(0);
                }
               

            }

        }

    }



}