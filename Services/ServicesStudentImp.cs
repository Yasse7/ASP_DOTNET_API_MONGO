using WebApi_Swagger.Models;
using MongoDB.Driver;

namespace WebApi_Swagger.Services
{
    public class ServicesStudentImp : IServicesStudent
    {
        private readonly IMongoCollection<Student> _student;

        public ServicesStudentImp(IStudentStoreDatabaseSettings settings ,IMongoClient mongoclient) {
            var database = mongoclient.GetDatabase(settings.DatabaseName);
            _student = database.GetCollection<Student>(settings.StudentCoursesCollectionName);
        }
        public Student Create(Student student)
        {
            _student.InsertOne(student);
            return student; 
        }


        public Student Get(string id)
        {
            return _student.Find(student => student.id== id).FirstOrDefault();
        }

        public List<Student> Get()
        {
            return _student.Find(student=>true).ToList();
        }

        public void Remove(string id)
        {
            _student.DeleteOne(student => student.id == id);
        }

        public void Update(string id, Student student)
        {
            _student.ReplaceOne(student => student.id == id, student);
        }
    }
}
