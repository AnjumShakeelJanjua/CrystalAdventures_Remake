using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudMenuScript : Menu
{
    public void MoveToMainMenu()
    {
        MenuManager.menuManagerInstance.UpdateMenuState(MenuManager.MenuTypes.MainMenu);
    }
}
