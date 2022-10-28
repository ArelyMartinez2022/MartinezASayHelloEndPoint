/*
ARELY MARTINEZ 
OCT 25 2022, 10:51 AM 
SAY HELLO END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN INPUT THIER NAME AND IT REPSOND 
GOOD MORNING THEN THIER NAME. THEY WOULD 
INPUT THROUGH POSTMAN LIKE 
OUTPUT: https://localhost:7119/input/HELLO/ARELY
OUTPUT: GOOD MORNING {ARELY}!!
PEER REVIEW: Maddie Gowan -- Runs as it should! 
I see no issues. It's written just as we were told 
to do it, and functions in postman
 */

 using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{

    [HttpGet]
    [Route("Hello")]
    //localHost9000/Input/Name
    public string SayHello()
    {
        return"Hello Whats Your Name? !";
    }

    [HttpGet]
    [Route("Hello/{name}")]
    //localHost9000/Input/Name
    public string SayHello(string name)
    {
        return$"Whats up {name}!";
    }
    
    //return$"This would be my return {var} "
}

