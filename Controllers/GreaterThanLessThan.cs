//Isaiah Keith Ferguson
//10/25/2022
//Greater Than or Less than
//The user will input 2 numbers and the program will determine if one number is greater than less than or equal.
//Reviewed by: Jasmine Leek - really nice work! API runs the program as intended for all conditions tested. Errors generated properly!


using Microsoft.AspNetCore.Mvc;

namespace FergusonIGreaterThanLessThanEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessThanController : ControllerBase
{

    [HttpGet]
    [Route("GreaterThanorLessThan/{num1}/{num2}")]
    public string GreaterThanOrLessThan(string num1, string num2)
    {
        double Validnum = 0;
        double Validnum2 = 0;
        bool Truth = true;
        bool Truth2 = true;

        Truth = double.TryParse(num1, out Validnum);
        Truth2 = double.TryParse(num2, out Validnum2);

        if (Truth == true && Truth2 == true)
        {
            if (Validnum > Validnum2)
            {
                return $"{Validnum} is greater than {Validnum2} \n{Validnum2} is Less than {Validnum}";
            }
            else if (Validnum < Validnum2)
            {
                return $"{Validnum} is Less than {Validnum2} \n{Validnum2} is greater than {Validnum}";
            }
            else
            {
                return $"{Validnum} Is equal too {Validnum2}";
            }
        }
        else
        {
            return "Error: \nThose were not numbers!";
        }
    }

}