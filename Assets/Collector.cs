using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collector : MonoBehaviour
{
                                                                                                           
    [SerializeField] List<Collectible> gatherables;
    [SerializeField] UnityEvent OnCompleteEvent;
}
