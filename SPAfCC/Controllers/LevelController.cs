namespace SPAfCC.Controllers
{
    using System.Web.Http;

    public class LevelController : ApiController
    {
        // GET api/level
        public string Get()
        {
            return "You just requested ALL the levels!";
        }

        // GET api/level/5
        public string Get(int id)
        {
            return string.Format("You requested level {0}", id);
        }

        // POST api/level
        public string Post([FromBody] string value)
        {
            return "You requested a level submission";
        }

        // PUT api/level/5
        public string Put(int id, [FromBody] string value)
        {
            return "You requested a level update";
        }

        // DELETE api/level/5
        public string Delete(int id)
        {
            return "You requested a level deletion";
        }
    }
}