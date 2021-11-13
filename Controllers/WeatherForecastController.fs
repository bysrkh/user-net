namespace user_net.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("[controller]")>]
type WeatherForecastController (logger : ILogger<WeatherForecastController>) =
    inherit ControllerBase()
    
    [<HttpGet>]
    member _.Get() =
        ActionResult<string>("Hello, STMIK IKMI Cirebon!")
