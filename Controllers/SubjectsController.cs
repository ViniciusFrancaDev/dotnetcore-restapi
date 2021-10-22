using System.Collections.Generic;
using dotnetcore_restapi.Data;
using dotnetcore_restapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_restapi.Controllers
{
    [Route("api/v1/subjects")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectRepo _repository;

        public SubjectsController(ISubjectRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Subject>> GetAllSubjects()
        {
            var subjects = _repository.GetSubjects();

            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public ActionResult <Subject> GetSubjectById(int id)
        {
            var subject = _repository.GetSubjectById(id);
            if (subject != null)
            {
                return Ok(subject);
            }
            return NotFound();
        }
    }
}
