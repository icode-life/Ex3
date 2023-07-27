namespace VS_Console_Boulangerie_Niv3;

public class Bakery
{
	private float _cashRegisterAmount = 0F;
    BakeryStock stock = new();


    public void SellBaguette(int qty)
    {
        Console.WriteLine("Vente d'une baguette enregistrée\n\n");
        _cashRegisterAmount += qty*1.1F;
        stock.RemoveBaguette(qty);
    }

    public void SellBread(int qty)
    {
        Console.WriteLine("Vente d'un pain enregistrée\n\n");
        _cashRegisterAmount += qty*2.6F;
        stock.RemoveBread(qty);
    }

    public float GetCashRegisterAmount()
    {
        return _cashRegisterAmount;
    }
}

