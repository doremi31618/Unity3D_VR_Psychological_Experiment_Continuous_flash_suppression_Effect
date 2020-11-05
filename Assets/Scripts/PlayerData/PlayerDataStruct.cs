using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataStruct : ScriptableObject
{
    public enum WeakEye{Right, Left};
    public WeakEye WeakEyeType = WeakEye.Left;
    public AnimationCurve FadingCurve;
    public float fadingTime;
}
