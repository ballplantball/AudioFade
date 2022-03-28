using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFade : MonoBehaviour
{
    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime, float FadeVolume)//聲音漸小到某值
    {
        float startVolume = audioSource.volume;
        while (audioSource.volume > FadeVolume)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
    }

    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime, float FadeVolume)//聲音漸大到某值
    {
        while (audioSource.volume < FadeVolume)
        {
            audioSource.volume += 0.2f * Time.deltaTime / FadeTime;
            yield return null;
        }
    }
}