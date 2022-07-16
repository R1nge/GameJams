using System.Collections;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    [SerializeField] private Color damageColor;
    [SerializeField] private float colorDelay;
    private SpriteRenderer _spriteRenderer;
    private Color _defaultColor;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultColor = _spriteRenderer.color;
    }

    public void ChangeColor() => StartCoroutine(ChangeColor_c());

    private IEnumerator ChangeColor_c()
    {
        _spriteRenderer.color = damageColor;
        yield return new WaitForSeconds(colorDelay);
        _spriteRenderer.color = _defaultColor;
    }
}