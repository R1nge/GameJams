using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField] private float timeBeforeDestroy;

    private void Start() => Destroy(gameObject, timeBeforeDestroy);
}