using System.Collections.Generic;
using dotnetcore_restapi.Models;

namespace dotnetcore_restapi.Data
{
    public class MockSubjectRepo : ISubjectRepo
    {
        public Subject GetSubjectById(int id)
        {
            return new Subject{Id=1, Name="Defence Against the Dark Arts",
                Summary="Introduction that will set the foundation for your magical education",
                Description="Class that taught students defensive techniques to defend against the Dark Arts"};
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return new List<Subject>
            {
                new Subject{Id=1, Name="Defence Against the Dark Arts",
                    Summary="Introduction that will set the foundation for your magical education",
                    Description="Class that taught students defensive techniques to defend against the Dark Arts"},
                new Subject{Id=2, Name="Herbology",
                    Summary="Introduction of different elements of the field of herbology",
                    Description="Study of magical plants and how to take care of, utilise and combat them"},
                new Subject{Id=3, Name="Potions",
                    Summary="Art of creating mixtures with magical effects",
                    Description="Provides an introduction to potions and potioneering"}
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreateSubject(Subject subject)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSubject(Subject subject)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteSubject(Subject subject)
        {
            throw new System.NotImplementedException();
        }
    }
}
