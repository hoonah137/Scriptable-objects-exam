using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem items;
    SpriteRenderer spriteRenderer;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spriteRenderer.sprite = items.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        WeaponBag.instance.AddItem(items);
        Destroy(this.gameObject);

    }
}
