using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region PrivateVariables
    [SerializeField]
    private PlayerManager m_playerManager;
    [SerializeField]
    private InputManager m_inputManager;
    [SerializeField]
    private InventoryManager m_inventoryManager;
    [SerializeField]
    private UIManager m_uiManager;
    [SerializeField]
    private SoundManager m_soundManager;
    [SerializeField]
    private SceneLoadingManager m_sceneLoadingManager;
    [SerializeField]
    private EnvironmentManager m_environmentManager;
    #endregion

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
