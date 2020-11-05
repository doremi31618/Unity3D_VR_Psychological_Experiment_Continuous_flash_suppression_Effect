using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public GameObject prefab;
    private GameObject clone;
    public static bool isClone = false;

    // Start is called before the first frame update
    void Start()
    {
        // 
        if (!isClone){

            isClone=true;
            clone = (GameObject)Instantiate(prefab);
            DontDestroyOnLoad(clone);

        }
    }
}

