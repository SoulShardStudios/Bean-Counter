using UnityEngine;

[CreateAssetMenu(menuName = "Bean Counter/Text")]
public class TextContainer : ScriptableObject
{
    [TextArea(minLines:5, maxLines:10)]
    public string text;
}
