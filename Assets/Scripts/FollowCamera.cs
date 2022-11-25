using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject followTheThing;

    private void Update()
    {
        transform.position = followTheThing.transform.position + new Vector3(0,0,-2);
    }
}
