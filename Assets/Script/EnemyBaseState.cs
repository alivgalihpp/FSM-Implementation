using UnityEngine;

public abstract class EnemyBaseState
{
    public abstract void EnterState(StateMachineManager enemy);

    public abstract void UpdateState(StateMachineManager enemy);

    public abstract void OnCollisionEnter(StateMachineManager enemy, Collision collision);

}
