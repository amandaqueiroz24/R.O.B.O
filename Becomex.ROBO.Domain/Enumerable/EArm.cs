using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.ROBO.Domain.Enumerable
{
	public enum EArm
	{
		#region  Elbow
		REST = 0,
		SLIGHTLY_CONTRATED = 1,
		CONTRATED = 2,
		STRONGLY_CONTRATED = 3,
		#endregion

		#region Pulse
		ROTATION_TO_MINUS_90 = 4,
		ROTATION_TO_MINUS_45 = 5,
		ROTATION_TO_90 = 6,
		ROTATION_TO_45 = 6,

		#endregion

	}
}
