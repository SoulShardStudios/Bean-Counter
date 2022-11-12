using UnityEngine.UI;
using UnityEngine;

public class BeanManager : MonoBehaviour
{
    [SerializeField]
    Text countText;

    [System.Serializable]
    class Bean
    {
        public Sprite sprite;
        [Range(0,1)]
        public float chance;
    }
    [SerializeField]
    Bean[] beans;

    [SerializeField]
    GameObject beanPrefab;

    uint beanCount;

    void Awake() => beanCount = (uint)PlayerPrefs.GetInt("BeanCount");

    void OnDestroy() => PlayerPrefs.SetInt("BeanCount", (int)beanCount);

    Bean SelectBean()
    {
        while (true)
        {
            var bean = beans[Random.Range(0, beans.Length)];
            if (Random.Range(0f, 1f) < bean.chance)
                return bean;
        }
    }

    public void SpawnBean()
    {
        var bean = SelectBean();
        beanCount++;
        countText.text = $"Beams: {beanCount}";
        var g = Instantiate(beanPrefab, transform.position, Quaternion.identity);
        g.GetComponent<SpriteRenderer>().sprite = bean.sprite;

    }

}
