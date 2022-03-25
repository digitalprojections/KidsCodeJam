using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UpperContent : MonoBehaviour
{
    GameObject rImage = (GameObject) Instantiate(Resources.Load("Scenes"));

    public void insertActionButton(string currentAction)
    {
        Debug.Log("Button Inserted " + currentAction);

    }

    private List<GameObject> mylist;
}
