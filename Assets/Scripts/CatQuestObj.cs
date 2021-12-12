using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatQuestObj : QuestObj
{
    public bool fishPickedUped = false;
    public override void Interact()
    {
        if (!fishPickedUped)
            eventParam = 1;
        else
            eventParam = 2;
        base.Interact();
    }
}
