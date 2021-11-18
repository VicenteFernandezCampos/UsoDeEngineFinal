using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
public class AudioManager : MonoBehaviour
{
    public TMP_Text text;
    public Slider masterVolSlider;

    public AudioMixer audioMixer;
    public AudioMixerGroup BMGMixerGroup;
    public AudioMixerGroup SFXMixerGroup;
    public AudioSource BMGAudioSource;
    public AudioSource SFXAudioSource;
    public List<AudioClip> clip = new List<AudioClip>();

    private void Update()
    {
        audioMixer.SetFloat("masterVol", masterVolSlider.value);
    }
}
