using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip pickup;
    public AudioClip jump;
    public AudioClip walk;
    public AudioClip damage;
    // Start is called before the first frame update

    private void Start() {
        audioSource =GetComponent<AudioSource>();
    }
    public void PlayPickupSound()
    {
        if (pickup!=null){
            audioSource.PlayOneShot(pickup);
        }else{
            Debug.Log("Pikcup Sound Missing");
        }
        
    }

    public void PlayJumpSound()
    {
        if (jump!=null){
            audioSource.PlayOneShot(jump);
        }else{
            Debug.Log("Jump Sound Missing");
        }
    }

    /*public void PlayWalkSound()
    {
        if (walk!=null){
            audioSource.PlayOneShot(walk);
        }else{
            Debug.Log("Walk Sound Missing");
        }
    }*/

    public void PlayDamageSound()
        {
            if (damage!=null){
                audioSource.PlayOneShot(damage);
            }else{
                Debug.Log("Damage Sound Missing");
            }
        }
}
