using WebApi_Swagger.Models;

namespace WebApi_Swagger.Services
{
    public interface IServicesStudent
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id,Student student);
        void Remove(string id);



    }
}
