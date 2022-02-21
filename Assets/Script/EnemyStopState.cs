using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStopState : EnemyBaseState
{
    Vector3 startingSize = new Vector3(0.1f, 0.1f, 0.1f);
    Vector3 sizeScaler = new Vector3(0.1f, 0.1f, 0.1f);
    public override void EnterState(StateMachineManager enemy)
    {
        Debug.Log("Saat ini sedang diam");
    }

    public override void UpdateState(StateMachineManager enemy)
    {
        if (enemy.transform.localScale.x < 1)
        {
            enemy.transform.localScale += sizeScaler * Time.deltaTime;
            Debug.Log("lagi update");
        }
        else
        {
            enemy.SwitchState(enemy.WalkState); //menukar state
        }
        
    }

    public override void OnCollisionEnter(StateMachineManager enemy, Collision collision)
    {

    }
}
