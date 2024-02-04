using tdd_dojo_responsibility_chain.Models;
using tdd_dojo_responsibility_chain.Services;

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
        _keyboard = _keyBoardAssembleService.Generate(new CustomerRequest(){BrandName = "Logic"});
        Assert.AreEqual("Logic", _keyboard.CircuitBoard);
    }

    [Test]
    public void should_set_switch()
    {
        _keyboard = _keyBoardAssembleService.Generate(new CustomerRequest(){SwitchType = "red"});
        Assert.AreEqual("red", _keyboard.SwitchType);
    }

    [Test]
    public void should_set_key_cap()
    {
        _keyboard = _keyBoardAssembleService.Generate(new CustomerRequest(){KeyCapType = "PBT"});
        Assert.AreEqual("PBT", _keyboard.KeyCapType);
    }

}