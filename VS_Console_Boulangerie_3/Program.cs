/*1.Déclarer la vente de baguettes
    1. Mentionner combien de baguettes
    999. Retour au menu principal
2. Déclarez la vente de pains
    1. Mentionner combien de pains
    999. Retour au menu principal
3. Produire des baguettes
    1. Mentionner combien de baguettes
    999. Retour au menu principal
4. Produire des pains
    1. Mentionner combien de pains
    999. Retour au menu principal
3. Afficher le montant total de la caisse
4. Quitter le programme

Au sein de la classe Bakery, tu créeras les méthodes suivantes:
1.SellBaguette()
2.SellBread()
3.GetCashRegisterAmount()!

L'objet Bakery contiendra un objet BakeryStock (que tu créeras).

Au sein de la classe BakeryStock, tu créeras les méthodes suivantes:
1.AddBaguette()
2.RemoveBaguette()
3.AddBread()
4.RemoveBread()

Crée toi les classes d'exceptions suivantes  pour les erreurs de stock:
- BaguetteOutOfStockException
- BreadOutOfStockException
*/

/*
using System;

namespace VS_Console_Boulangerie_Niv2
{
    public class Bakery
    {
        public float CashRegisterAmount { get; set; } = 0;
        public void SellBaguette()
        {
            Console.WriteLine("Vente d'une baguette enregistrée\n\n");
            CashRegisterAmount += 1.1F;
        }

        public void SellBread()
        {
            Console.WriteLine("Vente d'un pain enregistrée\n\n");
            CashRegisterAmount += 2.6F;
        }

        public float GetCashRegisterAmount()
        {
            return CashRegisterAmount;
        }
    }
}
*/



namespace VS_Console_Boulangerie_Niv3
{
    public class Program
    {
        static void Main(string[] args)
        {

            //initialisation variables pour le total des ventes et le choix de l'utilisateur
            string userPick;

            Bakery bakery = new Bakery();
            Console.WriteLine("Bonjour,\nBienvenue dans l'application Backery mgmt app!");

            //démarrage de la boucle
            do
            {
                Console.WriteLine("Veuillez tapez le numéro de votre choix:\n1) vente: baguette\n2) vente: pain\n3)consulter le produit des ventes\n4) exit");
                userPick = Console.ReadLine();

                //
                switch (userPick)
                {
                    case "1":
                        bakery.SellBaguette();
                        //debug purposes

                        Console.WriteLine($"{bakery.GetCashRegisterAmount()}");
                        break;

                    case "2":
                        bakery.SellBread();
                        //debug
                        Console.WriteLine($"{bakery.GetCashRegisterAmount()}");
                        break;

                    case "3":
                        Console.WriteLine($"Le total actuel des ventes s'élève à {Math.Round(bakery.GetCashRegisterAmount(), 2)} €\n\n");
                        break;

                    default:
                        break;
                }
            } while (userPick != "4");

            Console.WriteLine(@"Merci d'avoir utilisé BakeryMgmtApp
Nous vous souhaitons une excellente journée!");

            //ajout d'un readLine pour laisser le temps de lecture avant exit
            Console.ReadLine();
        }
    }
}