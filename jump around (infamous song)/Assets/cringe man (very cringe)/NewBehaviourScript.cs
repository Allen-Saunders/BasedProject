//Allen_Saunders.Wallstreet_bets_user_runs_from_Debt
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
        playerRb.AddForce(Vector3.up * 100, ForceMode.Impulse); } }
    
}
