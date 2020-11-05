using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public MeshRenderer rightEyeImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            rightEyeImage.material.DOFade(0.2f, 50f);
        }else if(Input.GetKeyDown(KeyCode.X)){
            rightEyeImage.material.DOFade(0, 25);
        }
    }
}
