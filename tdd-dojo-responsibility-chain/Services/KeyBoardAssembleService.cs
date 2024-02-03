using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Services;

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