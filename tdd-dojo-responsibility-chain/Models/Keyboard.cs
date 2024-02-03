namespace tdd_dojo_responsibility_chain.Models;

public class Keyboard
{
    public string CircuitBoard { get; set; }
    public string SwitchType { get; set; }
    public string KeyCapType { get; set; }

    public bool IsIncludeCircuitBoard()
    {
        return !string.IsNullOrEmpty(CircuitBoard);
    }

    public void GetCircuitBoard(string brandName)
    {
        CircuitBoard = brandName;
    }

    public void SetSwitchType(string switchType)
    {
        SwitchType = switchType;
    }

    public void SetKeyCapType(string keyCapType)
    {
        KeyCapType = keyCapType;
    }
}