using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerAnimator : MonoBehaviour
{
    mainmenu username;
    public int points = 0;
    private Animator animator;
    [SerializeField] private player player;
    private const string iswalking = "IsWalking";
    private bool roll=false;
    [SerializeField] private TMP_Text name;
    [SerializeField] private TMP_Text points_text;
    // Start is called before the first frame update
    void Start()
    {
        name.text = mainmenu.input;
    }
    private void Awake()
    {
        animator = GetComponent<Animator>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tomato") { 
            points++;
            points_text.text = "points: "+points+"/10";
            other.gameObject.SetActive(false);
            
        }
        if (points == 10)
        {
            player.ingame = false;
            animator.SetInteger("done", points);

        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(iswalking, player.IsWalking());
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!roll)
            {
                roll = true;
            }
            else
            {
                roll = false;
            }
        }
        animator.SetBool("isroll", roll);
    }
}
