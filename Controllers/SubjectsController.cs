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

        [HttpGet("{id}", Name="GetSubjectById")]
        public ActionResult <SubjectReadDto> GetSubjectById(int id)
        {
            var subject = _repository.GetSubjectById(id);
            if (subject != null)
            {
                return Ok(_mapper.Map<SubjectReadDto>(subject));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult <SubjectReadDto> CreateSubject(SubjectCreateDto subjectCreateDto)
        {
            var subjectModel = _mapper.Map<Subject>(subjectCreateDto);
            _repository.CreateSubject(subjectModel);
            _repository.SaveChanges();

            var SubjectReadDto = _mapper.Map<SubjectReadDto>(subjectModel);

            return CreatedAtRoute(nameof(GetSubjectById), new {Id = SubjectReadDto.Id}, SubjectReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateSubject(int id, SubjectUpdateDto subjectUpdateDto)
        {
            var subjectModel = _repository.GetSubjectById(id);
            if (subjectModel == null)
            {
                return NotFound();
            }

            _mapper.Map(subjectUpdateDto, subjectModel);

            _repository.UpdateSubject(subjectModel);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
