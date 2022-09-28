using Service;
using Microsoft.AspNetCore.Mvc;
namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FourFunctionController:ControllerBase
    {
        private readonly FourFunction _fourFunction;
        public FourFunctionController(FourFunction fourFunction)
        {
            _fourFunction = fourFunction;
        }
        [HttpGet()]
        [Route("/Add")]
        public ActionResult<double> Add(double var1, double var2)
        {
            return Ok(_fourFunction.Add(var1, var2));
        }
        [HttpGet()]
        [Route("/Subtract")]
        public ActionResult<double> Subtract(double var1,double var2)
        {
            return Ok(_fourFunction.Add(var1,var2*-1));
        }
        [HttpGet()]
        [Route("/Multiply")]
        public ActionResult<double> Multiply(double var1,double var2)
        {
            return Ok(_fourFunction.Multiply(var1,var2));
        }
        [HttpGet()]
        [Route("/Divide")]
        public ActionResult<double> Divide(double var1,double var2)
        {
            return Ok(_fourFunction.Divide(var1,var2));
        }
    }
}
