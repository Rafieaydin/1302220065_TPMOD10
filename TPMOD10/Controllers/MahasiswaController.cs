using Microsoft.AspNetCore.Mvc;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TPMOD10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mhs = new List<Mahasiswa> {
            new Mahasiswa { id  =  1, Nama = "",Nim="",Year=0 },
            new Mahasiswa { id = 2, Nama = "", Nim = "", Year = 0 },
            new Mahasiswa { id = 3, Nama = "", Nim = "", Year = 0 }
        };
        
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa GetById(int id)
        {
            for (int i = 0; i < mhs.Count; i++)
            {
                if (mhs[i].id == id) 
                {
                    return mhs[i];
                }
            }
            return null;
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
           mhs.Add(value);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            int idx = 0;
            for (int i = 0; i < mhs.Count; i++)
            {
                if (mhs[i].id == id)
                {
                   idx = i;
                }
            }
            mhs[idx] = value;
            return ;

        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Mahasiswa idx = null;
            for (int i = 0; i < mhs.Count; i++)
            {
                if (mhs[i].id == id)
                {
                    idx = mhs[i];
                }
            }
            mhs.Remove(idx);
        }
    }
}
