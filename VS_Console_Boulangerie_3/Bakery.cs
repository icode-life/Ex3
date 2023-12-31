﻿namespace VS_Console_Boulangerie_Niv3;

public class Bakery
{
	private float _cashRegisterAmount = 0F;
    BakeryStock stock = new();


    public void SellBaguette(int qty)
    {
        if (qty <= stock.GetBaguettesCount())
        {
            try
            {
                stock.RemoveBaguette(qty);
                Console.WriteLine("Vente de baguette enregistrée\n\n");
                _cashRegisterAmount += qty * 1.1F;
            }
            catch (BaguetteOutOfStockException e)
            {
                if (e.Message.StartsWith("il ne reste que"))
                {
                    //int baguettesRestantes = 
                    throw new Exception($"nombre de baguette(s) restante(s): {stock.GetBaguettesCount()}");
                }
                else
                {
                    if(e.Message.StartsWith("stock"))
                    {
                        stock.AddBaguette(50);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"Désolé, il ne nous reste que {stock.GetBaguettesCount()} baguette(s)");
        }
    }

    public void SellBread(int qty)
    {
        if (qty <= stock.GetBreadsCount())
        {
            Console.WriteLine("Vente de pain enregistrée\n\n");
            _cashRegisterAmount += qty * 2.6F;
            stock.RemoveBread(qty);
        }
        else
        {
            Console.WriteLine($"Désolé, il ne nous reste que {stock.GetBreadsCount()} pain(s)");

        }
    }

    public float GetCashRegisterAmount()
    {
        return _cashRegisterAmount;
    }

    public int GetBaguetteStock()
    {
        return stock.GetBaguettesCount();
    }

    public int GetBreadStock()
    {
        return stock.GetBreadsCount();
    }
}

