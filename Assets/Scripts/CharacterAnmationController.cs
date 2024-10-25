using UnityEngine;

public partial class AnmationController
{
    public class CharacterAnmationController : AnmationController 
    {
        private static readonly int Idle = Animator.StringToHash("Idle");
        private static readonly int Jump = Animator.StringToHash("Jimp");
        private static readonly int Attacked = Animator.StringToHash("Attacked");


    }
}
