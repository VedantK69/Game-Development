using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
    [SerializeField]
    private float _timeuntilIdle;

    [SerializeField]
    private int _numberofIdleAnimations;

    private bool _isIdle;
    private float _idleTime;
    // Start is called before the first frame update
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        ResetIdle(animator);
    }

    // Update is called once per frame
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_isIdle == false)
        {
            _idleTime += Time.deltaTime;

            if (_idleTime > _timeuntilIdle)
            {
                _isIdle = true;
                int IdleAnimation = Random.Range(1, _numberofIdleAnimations +1);

                animator.SetFloat("IdleAnimation", IdleAnimation); 
            }
        }
    }

    private void ResetIdle(Animator animator)
    {
        _isIdle = false;
        _idleTime = 0;
    }
}
