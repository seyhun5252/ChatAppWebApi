using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChattApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("Add")]
        public IActionResult Add(int firstNumber, int secondNumber)
        {
            return Ok(firstNumber + secondNumber);
        }
        [HttpGet("Delete")]
        public IActionResult Delete(int firstNumber, int secondNumber)
        {
            return Ok(firstNumber - secondNumber);
        }
        [HttpGet("Multi")]
        public IActionResult Multi(int firstNumber, int secondNumber)
        {
            return Ok(firstNumber * secondNumber);
        }
        [HttpGet("Divide")]
        public IActionResult Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                return BadRequest("Sayı 0'a bölünemez");
            }
            return Ok(firstNumber / secondNumber);
        }
    }
}
