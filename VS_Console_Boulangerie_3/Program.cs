namespace VS_Console_Boulangerie_Niv3;

public class Program
{
    static void Main(string[] args)
    {
        //initialisation variables pour le total des ventes et le choix de l'utilisateur
        string userMenuPick;
         int requestedQty = 0;
         string usrInput = "";
        Bakery bakery = new Bakery();

    Console.WriteLine("Bonjour,\nBienvenue dans l'application Backery mgmt app!");

        //démarrage de la boucle
        do
        {
            Console.WriteLine("Veuillez tapez le numéro de votre choix:\n1) vente: baguette\n2) vente: pain\n3)consulter le produit des ventes\n4) exit");
            userMenuPick = Console.ReadLine();

            //
            switch (userMenuPick)
            {
                case "1":
                    Console.WriteLine("How many Baguettes would you like?");
                    usrInput = Console.ReadLine();
				    usrInput.Trim().ToLower();
                    requestedQty = int.Parse(usrInput);
                    bakery.SellBaguette(requestedQty);
                    break;

                case "2":
                    Console.WriteLine("How many breads would you like?");
                    usrInput = Console.ReadLine();
                    usrInput.Trim().ToLower();
                    requestedQty = int.Parse(usrInput);
                    bakery.SellBread(requestedQty);
                    break;

                case "3":
                    Console.WriteLine($"Le total actuel des ventes s'élève à {Math.Round(bakery.GetCashRegisterAmount(), 2)} €\n\n");
                    break;

                default:
                    break;
            }
        } while (userMenuPick != "4");

        Console.WriteLine(@"Merci d'avoir utilisé BakeryMgmtApp
Nous vous souhaitons une excellente journée!");

        //ajout d'un readLine pour laisser le temps de lecture avant exit
        Console.ReadLine();
   }
}