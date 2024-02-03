namespace tdd_dojo_responsibility_chain;

[TestFixture]
public class KeyBoardAssembleServiceTests
{
    private Keyboard _keyboard;
    private KeyBoardAssembleService _keyBoardAssembleService;

    [SetUp]
    public void SetUp()
    {
        _keyBoardAssembleService = new KeyBoardAssembleService();
    }

    // circuit board -> switch -> key cap
    [Test]
    public void should_get_circuit_board()
    {
        _keyboard = _keyBoardAssembleService.Generate("Logic", "any_switch");
        Assert.AreEqual("Logic", _keyboard.CircuitBoard);
    }

    [Test]
    public void should_set_switch()
    {
        _keyboard = _keyBoardAssembleService.Generate("Logic", "red");
        Assert.AreEqual("red", _keyboard.SwitchType);
    }

}

public class KeyBoardAssembleService
{
    public Keyboard Generate(string brandName, string switchType)
    {
        var keyboard = new Keyboard();
        keyboard.GetCircuitBoard(brandName);
        keyboard.SetSwitchType(switchType);
        return keyboard;
    }
}

public class Keyboard
{
    public string CircuitBoard { get; set; }
    public string SwitchType { get; set; }

    public bool IsIncludeCircuitBoard()
    {
        return !string.IsNullOrEmpty(CircuitBoard);
    }

    public void GetCircuitBoard(string brandName)
    {
        CircuitBoard = brandName;
    }

    public void SetSwitchType(string switchType)
    {
        SwitchType = switchType;
    }
}