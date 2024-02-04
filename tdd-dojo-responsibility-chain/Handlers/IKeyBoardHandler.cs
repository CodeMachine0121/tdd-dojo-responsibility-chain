using tdd_dojo_responsibility_chain.Models;
using tdd_dojo_responsibility_chain.Services;

namespace tdd_dojo_responsibility_chain.Handlers;

public interface IKeyBoardHandler
{
    void Generate(CustomerRequest request, Keyboard keyboard);
}