namespace Examples;

using GdUnit4;

using static GdUnit4.Assertions;


[TestSuite]
public class GdUnitExampleTest
{
    [TestCase]
    public void Example()
    {
        AssertString("This is an example message")
          .HasLength(26)
          .StartsWith("This is an ex");
    }
}

