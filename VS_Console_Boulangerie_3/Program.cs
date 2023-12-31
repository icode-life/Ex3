﻿namespace VS_Console_Boulangerie_Niv3;

public class Program
{
    static void Main(string[] args)
    {
        //initialisation variables pour le total des ventes et le choix de l'utilisateur
        string userMenuPick;
         int requestedQty = 0;
         string? usrInput = "";
        Bakery bakery = new Bakery();

    Console.WriteLine("Bonjour,\nBienvenue dans l'application Bakery mgmt!");

        //démarrage de la boucle
        do
        {
            Console.WriteLine("Veuillez tapez le numéro de votre choix:\n1) Vente: baguette\n2) Vente: pain\n3) Production de baguettes\n4) Produire pains\n5) Consulter le produit des ventes\n6) exit");
            userMenuPick = Console.ReadLine();

            //
            switch (userMenuPick)
            {
                case "1": //baguette sale
                    Console.WriteLine("How many Baguettes would you like?");
                    usrInput = Console.ReadLine().ToLower().Trim();
                    requestedQty = int.Parse(usrInput);
                    if (requestedQty > 0 && requestedQty < 1000)
                    {
                        try
                        {
                            bakery.SellBaguette(requestedQty);
                        }
                        catch(BaguetteOutOfStockException e)
                        {
                            if (e.Message.StartsWith("il ne reste que"))
                            {
                                int dispo = int.Parse(e.Message.Substring(35));
                                Console.WriteLine($"Désolé, il ne nous reste que {dispo} baguette(s), combien en voulez-vous?");
                                int newQty = int.Parse(Console.ReadLine() ?? "0");
                                if (newQty > 1 && newQty <= dispo)
                                {
                                    bakery.SellBaguette(newQty);
                                }
                                else
                                {
                                    Environment.Exit(1);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Veuillez recommencer et sélectionner une quantité comprise entre 1 et 999 inclus");
                    }
                    break;

                case "2": // bread sale
                    Console.WriteLine("How many breads would you like?");
                    usrInput = Console.ReadLine().ToLower().Trim();
                    requestedQty = int.Parse(usrInput);
                    if (requestedQty > 0 && requestedQty < 1000)
                    {
                        bakery.SellBread(requestedQty);
                    }
                    else
                    {
                        Console.WriteLine("Veuillez recommencer et sélectionner une quantité comprise entre 1 et 999 inclus");
                    }
                    break;

                case "3": //baguette production
                    Console.WriteLine("How many Baguettes would you like to bake and add to stock?");
                    usrInput = Console.ReadLine().ToLower().Trim();
                    requestedQty = int.Parse(usrInput);
                    if (requestedQty > 0 && requestedQty < 1000)
                    {
                       // stock.AddBaguette(requestedQty);
                       // need to reach out to bakery to handle stock
                    }
                    else
                    {
                        Console.WriteLine("Veuillez recommencer et sélectioner une quantité comprise entre 1 et 999 inclus");
                    }
                    break;

                case "4": // bread production
                    Console.WriteLine("How many breads would you like to bake and add to stock?");
                    usrInput = Console.ReadLine().ToLower().Trim();
                    requestedQty = int.Parse(usrInput);
                    if (requestedQty > 0 && requestedQty < 1000)
                    {
                        //stock.AddBread(requestedQty);
                        // need to reach out to bakery to handle stock, should avoid creating a second object stock here -> source of errors, non logical
                    }
                    else
                    {
                        Console.WriteLine("Veuillez recommencer et sélectioner une quantité comprise entre 1 et 999 inclus");
                    }
                    break;

                case "5":
                    Console.WriteLine($"Le total actuel des ventes s'élève à {Math.Round(bakery.GetCashRegisterAmount(), 2)} €\n\n");
                    break;

                default:
                    break;
            }
        } while (userMenuPick != "6");

        Console.WriteLine(@"Merci d'avoir utilisé BakeryMgmtApp
Nous vous souhaitons une excellente journée!");

        //ajout d'un readLine pour laisser le temps de lecture avant exit
        Console.ReadLine();
   }
}