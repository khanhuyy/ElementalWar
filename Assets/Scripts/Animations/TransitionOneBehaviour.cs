using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// todo refactor this
public class TransitionOneBehaviour : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // PlayerController.instance.DeactivateAttackPoint(1);
        AlphabetController.instance.DeactivateAttackPoint(1);
        ArrowController.instance.DeactivateAttackPoint(1);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // if (PlayerController.instance.inputReceived) {
        //     animator.SetTrigger("Attack2");
        //     PlayerController.instance.ActivateAttackPoint(2);
        //     PlayerController.instance.ChangeReceiveInputStatus();
        //     PlayerController.instance.inputReceived = false;
        // }
        if (AlphabetController.instance.inputReceived) {
            animator.SetTrigger("Attack2");
            AlphabetController.instance.ActivateAttackPoint(2);
            AlphabetController.instance.ChangeReceiveInputStatus();
            AlphabetController.instance.inputReceived = false;
        }
        if (ArrowController.instance.inputReceived) {
            animator.SetTrigger("Attack2");
            ArrowController.instance.ActivateAttackPoint(2);
            ArrowController.instance.ChangeReceiveInputStatus();
            ArrowController.instance.inputReceived = false;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // PlayerController.instance.AttackDone();
        if (animator.name == "Alphabet") {
            AlphabetController.instance.AttackDone();
        } else if (animator.name == "Arrow") {
            ArrowController.instance.AttackDone();
        }
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
