using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        //DEPENDENCY INJECTÝON
        private INoteService _noteService;
        public ToDoController(INoteService noteService)
        {
            _noteService = noteService;
        }

        //[HttpGet(Name = "GetAll")]
        //public List<Note> GetAll()
        //{
        //    var result = _noteService.GetAll();
        //    return result;
        //}


        //[HttpGet(Name = "GetById")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _noteService.GetById(id);
        //    if (result != null)
        //    {
        //        Ok(result);
        //    }
        //    return BadRequest();
        //}



        /*[HttpPost(Name = "Add")]
        public IActionResult Add(Note note)
        {
            _noteService.Add(note);
            return Ok();
        }
        */


        //[HttpPost(Name = "DeleteById")]
        //public IActionResult DeleteById(int id)
        //{
        //    var result = _noteService.DeleteById(id);
        //    if (result != null)
        //    {
        //        Ok(result);
        //    }
        //    return BadRequest();
        //}


        //[HttpPost(Name = "Update")]
        //public IActionResult Update(Note note)
        //{
        //    _noteService.Update(note);
        //    return Ok();
        //}


        /* public IActionResult GetByIdSelect(int id)
         {
             var result = _noteService.GetByIdSelect(id);
             if (result != null)
             {
                 Ok(result);
             }
             return BadRequest();

         } */

        [HttpGet(Name = "GetByStatus")]
        public IActionResult GetByStatus(bool Status)
        {
            var result = _noteService.GetByStatus(Status);
            if (result != null)
            {
                Ok(result);
            }
            return BadRequest();
        }


    }
}
