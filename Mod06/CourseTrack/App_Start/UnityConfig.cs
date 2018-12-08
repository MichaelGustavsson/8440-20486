using CourseTrack.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CourseTrack
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ICourseRepository, CourseRepository>();
            container.RegisterType<IInstructorRepository, InstructorRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}