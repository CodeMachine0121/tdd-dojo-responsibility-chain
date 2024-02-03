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
        _keyboard = _keyBoardAssembleService.Generate("Logic");
        Assert.AreEqual("Logic", _keyboard.CircuitBoard);
    }

}

public class KeyBoardAssembleService
{
    public Keyboard Generate(string brandName)
    {
        var keyboard = new Keyboard();
        keyboard.GetCircuitBoard(brandName);
        return keyboard;
    }
}

public class Keyboard
{
    public string CircuitBoard { get; set; }

    public bool IsIncludeCircuitBoard()
    {
        return !string.IsNullOrEmpty(CircuitBoard);
    }

    public void GetCircuitBoard(string brandName)
    {
        CircuitBoard = brandName;
    }
}