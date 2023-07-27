namespace VS_Console_Boulangerie_Niv3;

public class Bakery
{
	private float _cashRegisterAmount = 0F;
    BakeryStock stock = new();


    public void SellBaguette(int qty)
    {
        if (qty <= stock.GetBaguettesCount())
        {
            Console.WriteLine("Vente de baguette enregistrée\n\n");
            _cashRegisterAmount += qty * 1.1F;
            stock.RemoveBaguette(qty);
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
}

