using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenuScript : Menu
{
    public void MoveToHudMemnu()
    {
        MenuManager.menuManagerInstance.UpdateMenuState(MenuManager.MenuTypes.HUD);
    }

}
