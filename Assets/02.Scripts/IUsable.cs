using UnityEngine;

public interface IUsable
{
    public void OnLeftClick();

    public void OnRightClick();

    bool CanUse { get;}
}
