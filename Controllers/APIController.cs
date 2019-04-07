using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcdemo.Models;
using System.Text;

namespace mvcdemo.Controllers
{
    [Route("api/[controller]")]
    public class APIController : Controller
    {
        [HttpGet]
        public async Task<string> GetAsync()
        {
            StringBuilder x = new StringBuilder(DateTime.Now.ToString());
            await MyMethodAsync1S();
            x.Append(" -- " + DateTime.Now.ToString());
            await MyMethodAsync3S();
            x.Append(" -- " + DateTime.Now.ToString());
            return x.ToString();

        }
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return id;
        }


        public async Task MyMethodAsync1S()
        {

            var a = Task.Delay(1000);
            var b = Task.Delay(1000);
            var c = Task.Delay(1000);
            var d = Task.Delay(1000);
            var e = Task.Delay(2000);

            await a;
            await b;
            await c;
            await d;
            await e;
        }

        public async Task MyMethodAsync3S()
        {
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);

        }


    }
}
