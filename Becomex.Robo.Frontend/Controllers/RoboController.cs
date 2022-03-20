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
		
		[HttpGet("Rest")]
		public string Rest()
		{
			return "O R.O.B.O está em repouso";
		}

		[HttpGet("SlightlyContratedLeft")]
		public string SlightlyContratedLeft()
		{
			return "O R.O.B.O está com braço esquerdo levemente contraido";
		}


		[HttpGet("SlightlyContratedRight")]
		public string SlightlyContratedRight()
		{
			return "O R.O.B.O está com braço direito levemente contraido";
		}

		[HttpGet("ContratedLeft")]
		public string ContratedLeft()
		{
			return "O R.O.B.O está com braço esquerdo levemente contraido";
		}

		[HttpGet("ContratedRight")]
		public string ContratedRight()
		{
			return "O R.O.B.O está com braço direito levemente contraido";
		}

		[HttpGet("StronglyContratedLeft")]
		public string StronglyContratedLeft()
		{
			return "O R.O.B.O está com braço esquerdo fortemente contraido";
		}

		[HttpGet("StronglyContratedRight")]
		public string StronglyContratedRight()
		{
			return "O R.O.B.O está com braço direito fortemente contraido";
		}

		[HttpGet("RotationToMinus90Left")]
		public string RotationToMinus90Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de -90º";
		}

		[HttpGet("RotationToMinus90Right")]
		public string RotationToMinus90Right()
		{
			return "O R.O.B.O está com braço direito com rotação de -90º";
		}

		[HttpGet("RotationToMinus45Left")]
		public string RotationToMinus45Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de -45º";
		}

		[HttpGet("RotationTo45Right")]
		public string RotationTo45Right()
		{
			return "O R.O.B.O está com braço direito com rotação de 45º";
		}

		[HttpGet("RotationTo45Left")]
		public string RotationTo45Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de 45º";
		}

		[HttpGet("RotationTo90Right")]
		public string RotationTo90Right()
		{
			return "O R.O.B.O está com braço direito com rotação de 90º";
		}

		[HttpGet("RotationTo90Left")]
		public string RotationTo90Left()
		{
			return "O R.O.B.O está com braço esquerdo com rotação de 90º";
		}




	}
}
