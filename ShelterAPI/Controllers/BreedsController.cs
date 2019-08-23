using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShelterAPI.Models;
using ShelterAPI.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace ShelterAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BreedsController : ControllerBase
    {
        private ShelterAPIContext _db = new ShelterAPIContext();

        // GET api/breeds
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<Breed>> Get()
        {
            return _db.Breeds.ToList();
        }

        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        public void Post([FromBody] Breed breed)
        {
            _db.Breeds.Add(breed);
            _db.SaveChanges();
        }

        // PUT api/breeds/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Breed breed)
        {
            breed.BreedId = id;
            _db.Entry(breed).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var breedToDelete = _db.Breeds.FirstOrDefault(x => x.BreedId == id);
            _db.Breeds.Remove(breedToDelete);
            _db.SaveChanges();
        }
    }
}