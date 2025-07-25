using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]

    private TMP_Text textArea;

    [SerializeField]
    private storyNode startingNode;
    private storyNode currentNode;

    private void Start()
    {
        currentNode = startingNode;
        DisplayNode();
    }

    private void Update()
    {
        if (currentNode.nextStoryNodes != null)
        {
            for (int i = 0; i < currentNode.nextStoryNodes.Length; i++)
            { 
                if (Input.GetKeyDown((KeyCode)((int)KeyCode.Alpha1 + i)))
                {
                    MakeChoice(i);
                }
            }
        }
    }

    private void MakeChoice(int choiceIndex)
    {
        if(currentNode.nextStoryNodes != null && choiceIndex < currentNode.nextStoryNodes.Length)
        {
            currentNode = currentNode.nextStoryNodes[choiceIndex];
            DisplayNode();
        }
    }

    private void DisplayNode()
    {
        textArea.text = currentNode.storytext;
        DisplayChoices();
    }

   private void DisplayChoices()
    {
        if (currentNode.nextStoryNodeText.Length > 0)
        {
            string choiceText = "\n\nMake a choice:\n";

            for (int i = 0; i < currentNode.nextStoryNodeText.Length; i++)
            { 
                choiceText += (i + 1) + " " + currentNode.nextStoryNodeText[i] + "\n";
            }
            textArea.text += choiceText;
        }
    }
}
