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
        _keyboard = _keyBoardAssembleService.Generate("Logic", "any_switch", "any_key_cap_type");
        Assert.AreEqual("Logic", _keyboard.CircuitBoard);
    }

    [Test]
    public void should_set_switch()
    {
        _keyboard = _keyBoardAssembleService.Generate("any_brand_name", "red", "any_key_cap_type");
        Assert.AreEqual("red", _keyboard.SwitchType);
    }

    [Test]
    public void should_set_key_cap()
    {
        _keyboard = _keyBoardAssembleService.Generate("any_brand_name", "any_switch_type", "PBT");
        Assert.AreEqual("PBT", _keyboard.KeyCapType);
    }

}

public class KeyBoardAssembleService
{
    public Keyboard Generate(string brandName, string switchType, string keyCapType)
    {
        var keyboard = new Keyboard();
        keyboard.GetCircuitBoard(brandName);
        keyboard.SetSwitchType(switchType);
        keyboard.SetKeyCapType(keyCapType);
        return keyboard;
    }
}

public class Keyboard
{
    public string CircuitBoard { get; set; }
    public string SwitchType { get; set; }
    public string KeyCapType { get; set; }

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

    public void SetKeyCapType(string keyCapType)
    {
        KeyCapType = keyCapType;
    }
}