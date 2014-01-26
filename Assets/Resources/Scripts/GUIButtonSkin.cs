using UnityEngine;
using System.Collections;

/// <summary>
/// sets audio clips, colors for buttons
///     used in game
/// @Usage: place on object with ButtonSounds
/// </summary>
public class GUIButtonSkin : MonoBehaviour
{

    public AudioClip mouseOverClip, mouseClickClip;
    public Color mouseOverColor, mouseOffColor;
    public Texture mouseOverTexture, mouseExitTexture;

    public void PlayMouseOverSound()
    {
        audio.clip = mouseOverClip;
        if (audio.clip != null)
            audio.PlayOneShot(audio.clip);
    }

    public void PlayMouseClickSound()
    {
        audio.clip = mouseClickClip;
        if (audio.clip != null)
            audio.PlayOneShot(audio.clip);
    }
}