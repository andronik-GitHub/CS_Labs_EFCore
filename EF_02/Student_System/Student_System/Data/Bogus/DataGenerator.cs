using Azure.Identity;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Student_System.Data.Models;
using Student_System.Data.Models.Enum;
using Student_System.Data.Models.Enums;

namespace Student_System.Data.Bogus
{
    public class DataGenerator
    {
        public static readonly List<Students> Students = new();
        public static readonly List<Courses> Courses = new();
        public static readonly List<Resources> Resources = new();
        public static readonly List<Homework> Homework = new();
        public static readonly List<StudentsCourses> StudentsCourses = new();

        public const int STUDENTS = 10;
        public const int COURSES = 10;
        public const int RESOURCES = 2;
        public const int HOMEWORK = 2;
        public const int STUDENT_COURSES = 2;


        private static Faker<Students> GetStudentGenerator()
        {
            // .OrNull(f, 0.2f) 20% generated values null
            return new Faker<Students>()
                .RuleFor(s => s.StudentId, _ => Guid.NewGuid())
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.PhoneNumber, f => f.Phone.PhoneNumber("#########"))
                .RuleFor(s => s.RegisteredOn, f => f.Random.Bool())
                .RuleFor(s => s.Birthday, f => f.Date.Past(10, DateTime.Now.AddYears(-17)).OrNull(f, 0.2f));
        }
        private static Faker<Courses> GetCourseGenerator()
        {
            // .OrNull(f, 0.2f) 20% generated values null
            return new Faker<Courses>()
                .RuleFor(c => c.CourseId, _ => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Commerce.ProductName())
                .RuleFor(c => c.Description, f => f.Commerce.ProductDescription().OrNull(f, 0.2f))
                .RuleFor(c => c.StartDate, f => f.Date.Past(5))
                .RuleFor(c => c.EndDate, f => f.Date.Past(0, DateTime.Now.AddYears(5)))
                .RuleFor(c => c.Price, f => f.Random.Decimal(75.0m, 350.0m));
        }
        private static Faker<Resources> GetResourceGenerator(Guid CourseId)
        {
            return new Faker<Resources>()
                .RuleFor(r => r.ResourceId, _ => Guid.NewGuid())
                .RuleFor(r => r.Name, f => f.Company.CompanyName())
                .RuleFor(r => r.Url, f => f.Internet.Url())
                .RuleFor(r => r.ResourceType, f => f.PickRandom<ResourceTypes>())
                .RuleFor(r => r.CourseId, _ => CourseId);
        }
        private static Faker<Homework> GetHomeworkGenerator(Guid CourseId, Guid StudentId)
        {
            return new Faker<Homework>()
                .RuleFor(h => h.HomeworkId, _ => Guid.NewGuid())
                .RuleFor(h => h.Content, f => f.Internet.Url())
                .RuleFor(h => h.ContentType, f => f.PickRandom<ContentTypes>())
                .RuleFor(h => h.SubmissionTime, f => f.Date.Between(DateTime.Now, DateTime.Now.AddMonths(1)))
                .RuleFor(h => h.CourseId, _ => CourseId)
                .RuleFor(h => h.StudentId, _ => StudentId);
        }
        private static Faker<StudentsCourses> GetStudentCourseGenerator(Guid CourseId, Guid StudentId)
        {
            return new Faker<StudentsCourses>()
                .RuleFor(sc => sc.CourseId, _ => CourseId)
                .RuleFor(sc => sc.StudentId, _ => StudentId);
        }
    

        private static List<Resources> GetBogusResourcesData(Guid CourseId)
        {
            Faker<Resources> resourcesGenerator = GetResourceGenerator(CourseId);
            List<Resources> generatorResources = resourcesGenerator.Generate(RESOURCES);

            return generatorResources;
        }
        private static List<Homework> GetBogusHomeworkData(Guid CourseId, Guid StudentId)
        {
            Faker<Homework> homeworkGenerator = GetHomeworkGenerator(CourseId, StudentId);
            List<Homework> generatorHomework = homeworkGenerator.Generate(HOMEWORK);

            return generatorHomework;
        }
        private static List<StudentsCourses> GetBogusStudentCourseData(Guid CourseId, Guid StudentId)
        {
            Faker<StudentsCourses> studentCourseGenerator = GetStudentCourseGenerator(CourseId, StudentId);
            List<StudentsCourses> generatorStudentCourse = studentCourseGenerator.Generate(1);

            return generatorStudentCourse;
        }

        public static void InitBogusData()
        {
            Students.AddRange(
                    GetStudentGenerator()
                    .Generate(STUDENTS)
                );

            Courses.AddRange(
                    GetCourseGenerator()
                    .Generate(COURSES)
                );

            for (int i = 0; i < RESOURCES; i++)
                Resources.AddRange(
                        GetBogusResourcesData(
                            Courses[new Random().Next(0, COURSES)].CourseId
                        )
                    );

            for (int i = 0; i < HOMEWORK; i++)
                Homework.AddRange(
                        GetBogusHomeworkData(
                            Courses[new Random().Next(0, COURSES)].CourseId,
                            Students[new Random().Next(0, STUDENTS)].StudentId
                        )
                    );

            for (int i = 0; i < STUDENT_COURSES; i++)
                StudentsCourses.AddRange(
                        GetBogusStudentCourseData(
                            Courses[new Faker().Random.Int(0, COURSES - 1)].CourseId,
                            Students[new Faker().Random.Int(0, STUDENTS - 1)].StudentId
                        )
                    );
        }

        public static List<Students> GetSeededStudentsFromDb(string sqlConnectionScting)
        {
            var builder = new DbContextOptionsBuilder<StudentSystemContext>();
            builder.UseSqlServer(sqlConnectionScting);


            using var dbContext = new StudentSystemContext(builder.Options);

            dbContext.Database.EnsureCreated();

            var students = dbContext.Students
                .Include(s => s.Homework)
                .Include(s => s.StudentsCourses)
                .ToList();

            return students;
        }
        public static List<Courses> GetSeededCoursesFromDb(string sqlConnectionScting)
        {
            var builder = new DbContextOptionsBuilder<StudentSystemContext>();
            builder.UseSqlServer(sqlConnectionScting);


            using var dbContext = new StudentSystemContext(builder.Options);

            dbContext.Database.EnsureCreated();

            var students = dbContext.Courses
                .Include(s => s.Resources)
                .Include(s => s.Homework)
                .Include(s => s.StudentsCourses)
                .ToList();

            return students;
        }
    }
}
