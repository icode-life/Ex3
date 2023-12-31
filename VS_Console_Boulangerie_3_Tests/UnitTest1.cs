﻿namespace VS_Console_Boulangerie_Niv3;

public class UnitTest1
{

    [Fact]
    public void TestBaseStock() //vente de baguette impossible stock insuffisant
    {
        //arrange
        BakeryStock stock = new();
        int expected = 50; // stock plein mais insuffisant


        //act
        int actual = stock.GetBaguettesCount();

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAddBaguettes() //vente de baguette impossible stock insuffisant
    {
        //arrange
        BakeryStock stock = new();
        int expected = 60; // on va ajouter 10 baguettes au stock


        //act
        stock.AddBaguette(10);
        int actual = stock.GetBaguettesCount();

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestRemoveBaguette() //vente de baguette impossible stock insuffisant
    {
        //arrange
        BakeryStock stock = new();
        int expected = 0; // stock plein mais insuffisant


        //act
        stock.RemoveBaguette(50);
        int actual = stock.GetBaguettesCount();

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
        public void TestGetCashRegisterAmount()
    {
        //arrange
        Bakery bakery = new Bakery();
        float expected = 7.8F;
        //bakery._cashRegisterAmount = 2.6F;

        //act
        bakery.SellBread(3);
        float actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual, 0.01);
    }

    [Fact]
    public void TestSellBaguette() //vente de baguette via check stock
    {
        //arrange
        Bakery bakery = new Bakery();
        int expected = 38; // vente de 12 baguettes pour stock initial de 50


        //act
        bakery.SellBaguette(12);
        int actual = bakery.GetBaguetteStock();

        //assert
        Assert.Equal(expected, actual, 0.01);
    }

   /* [Fact]
    public void TestSellBaguetteNok() //vente de baguette impossible stock insuffisant
    {
        //arrange
        Bakery bakery = new Bakery();
        string expected = "Désolé, il ne nous reste que 50 baguette(s)"; // stock plein mais insuffisant


        //act
        string actual = bakery.SellBaguette(62);

        //assert
        Assert.Equal(expected, actual);
    }*/

    [Fact]
    public void TestSellBaguetteNok2() //vente de baguette impossible stock insuffisant
    {
        //arrange
        Bakery bakery = new Bakery();
        int expected = 50; // stock plein mais insuffisant


        //act
        bakery.SellBaguette(62);
        int actual = bakery.GetBaguetteStock();

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestSellBreadFullStock() //vente de baguette impossible stock insuffisant
    {
        //arrange
        Bakery bakery = new Bakery();
        int expected = 0; // stock plein mais insuffisant


        //act
        bakery.SellBread(50);
        int actual = bakery.GetBreadStock();

        //assert
        Assert.Equal(expected, actual);
    }
}
