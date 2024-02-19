using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
	public float distance = 1.0f;
	public int m_ActionCount = 1;
	public Animator m_Animator;

	private bool isInAction;
	private bool isAnimChanged = true;
	private int actionIndex = 0;
	private int currentAnimHash;

	public bool IsInAction
	{
		get{return isInAction;}
	}

	void Start()
	{
		if(m_Animator == null)
		{
			m_Animator = GetComponent<Animator>();
		}

		currentAnimHash = m_Animator.GetCurrentAnimatorStateInfo(0).shortNameHash;

		InvokeRepeating("CheckAction", 0.1f, 0.1f);
	}

	public void NextAction()
	{
		if(isInAction)
			return;

		actionIndex++;
		isInAction = true;
		isAnimChanged = false;
		currentAnimHash = m_Animator.GetCurrentAnimatorStateInfo(0).shortNameHash;

		if(actionIndex > m_ActionCount)
			actionIndex = 1;

		if(m_Animator != null)
		{
			m_Animator.SetTrigger("Action_" + actionIndex.ToString());
		}
	}

	public void CheckAction()
	{
		if(!isAnimChanged)
		{
			if(!IsSameAnimation())
			{
				isAnimChanged = true;
				currentAnimHash = m_Animator.GetCurrentAnimatorStateInfo(0).shortNameHash;
			}

			return;
		}
		
		if((!AnimatorIsPlaying() || AnimatorIsLoop()))
			isInAction = false;
		else
			isInAction = true;
	}

	bool AnimatorIsPlaying()
	{		
		return m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1;
	}

	bool AnimatorIsLoop()
	{
		return m_Animator.GetCurrentAnimatorStateInfo(0).loop;
	}

	bool IsSameAnimation()
	{
		return currentAnimHash == m_Animator.GetCurrentAnimatorStateInfo(0).shortNameHash;
	}
}
