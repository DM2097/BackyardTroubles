using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Attackers))]
public class Pig : MonoBehaviour
{
    private Animator anim;
    private Attackers attacker;
    test testd;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attackers>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        GameObject obj = collider.gameObject;
        if (!obj.GetComponent<Defenders>())
        {
            testd.testD(true);
            return;
        }
        

        anim.SetBool("isAttacking", true);
        attacker.Attack(obj);

    }
}
