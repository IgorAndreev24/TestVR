using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item for sell",menuName = "Create item")]
public class Item : ScriptableObject
{
    public Sprite sprite;
    public int count;
    public int cost;

}
