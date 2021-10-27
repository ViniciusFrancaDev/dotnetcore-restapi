using System.Collections.Generic;
using dotnetcore_restapi.Models;

namespace dotnetcore_restapi.Data
{
    public interface ISubjectRepo
    {
        bool SaveChanges();

        IEnumerable<Subject> GetSubjects();
        Subject GetSubjectById(int id);
        void CreateSubject(Subject subject);
        void UpdateSubject(Subject subject);
    }
}
