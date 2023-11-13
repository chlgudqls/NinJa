using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    void Start()
    {
        Managers.Resource.LoadAllAsync<GameObject>("Prefabs", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");
            if (totalCount == count)
            {
                StartLoaded();
            }
        });
    }
     
    void StartLoaded()
    {
        GameObject prefab = Managers.Resource.Load<GameObject>("Circle.prefab");
    }
    
}
