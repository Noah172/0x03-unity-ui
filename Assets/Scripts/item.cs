using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Item")]
public class item : ScriptableObject
{
    public Sprite sprite;
    public string _name;
    public int amount;
    [TextArea] public string description;

    public void RemoveElement()
    {
        if (amount > 0)
            --amount;
    }
}
