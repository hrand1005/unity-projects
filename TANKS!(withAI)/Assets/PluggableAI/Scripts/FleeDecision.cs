using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Flee")]
public class FleeDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool areYouScared = isScared(controller);
        return areYouScared;
    }

    private bool isScared(StateController controller)
    {
        return controller.CheckIfCountDownElapsed(controller.enemyStats.searchDuration);
    }
}
