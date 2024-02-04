using tdd_dojo_responsibility_chain.Handlers;
using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Services;

public class KeyBoardAssembleService(IKeyBoardHandler keyBoardHandler)
{
    public Keyboard Generate(CustomerRequest request)
    {
        var keyboard = new Keyboard();
        keyBoardHandler.Generate(request, keyboard);
        return keyboard;
    }
}