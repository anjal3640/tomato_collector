using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    Vector3 diff;

    // Start is called before the first frame update
    void Start()
    {
        diff = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + diff;
    }
}
