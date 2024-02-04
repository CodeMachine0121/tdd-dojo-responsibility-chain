using tdd_dojo_responsibility_chain.Models;

namespace tdd_dojo_responsibility_chain.Handlers;

public interface IKeyBoardHandler
{
    void Generate(string brandName, Keyboard keyboard);
}