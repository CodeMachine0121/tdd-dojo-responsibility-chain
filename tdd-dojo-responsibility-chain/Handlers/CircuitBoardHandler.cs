using tdd_dojo_responsibility_chain.Models;
using tdd_dojo_responsibility_chain.Services;

namespace tdd_dojo_responsibility_chain.Handlers;

public class CircuitBoardHandler(IKeyBoardHandler switchHandler) : IKeyBoardHandler
{
    public void Generate(CustomerRequest request, Keyboard keyboard)
    {
        keyboard.GetCircuitBoard(request.BrandName);
        switchHandler.Generate(request, keyboard);
    }
}