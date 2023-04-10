using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{

    public void SetAudio(float value)
    {
        AudioListener.volume= value;
    }
}
