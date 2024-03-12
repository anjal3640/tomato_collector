using UnityEngine;

public class player : MonoBehaviour
{
    private bool iswalking;
    public bool ingame = true;
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameInput gameInput;
    bool canmove=true;
    float playersize = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (ingame)
        {
            Vector3 inputvector = gameInput.GetMovementVector();
            //Debug.Log(inputvector);
            canmove = !Physics.Raycast(transform.position, inputvector, playersize);//here if the ray hits it passes a true bool where we cant move
            if(canmove)
            {
                transform.position += inputvector * Time.deltaTime * speed;
            }
            
            iswalking = inputvector != Vector3.zero;

            transform.forward = Vector3.Slerp(transform.forward, inputvector, Time.deltaTime * 10);
            Debug.Log(transform.forward);
        }
        
    }
    public bool IsWalking()
    {
        return iswalking;
    }
}
