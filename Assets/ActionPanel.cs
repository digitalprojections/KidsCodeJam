using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPanel : MonoBehaviour
{
    private Vector2 endPosition;
    public GameObject SequencePanel;

    public GameObject RightMove;
    public GameObject LeftMove;
    public GameObject UpMove;
    public GameObject DownMove;
    public GameObject PickMove;
    private GameObject step;


    private void Start()
    {
        endPosition = SequencePanel.transform.position;
    }
    public void Right()
    {
        if(SequencePanel.transform.childCount >= 36)
        {
            return;
        }
        step = Instantiate(RightMove);
        step.transform.SetParent(SequencePanel.transform, false);
    }
    public void Left()
    {
        if (SequencePanel.transform.childCount >= 36)
        {
            return;
        }
        step = Instantiate(LeftMove);
        step.transform.SetParent(SequencePanel.transform, false);
    }
    public void Up()
    {
        if (SequencePanel.transform.childCount >= 36)
        {
            return;
        }
        step = Instantiate(UpMove);
        step.transform.SetParent(SequencePanel.transform, false);
    }
    public void Down()
    {
        if (SequencePanel.transform.childCount >= 36)
        {
            return;
        }
        step = Instantiate(DownMove);
        step.transform.SetParent(SequencePanel.transform, false);
    }
    public void PickUp()
    {
        if (SequencePanel.transform.childCount >= 36)
        {
            return;
        }
        step = Instantiate(PickMove);
        step.transform.SetParent(SequencePanel.transform, false);
    }
    public void Refresh()
    {

    }
    public void Play()
    {

    }
}
