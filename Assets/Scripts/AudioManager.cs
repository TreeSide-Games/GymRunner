using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip collectingHealthFoodAudio;
    [SerializeField] AudioClip collectingFastFoodAudio;
    [SerializeField] AudioClip collectingCoinAudio;
    [SerializeField] AudioClip mainMusic;

    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }
    void Start()
    {
        Item.OnCollectedItem += launchAudio;

    }

    void launchAudio(Item item)
    {
        if (item.isMoney)
            audioSource.clip = collectingCoinAudio;
        else if(item.isHealthy)
            audioSource.clip = collectingHealthFoodAudio;
        else
            audioSource.clip = collectingFastFoodAudio;

        audioSource.Play();
    }

    private void OnDisable()
    {
        Item.OnCollectedItem -= launchAudio;
    }
}
