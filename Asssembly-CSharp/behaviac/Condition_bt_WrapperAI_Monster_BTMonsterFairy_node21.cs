using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Monster_BTMonsterFairy_node21 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			OutOfControlType outOfControlType = ((ObjAgent)pAgent).GetOutOfControlType();
			OutOfControlType outOfControlType2 = OutOfControlType.Terror;
			return (outOfControlType == outOfControlType2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
