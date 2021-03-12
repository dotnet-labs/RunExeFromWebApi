using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            using var process = new Process
            {
                StartInfo =
                {
                    FileName = @"..\HelloWorld\bin\Debug\helloworld.exe",
                    Arguments = $"{id}",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };
            //process.StartInfo.FileName = @"cmd.exe";
            //process.StartInfo.Arguments = @"/c dir";      // print the current working directory information

            process.OutputDataReceived += (_, data) => Console.WriteLine(data.Data);
            process.ErrorDataReceived += (_, data) => Console.WriteLine(data.Data);
            Console.WriteLine("starting");
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            var exited = process.WaitForExit(1000 * 10);     // (optional) wait up to 10 seconds
            Console.WriteLine($"exit {exited}");

            return "value";
        }
    }
}
