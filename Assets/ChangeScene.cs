using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SetScene(string sceneName) => SceneManager.LoadScene(sceneName);
}
