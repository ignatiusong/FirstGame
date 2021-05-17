using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown qualitySelection;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        Debug.Log("Quality Index" + qualityIndex);
        Debug.Log("Current Quality Index " + QualitySettings.GetQualityLevel());
        QualitySettings.SetQualityLevel(qualityIndex, true);
    }
}
