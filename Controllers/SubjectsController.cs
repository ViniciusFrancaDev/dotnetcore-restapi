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
        private readonly MockSubjectRepo _repository = new MockSubjectRepo();
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

            return Ok(subject);
        }
    }
}
