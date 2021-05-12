using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Buzzsaw")]
public class BuzzsawAction : Action
{
    public override void Act(StateController controller)
    {
        Buzzsaw(controller);
        GameObject sound = GameObject.Find("SawSound");
        sound.GetComponent<PlayMe>().PlayAudio(8f);
    }

    private void Buzzsaw(StateController controller)
    {
        controller.transform.Rotate(0, controller.enemyStats.searchingTurnSpeed * Time.deltaTime, 0);
        controller.tankShooting.Fire(controller.enemyStats.attackForce, controller.enemyStats.attackRate);
    }
}