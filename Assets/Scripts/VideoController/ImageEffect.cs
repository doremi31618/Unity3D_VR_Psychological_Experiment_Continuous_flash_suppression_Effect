using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ImageEffect : MonoBehaviour
{
    public void FadeIn(UnityEngine.UI.Image img, float time){
        img.material.DOFade(1, time);
    }
    public void FadeOut(Image img, float time){
        img.material.DOFade(0, time);
    }

}
