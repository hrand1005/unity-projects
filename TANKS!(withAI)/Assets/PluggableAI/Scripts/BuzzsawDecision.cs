using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Buzzsaw")]
public class BuzzsawDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool areYouDizzyYet = isDizzy(controller);
        return areYouDizzyYet;
    }

    private bool isDizzy(StateController controller)
    {
        return controller.CheckIfCountDownElapsed(controller.enemyStats.searchDuration);
    }
}
