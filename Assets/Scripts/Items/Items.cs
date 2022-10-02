using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType{Equipable,Useable,Quest }
[CreateAssetMenu(fileName ="Items",menuName = "Item/CreateNewItem")]
public class Items : ScriptableObject
{
    public int Id;
    public string ItemName;
    public int Value;
    public Sprite icon;
}
