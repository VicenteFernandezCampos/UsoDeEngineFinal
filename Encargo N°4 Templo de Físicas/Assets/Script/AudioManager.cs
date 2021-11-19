using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
public class AudioManager : MonoBehaviour
{
    public TMP_Text text;

    public AudioMixer audioMixer;
    public AudioMixerGroup aUGroup;
    public List<Slider> slider = new List<Slider>();
    public List<AudioSource> audioSource = new List<AudioSource>();
    public List<AudioClip> clip = new List<AudioClip>();

    private void Update()
    {
        audioMixer.SetFloat("masterVol", slider[0].value);
    }
    public void Start()
    {
        audioSource[0].clip = clip[0];
        audioSource[0].outputAudioMixerGroup = aUGroup;
        audioSource[0].Play();
    }
}
