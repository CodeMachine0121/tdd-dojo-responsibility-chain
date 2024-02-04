using tdd_dojo_responsibility_chain.Models;
using tdd_dojo_responsibility_chain.Services;

namespace tdd_dojo_responsibility_chain.Handlers;

public class SwitchHandler: IKeyBoardHandler
{
    private readonly KeyCapHandler _keyCapHandler;

    public SwitchHandler(KeyCapHandler keyCapHandler)
    {
        _keyCapHandler = keyCapHandler;
    }

    public void Generate(CustomerRequest request, Keyboard keyboard)
    {
        keyboard.SetSwitchType(request.SwitchType);
        _keyCapHandler.Generate(request, keyboard);
    }
}