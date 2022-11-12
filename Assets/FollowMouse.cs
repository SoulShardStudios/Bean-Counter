using UnityEngine;
public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    Transform armBase;

    [SerializeField]
    Transform handCenter;

    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var diff = mousePos - armBase.position;
        var rotation = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        armBase.rotation = Quaternion.Euler(0,0, rotation);
        handCenter.rotation = Quaternion.Euler(0, 0, rotation);
        handCenter.position = (Vector2)mousePos;
    }
}
