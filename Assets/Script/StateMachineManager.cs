using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineManager : MonoBehaviour
{
    EnemyBaseState currentState; //Acuan Referensi untuk state yang aktif
    public EnemyWalkState WalkState = new EnemyWalkState(); //mengenalkan fungsi jalan
    public EnemyStopState StopState = new EnemyStopState(); //mengenalkan fungsi berhenti

    // Start is called before the first frame update
    void Start()
    {
        //Keadaan awal dari state machine, yaiutu berhenti
        currentState = StopState;
        currentState.EnterState(this);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
