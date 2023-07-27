namespace VS_Console_Boulangerie_Niv3;

public class BakeryStock
{
	private int _baguetteCount = 50;
	private int _breadCount = 50;

	public int GetBaguettesCount()
	{
		return _baguetteCount;
	}

	public int GetBreadsCount()
	{
		return _breadCount;
	}

	public void AddBaguette(int productQty)
	{
        _baguetteCount += productQty;
		Console.WriteLine(_baguetteCount);
    }

    public void RemoveBaguette(int productQty)
	{
		_baguetteCount -= productQty;
	}

	public void AddBread(int productQty)
	{
        _baguetteCount += productQty;
    }

    public void RemoveBread(int productQty)
	{
		_breadCount -= productQty;
	}
}
