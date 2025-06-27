using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName= "newStoryNode", menuName = "New/StoryNode")]
public class storyNode : ScriptableObject
{
    [TextArea]
    public string storytext;

    public storyNode[] nextStoryNodes;
    public string[] nextStoryNodeText;
}
