using tdd_dojo_responsibility_chain.Handlers;
using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Services;

public class KeyBoardAssembleService
{
    public Keyboard Generate(string brandName, string switchType, string keyCapType)
    {
        var keyboard = new Keyboard();
        var circuitBoardHandler = new CircuitBoardHandler(new SwitchHandler(new KeyCapHandler()));
        circuitBoardHandler.Generate(brandName, keyboard);
        return keyboard;
    }
}
