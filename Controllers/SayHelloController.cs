//Griffin Parker
//Say Hello - Endpoint
//October 28, 2022
//This program takes the user's name from the URL and returns some text greeting them
//Peer Review -Marcel R. The program ran smooth. Asked for a string which was my name, and said hello! The output after threw me off tho ;-; but it still was good!

//https://localhost:xxxx/SayHello/SayHello/{name}

using Microsoft.AspNetCore.Mvc;

namespace ParkerGSayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("SayHello/{name}")]
    public string SayHello(string name)
    {
        return $"Hello {name}! You are using me.";
    }
    }
