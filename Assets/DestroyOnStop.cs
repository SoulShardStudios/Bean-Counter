using SoulShard.Utils;
using UnityEngine;

public class DestroyOnStop : MonoBehaviour
{
    [SerializeField]
    Timer destroyAfter;

    void Awake()
    {
        destroyAfter.Reset();
        destroyAfter.onDone += () => { Destroy(gameObject); };
    }

    void Update() => destroyAfter.Tick(Time.deltaTime);
}
