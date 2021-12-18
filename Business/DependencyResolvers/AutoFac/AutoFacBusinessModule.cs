using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdministratorManager>().As<IAdministratorService>().SingleInstance();
            builder.RegisterType<EfAdministratorDal>().As<IAdministratorDal>();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>().SingleInstance();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>().SingleInstance();

            builder.RegisterType<FacultyManager>().As<IFacultyService>().SingleInstance();
            builder.RegisterType<EfFacultyDal>().As<IFacultyDal>().SingleInstance();

            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();
            builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();

            builder.RegisterType<EfStaffDal>().As<IStaffDal>().SingleInstance();
            builder.RegisterType<StaffManager>().As<IStaffService>().SingleInstance();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<EfUserForStudentDal>().As<IUserForStudentDal>();
            builder.RegisterType<UserForStudentManager>().As<IUserForStudentService>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>().SingleInstance();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>().SingleInstance();

            builder.RegisterType<AuthAdminManager>().As<IAuthAdminService>().SingleInstance();
            builder.RegisterType<EfUserForAdminDal>().As<IUserForAdminDal>().SingleInstance();

            builder.RegisterType<AuthStaffManager>().As<IAuthStaffService>().SingleInstance();
            builder.RegisterType<EfUserForStaffDal>().As<IUserForStaffDal>().SingleInstance();

            builder.RegisterType<UserForStaffManager>().As<IUserForStaffService>().SingleInstance();

            builder.RegisterType<StudentFacultyManager>().As<IStudentFacultyService>().SingleInstance();
            builder.RegisterType<EfStudentFacultyDal>().As<IStudentFacultyDal>().SingleInstance();

            builder.RegisterType<EfStaffFacultyDal>().As<IStaffFacultyDal>().SingleInstance();
            builder.RegisterType<StaffFacultyManager>().As<IStaffFacultyService>().SingleInstance();

            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>().SingleInstance();

            builder.RegisterType<EfCourseStudentDal>().As<ICourseStudentDal>().SingleInstance();
            builder.RegisterType<CourseStudentManager>().As<ICourseStudentService>().SingleInstance();

            builder.RegisterType<CourseStaffManager>().As<ICourseStaffService>().SingleInstance();

            builder.RegisterType<EfCourseStaffDal>().As<ICourseStaffDal>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
