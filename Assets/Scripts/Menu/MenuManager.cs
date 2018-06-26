using System.Collections.Generic;
using System.Linq;

public class MenuManager : StateManager
{
    public enum MenuTypes
    {
        MainMenu = 0,
        OptionMenu,
        HUD
    }

    MenuTypes currentMenu;
    public static MenuManager menuManagerInstance;
    public List<Menu> allMenus;

    // Use this for initialization
    void Start()
    {
        menuManagerInstance = this;
        allMenus = FindObjectsOfType<Menu>().ToList();

        foreach (var item in allMenus)
        {
            item.gameObject.SetActive(false);
        }

        UpdateMenuState(MenuTypes.MainMenu);
    }

    public void UpdateMenuState(MenuTypes nextState)
    {
        var state = allMenus.Find(item => item.menuType == nextState);
        if (base.ChangeState(state))
        {
            currentMenu = nextState;
        }
    }

    public void OnMenuOpenButton(int _menuIndex)
    {
        UpdateMenuState((MenuTypes)_menuIndex);
    }
}
