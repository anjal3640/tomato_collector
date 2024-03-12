using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputAction playerInputAction;
    private void Awake()
    {
        playerInputAction = new PlayerInputAction();
        playerInputAction.player.Enable();
    }
    public Vector3 GetMovementVector()
    {
        Vector2 inputvector = playerInputAction.player.move.ReadValue<Vector2>();
        //Debug.Log(inputvector);
        Vector3 movedirection= new Vector3(inputvector.x,0, inputvector.y);
        movedirection = movedirection.normalized;
        //Debug.Log(movedirection);
        return movedirection;
    }
}
