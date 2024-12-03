using Jackal;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameDataManager : PersistentSingleton<GameDataManager>
{
    /*----Scriptable data-----------------------------------------------------------------------------------------------*/

    /*----Data variable-------------------------------------------------------------------------------------------------*/
    [HideInInspector] public PlayerData playerData;
    public int currentID;

    private void Start()
    {
        Application.targetFrameRate = Mathf.Max(60, Screen.currentResolution.refreshRate);
    }

    private void OnEnable()
    {
        playerData = new GameObject(Constant.DataKey_PlayerData).AddComponent<PlayerData>();
        playerData.transform.parent = transform;
        playerData.Init();
    }

    public void ResetData()
    {
        playerData.ResetData();
    }

    public void SetCurrentSongID(int id)
    {
        
    }
}