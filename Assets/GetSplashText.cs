using UnityEngine;
using UnityEngine.UI;
public class GetSplashText : MonoBehaviour
{
    [SerializeField]
    TextContainer splashText;
    [SerializeField]
    Text text;
    void Awake()
    {
        var splashtexts = splashText.text.Split(new char[] { '\n' });
        text.text = splashtexts[Random.Range(0, splashtexts.Length - 1)];
    }
}
