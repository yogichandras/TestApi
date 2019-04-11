using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace KangPismanAPITest.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ViewUser Get()
        {
            var model = new List<ModelUser>();
            model.Add(new ModelUser
            {
                name = "Yogi",
                password = "1245",
                contact ="yogichandra",
                country = "Indonesia"
            });
            model.Add(new ModelUser
            {
                name = "Zaki",
                password = "1245",
                contact = "Zaki",
                country = "Uganda"
            });

            var view = new ViewUser();
            view.result = model;


            return view;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string username)
        {
            if (username == null)
                return "gagal";
            else
                return "sukses";


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
