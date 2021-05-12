using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Flee")]
public class FleeAction : Action
{
    public override void Act(StateController controller)
    {
        Flee(controller);
        GameObject sound = GameObject.Find("ScreamSound");
        sound.GetComponent<PlayMe>().PlayAudio(2f);
    }

    private void Flee(StateController controller)
    {   
        //Vector3 newDestination = new Vector3(controller.chaseTarget.position.x * 1000, controller.chaseTarget.position.y, controller.chaseTarget.position.z * -1000);
        //controller.navMeshAgent.destination = newDestination;
        controller.navMeshAgent.speed *= controller.enemyStats.moveSpeed;
        controller.navMeshAgent.isStopped = false;
    }
}
