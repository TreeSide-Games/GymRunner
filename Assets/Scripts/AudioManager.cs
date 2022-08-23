using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip collectingHealthFoodAudio;
    [SerializeField] AudioClip collectingFastFoodAudio;
    [SerializeField] AudioClip collectingCoinAudio;
    [SerializeField] List<AudioClip> mainMusic = new List<AudioClip>();

    AudioSource[] audioSource;

    private void Awake()
    {
        audioSource = GetComponents<AudioSource>();

    }
    void Start()
    {
        Item.OnCollectedItem += launchCollectingAudio;

        StartCoroutine(PlayMusicCoroutine());
    }

    IEnumerator PlayMusicCoroutine()
    {
        float timeToEndMusic = 0;
        while (true)
        {
            launchMusic();
            timeToEndMusic = audioSource[1].clip.length;

            yield return new WaitForSeconds(timeToEndMusic);
        }
    }

    void launchCollectingAudio(Item item)
    {
        if (item.isMoney)
            audioSource[0].clip = collectingCoinAudio;
        else if(item.isHealthy)
            audioSource[0].clip = collectingHealthFoodAudio;
        else
            audioSource[0].clip = collectingFastFoodAudio;

        audioSource[0].Play();
    }

    void launchMusic()
    {
        var randomnes = UnityEngine.Random.Range(0, mainMusic.Count);

        audioSource[1].clip = mainMusic[randomnes];
        audioSource[1].Play();
    }

    private void OnDisable()
    {
        Item.OnCollectedItem -= launchCollectingAudio;
    }
}
