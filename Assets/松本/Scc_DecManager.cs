using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scc_DecManager : MonoBehaviour
{
    public bool isAccelalation;//加速したいかどうか
    public bool isDeceleration;//減速したいかどうか

    public float kasokudo;//加速したい速度
    public float gensokudo;//減速度

    float tmpspeed;

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isAccelalation)
        //    Accelalation();
        //if (isDeceleration)
        //    Deceleration();
    }

    void Accelalation()
    {
        tmpspeed = playerController.forwordpower;
        playerController.forwordpower = playerController.forwordpower * kasokudo;
    }

    void Deceleration()
    {
        tmpspeed = playerController.forwordpower;
        playerController.forwordpower = playerController.forwordpower * gensokudo;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&isAccelalation)
        {
            Accelalation();
        }
        if(other.gameObject.tag == "Player" && isDeceleration)
        {
            Deceleration();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playerController.forwordpower = tmpspeed;
    }
}
