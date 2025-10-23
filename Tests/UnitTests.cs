namespace GithubActionsLab;

[TestClass]
public class CalculatorTests
{
    //  ADD TESTS
    [TestMethod]
    public void Add_Valid_Patino()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }

    //  SUBTRACT TESTS
    [TestMethod]
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-2, Program.Subtract("3", "5"));
        Assert.AreEqual(0, Program.Subtract("4", "4"));
    }

    [TestMethod]
    public void Subtract_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("x", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("3", "y"));
    }

    //  MULTIPLY TESTS
    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(5, Program.Multiply("3", "2"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
        Assert.AreEqual(-15, Program.Multiply("-3", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("3", "a"));
    }

    //  DIVIDE TESTS
    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("10", "5"));
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
    }

    [TestMethod]
    public void Divide_ByZero_Patino()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("5", "0"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("x", "2"));
    }

    //  POWER TESTS
    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(0.25, Program.Power("2", "-2"));
    }

    [TestMethod]
    public void Power_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
    }
}
