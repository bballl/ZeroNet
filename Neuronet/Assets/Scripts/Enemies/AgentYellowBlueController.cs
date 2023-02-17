using UnityEngine;

public class AgentYellowBlueController : Enemy
{
    private void Start()
    {
        BasisInit();

        Speed = Data.AgentYellowBlueSpeed;
        Defense = Data.AgentYellowBlueDefense;
        ContactDamage= Data.AgentYellowBlueContactDamage;
        Experience= Data.AgentYellowBlueExperience;
    }

    private void FixedUpdate()
    {
        MoveToPlayer();
    }
}