using DTS_API.Context;
using DTS_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KaryawanController : ControllerBase
    {
        MyContext myContext;

        public KaryawanController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            var data = myContext.Karyawans.ToList();
            if (data == null)
            {
                return Ok(new { message = "Sukses mengambil data", 
                    StatusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses Mengambil data", 
                statusCode = 200, data = data });
        }
        //UPDATE
        [HttpPut]

        public IActionResult Put(int id, Karyawan karaywan)
        {
            var data = myContext.Karyawans.Find(id);
            data.name = karaywan.name;
            myContext.Karyawans.Update(data);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                return Ok(new { StatusCode = 200, 
                    message = "berhasil mengubah data" });
            }
            return BadRequest(new
            {
                StatusCode = 200,
                message = "gagal mengubah data"
            });
        }
        //CREATE
        [HttpPost]

        public IActionResult Post(Karyawan karyawan)
        {
            var data = myContext.Karyawans.Add(karyawan);
            
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                return Ok(new
                {
                    StatusCode = 200,
                    message = "berhasil menambah data"
                });
            }
            return BadRequest(new
            {
                StatusCode = 200,
                message = "gagal menambah data"
            });
        }
        //DELETE
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var data = myContext.Karyawans.Find(id);
            myContext.Karyawans.Remove(data);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                return Ok(new
                {
                    StatusCode = 200,
                    message = "berhasil menghapus data"
                });
            }
            return BadRequest(new
            {
                StatusCode = 200,
                message = "gagal menhapus data"
            });

        }
    }
}
