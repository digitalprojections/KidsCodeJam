using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharContOne : MonoBehaviour
{
    private float Speed = 1f;
    public bool isMoving;
    private Vector2 origPos, targetPos;
    public float timeToMove = 0.4f;


    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator MovePlayer(Vector2 direction)
    {
        if (!isMoving)
        {
            isMoving = true;
            float elapsedTime = 0;

            origPos = transform.position;
            targetPos = origPos + direction;

            while (elapsedTime < timeToMove)
            {
                transform.position = Vector2.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.position = targetPos;

            isMoving = false;
        }
    }
}
