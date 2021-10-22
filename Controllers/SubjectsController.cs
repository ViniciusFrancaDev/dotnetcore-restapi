using System.Collections.Generic;
using AutoMapper;
using dotnetcore_restapi.Data;
using dotnetcore_restapi.Dtos;
using dotnetcore_restapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_restapi.Controllers
{
    [Route("api/v1/subjects")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectRepo _repository;
        private readonly IMapper _mapper;

        public SubjectsController(ISubjectRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<SubjectReadDto>> GetAllSubjects()
        {
            var subjects = _repository.GetSubjects();

            return Ok(_mapper.Map<IEnumerable<SubjectReadDto>>(subjects));
        }

        [HttpGet("{id}")]
        public ActionResult <SubjectReadDto> GetSubjectById(int id)
        {
            var subject = _repository.GetSubjectById(id);
            if (subject != null)
            {
                return Ok(_mapper.Map<SubjectReadDto>(subject));
            }
            return NotFound();
        }
    }
}
