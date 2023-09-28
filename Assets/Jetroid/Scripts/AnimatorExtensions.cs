using UnityEngine;

namespace Assets.Jetroid.Scripts
{
    public static class AnimatorExtensions
    {
        public static void SetAnimationState(this Animator animator, PlayerAnimationStates state)
        {
            animator.SetInteger(AnimatorNames.PlayerAnimationState, (int)state);
        }
    }
}
