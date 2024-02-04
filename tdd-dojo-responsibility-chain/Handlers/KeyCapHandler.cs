using tdd_dojo_responsibility_chain.Models;
using tdd_dojo_responsibility_chain.Services;

namespace tdd_dojo_responsibility_chain.Handlers;

public class KeyCapHandler: IKeyBoardHandler
{
    public void Generate(CustomerRequest request, Keyboard keyboard)
    {
        keyboard.SetKeyCapType(request.KeyCapType);
        return;
    }
}