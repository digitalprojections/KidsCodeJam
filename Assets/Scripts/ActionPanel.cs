using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPanel : MonoBehaviour
{
    public static ActionPanel Instance;

    private Vector2 endPosition;
    public GameObject SequencePanel;

    public GameObject RightMove;
    public GameObject LeftMove;
    public GameObject UpMove;
    public GameObject DownMove;
    public GameObject PickMove;
    private GameObject step;
    private int stepCount;

    private void Awake()
    {
        Instance = this;
    }
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
        Debug.Log(SequencePanel.transform.GetChild(stepCount).tag);
        StartCoroutine(StepDelay());
    }

    private IEnumerator StepDelay()
    {
        switch(SequencePanel.transform.GetChild(stepCount).tag)
        {
            case "Up":
                StartCoroutine(CharContOne.Instance.MovePlayer(Vector2.up));
                break;

            case "Down":
                StartCoroutine(CharContOne.Instance.MovePlayer(Vector2.down));
                break;

            case "Right":
                StartCoroutine(CharContOne.Instance.MovePlayer(Vector2.right));
                break;

            case "Left":
                StartCoroutine(CharContOne.Instance.MovePlayer(Vector2.left));
                break;

        }
        return null;        
    }
    public void NextStep()
    {
        if (SequencePanel.transform.childCount > 0)
        {
            if(SequencePanel.transform.childCount - stepCount > 1)
                    {
                stepCount++;
                StartCoroutine(StepDelay());
            }
        }
    }
}
