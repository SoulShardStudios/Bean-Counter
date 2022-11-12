using UnityEngine;
using UnityEngine.Audio;
public class BeanSoundPlayer : MonoBehaviour
{
    [SerializeField]
    [Range(0,1)]
    float beanClipChance;
    [System.Serializable]
    class RandomClip
    {
        public AudioClip clip;
        [Range(0, 1)]
        public float chance;
    }

    [SerializeField]
    RandomClip[] clips;
    [SerializeField]
    AudioSource source;
    RandomClip SelectClip()
    {
        while (true)
        {
            var bean = clips[Random.Range(0, clips.Length)];
            if (Random.Range(0f, 1f) < bean.chance)
                return bean;
        }
    }

    public void PlayClip()
    {
        if (Random.Range(0f, 1f) > beanClipChance)
            return;

        source.clip = SelectClip().clip;
        source.Play();
    }
}
