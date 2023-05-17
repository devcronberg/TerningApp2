using TerningApp.Typer;

namespace TerningApp.Test;

public class TerningTest
{
    [Fact]
    public void TerningVærdi()
    {
        Terning t = new Terning(1);
        Assert.True(t.Værdi == 1);
    }

    [Fact]
    public void TestYatzy()
    {
        for (int i = 0; i < 6; i++)
        {
            Bæger b = new Bæger(i+1, i + 1, i + 1, i + 1, i + 1);
            Assert.True(b.ErYatzy());
        }
    }
}