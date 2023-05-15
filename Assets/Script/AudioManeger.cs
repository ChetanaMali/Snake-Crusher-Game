using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    private static AudioManeger instance;
    public static AudioManeger Instance { get { return instance; } }

    [SerializeField] AudioSource audioSource;
    //[SerializeField] AudioSource backAudioSource;
    [SerializeField] AudioClip m_BoneCollect,m_EnemyDead,m_MoneyCollect, music;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        //backAudioSource = GetComponent<AudioSource>();
        //BackGroundMusic();
    }
    public void BackGroundMusic()
    {
        audioSource.clip = music;
        audioSource.Play();
    }
    public void EnemyDeadSfx()
    {
        audioSource.clip = m_EnemyDead;
        audioSource.Play();
    }
    public void BoneCollectdSfx()
    {
        audioSource.clip = m_BoneCollect;
        audioSource.Play();
    }
    public void MoneyCollectedSfx()
    {
        audioSource.clip = m_MoneyCollect;
        audioSource.Play();
    }
}
