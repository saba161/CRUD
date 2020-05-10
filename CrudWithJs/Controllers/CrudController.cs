using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudWithJs.Dall;
using CrudWithJs.Views.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CrudWithJs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrudController : Controller
    {
        private ICrud _crud;

        public CrudController(ICrud ICrud)
        {
            _crud = ICrud;
        }

        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello from CrudController";
        }

        [HttpPost]
        public JsonResult Create([FromBody] University university)
        {
            var createRecord = _crud.Create(university);

            return Json(createRecord);
        }

        [HttpGet]
        [Route("read")]
        public JsonResult Read(int id)
        {
            var readRecord = _crud.Read(id);

            return Json(readRecord);
        }

        [HttpGet]
        [Route("update")]
        public JsonResult Update([FromBody] University university)
        {
            var updateRecord = _crud.Update(university);

            return Json(updateRecord);
        }

        [HttpGet]
        [Route("delete")]
        public JsonResult Delete(int id)
        {
            var deleteItem = _crud.Delete(id);

            return Json(deleteItem);
        }
    }
}

