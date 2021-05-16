using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class musicvolue : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer mixer;
    public void setlevel(float slidervalue)
    {
        mixer.SetFloat("musicvalue", Mathf.Log10(slidervalue)*20) ;
    }
}
