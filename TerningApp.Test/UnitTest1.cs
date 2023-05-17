using TerningApp.Typer;

namespace TerningApp.Test;

public class TerningTest
{
    [Fact]
    public void TerningV�rdi()
    {
        Terning t = new Terning(1);
        Assert.True(t.V�rdi == 1);
    }

    [Fact]
    public void TestYatzy()
    {
        for (int i = 0; i < 6; i++)
        {
            B�ger b = new B�ger(i+1, i + 1, i + 1, i + 1, i + 1);
            Assert.True(b.ErYatzy());
        }
    }
}