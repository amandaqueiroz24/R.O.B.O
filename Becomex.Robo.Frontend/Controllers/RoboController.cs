using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Becomex.Robo.Frontend.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RoboController : ControllerBase
	{

		#region ARM LEFT
		[HttpGet("RestLeft")]
		public string RestLeft()
		{
			return "O R.O.B.O está em repouso";
		}

		[HttpGet("SlightlyContratedLeft")]
		public string SlightlyContratedLeft()
		{
			return "O R.O.B.O está com braço esquerdo levemente contraido";
		}

		[HttpGet("ContratedLeft")]
		public string ContratedLeft()
		{
			return "O R.O.B.O está com braço esquerdo levemente contraido";
		}

		[HttpGet("StronglyContratedLeft")]
		public string StronglyContratedLeft()
		{
			return "O R.O.B.O está com braço esquerdo fortemente contraido";
		}

		[HttpGet("RotationToMinus90Left")]
		public string RotationToMinus90Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de -90º";
		}

		[HttpGet("RotationToMinus45Left")]
		public string RotationToMinus45Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de -45º";
		}

		[HttpGet("RotationTo45Left")]
		public string RotationTo45Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de 45º";
		}

		[HttpGet("RotationTo90Left")]
		public string RotationTo90Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de 90º";
		}

		#endregion

		#region ARM RIGHT

		[HttpGet("RestRight")]
		public string RestRight()
		{
			return "O R.O.B.O está em repouso";
		}

		[HttpGet("SlightlyContratedRight")]
		public string SlightlyContratedRight()
		{
			return "O R.O.B.O está com braço direito levemente contraido";
		}

		[HttpGet("ContratedRight")]
		public string ContratedRight()
		{
			return "O R.O.B.O está com braço direito levemente contraido";
		}

		[HttpGet("StronglyContratedRight")]
		public string StronglyContratedRight()
		{
			return "O R.O.B.O está com braço direito fortemente contraido";
		}

		[HttpGet("RotationToMinus90Right")]
		public string RotationToMinus90Right()
		{
			return "O R.O.B.O está com braço direito com rotação de -90º";
		}

		[HttpGet("RotationTo45Right")]
		public string RotationTo45Right()
		{
			return "O R.O.B.O está com braço direito com rotação de 45º";
		}

		[HttpGet("RotationTo90Right")]
		public string RotationTo90Right()
		{
			return "O R.O.B.O está com braço direito com rotação de 90º";
		}

		#endregion

		#region HEAD

		[HttpGet("HeadRotationToMinus90")]
		public string HeadRotationToMinus90()
		{
			return "A cabeça está com rotação de -90º";
		}

		[HttpGet("HeadRotationToMinus45")]
		public string HeadRotationToMinus45()
		{
			return "A cabeça está com rotação de -45º";
		}

		[HttpGet("HeadRest")]
		public string HeadRest()
		{
			return "A cabeça está em repouso";
		}

		[HttpGet("HeadUp")]
		public string HeadUp()
		{
			return "A cabeça está para cima";
		}

		[HttpGet("HeadDown")]
		public string Down()
		{
			return "A cabeça está para baixo";
		}
		#endregion

	}
}
