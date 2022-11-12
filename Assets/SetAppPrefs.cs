using UnityEngine;
public class SetAppPrefs : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 15;
        Screen.SetResolution(640, 480, false);
    }
}
