using System;

namespace POP
{

	public enum POPAnimationEventType : uint {
		PropertyRead = 0,
		PropertyWrite,
		oValueUpdate,
		FromValueUpdate,
		VelocityUpdate,
		BouncinessUpdate,
		SpeedUpdate,
		FrictionUpdate,
		MassUpdate,
		ensionUpdate,
		DidStart,
		DidStop,
		DidReachToValue
	}

	public enum POPAnimationClampFlags : uint {
		None = 0,
		Start = 1 << 0,
		End = 1 << 1,
		Both = 1 << 0 | 1 << 1
	}

}
