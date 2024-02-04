using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Handlers;

public class CircuitBoardHandler(IKeyBoardHandler switchHandler) : IKeyBoardHandler
{
    public void Generate(string brandName, Keyboard keyboard)
    {
        keyboard.GetCircuitBoard(brandName);
        switchHandler.Generate("red", keyboard);
    }
}