using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip thrown;
    public AudioClip jump;
    public AudioClip impact;
    public AudioClip damage;
    public AudioClip victory;
    // Start is called before the first frame update

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        if (jump != null)
        {
            audioSource.PlayOneShot(jump);
        }
        else
        {
            Debug.Log("Jump Sound Missing");
        }
    }
    public void PlayVictorySound()
    {
        if (victory != null)
        {
            audioSource.PlayOneShot(victory);
        }
        else
        {
            Debug.Log("Jump Sound Missing");
        }
    }
    public void PlayDamageSound()
    {
        if (damage != null)
        {
            audioSource.PlayOneShot(damage);
        }
        else
        {
            Debug.Log("Damage Sound Missing");
        }
    }
    public void PlayThrowSound()
    {
        if (thrown != null)
        {
            audioSource.PlayOneShot(thrown);
        }
        else
        {
            Debug.Log("Damage Sound Missing");
        }
    }
    public void PlayImpactSound()
    {
        if (impact != null)
        {
            audioSource.PlayOneShot(impact);
        }
        else
        {
            Debug.Log("Damage Sound Missing");
        }
    }
}
