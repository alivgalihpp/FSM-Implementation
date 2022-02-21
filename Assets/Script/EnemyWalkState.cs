using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalkState : EnemyBaseState
{

    public override void EnterState(StateMachineManager enemy) {
        Debug.Log("lagi jalan");
    }

    public override void UpdateState(StateMachineManager enemy) { 
    
    }

    public override void OnCollisionEnter(StateMachineManager enemy, Collision collision) { 
    
    }
}
