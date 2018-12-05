using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChanger : MonoBehaviour {


public void ToggleSound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
