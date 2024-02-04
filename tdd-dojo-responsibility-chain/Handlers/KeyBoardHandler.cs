using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Handlers;

public class KeyBoardHandler: IKeyBoardHandler
{
    public void Generate(CustomerRequest request, Keyboard keyboard)
    {
        var handlerChain = new CircuitBoardHandler(new SwitchHandler(new KeyCapHandler()));
        handlerChain.Generate(request, keyboard);
    }
}