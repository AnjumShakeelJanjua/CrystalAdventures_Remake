using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : Menu
{
    public void MoveToOptionsMenu()
    {
        MenuManager.menuManagerInstance.UpdateMenuState(MenuManager.MenuTypes.OptionMenu);
    }

}
