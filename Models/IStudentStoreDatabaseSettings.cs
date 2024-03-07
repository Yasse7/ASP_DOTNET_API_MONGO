namespace WebApi_Swagger.Models
{
    public interface IStudentStoreDatabaseSettings
    {
       public string StudentCoursesCollectionName { get; set; }  
        public string ConnectionString { get; set; }  

        public string DatabaseName { get; set; }  
    }
}
