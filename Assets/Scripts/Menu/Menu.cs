using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : State
{
    public MenuManager.MenuTypes menuType;
    public bool isActive;
    public List<MenuManager.MenuTypes> allowed;

    private void Awake()
    {
        this.OnBegin = HandleOnBegin;
        this.OnExit = HandleOnExit;
    }

    void HandleOnBegin()
    {
        Show();
    }

    bool HandleOnExit(State _nextMenu)
    {
        MenuManager.MenuTypes _nextMenuType = ((Menu)_nextMenu).menuType;
        if (allowed.FindIndex(item => item == _nextMenuType) == -1)
        {
            return false;
        }
        Close();
        return true;
    }

    private void Show()
    {
        gameObject.SetActive(true);
        isActive = true;
    }

    private void Close()
    {
        gameObject.SetActive(false);
        isActive = false;
    }
}

