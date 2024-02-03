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