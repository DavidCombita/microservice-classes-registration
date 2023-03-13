using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace microservice_classes_registration.Controllers;

[ApiController]
[Route("students")]
public class StudentsController : ControllerBase{

    private readonly ILogger<StudentsController> _logger;

    public StudentsController(ILogger<StudentsController> logger){
        _logger = logger;
    }

    [HttpGet(Name = "testConnection")]
    public System.String testConnection(){
        return $"Test Connection {DateTime.Now.ToString("dd/MM/yy hh:mm:ss")}.";
    }

}