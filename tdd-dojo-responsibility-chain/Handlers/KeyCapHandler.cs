using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Handlers;

public class KeyCapHandler: IKeyBoardHandler
{
    public void Generate(string keyCapType, Keyboard keyboard)
    {
        keyboard.SetKeyCapType(keyCapType);
        return;
    }
}