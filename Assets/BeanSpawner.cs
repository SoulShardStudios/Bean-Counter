using UnityEngine;
using SoulShard.Utils;
using UnityEngine.Events;

public class BeanSpawner : MonoBehaviour
{
    [SerializeField]
    Timer cooldownTimer;
    [SerializeField]
    UnityEvent _event;
    [SerializeField]
    Transform pressedPos;
    [SerializeField]
    Transform buttonTransform;
    bool canAcceptEvent;
    Vector3 originalPos;
    void Awake()
    {
        originalPos = buttonTransform.position;
        cooldownTimer.onDone += () => {
            canAcceptEvent = true; 
            buttonTransform.position = originalPos;
        };
    }

    void Update() => cooldownTimer.Tick(Time.deltaTime);

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canAcceptEvent)
            return;
        buttonTransform.position = pressedPos.position;
        cooldownTimer.Reset();
        canAcceptEvent = false;
        _event?.Invoke();
    }
}
