

using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Infrastructure.Core;
using itlagrupo_4.Infrastructure.@interface;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;
using itlagrupo_4.Infrastructure.context;
using itlagrupo_4.Infrastructure.Extentions;

namespace itlagrupo_4.Infrastructure.Repository
{
    public class EmployeesRepository: BaseRepository<class1>, IemployeeRepository
    {
        private readonly ILogger<EmployeesRepository> logger;
        private readonly EmployeeContext context;

        public EmployeesRepository(ILogger<EmployeesRepository> logger,
                                EmployeeContext context) : base(context)
        {
            this.logger = logger;
            this.context = context;
        }
        public override void Add(class1 entity)
        {

            if (this.Exists(cd => cd.emp_id == entity.emp_id))
                throw new EmployeeExtention("El curso ya existe.");

            base.Add(entity);
            base.SaveChanges();
        }

        public override void Update(Course entity)
        {
            try
            {
                Course courseToUpdate = base.GetEntity(entity.CourseID);

                if (courseToUpdate is null)
                    throw new CourseException("El curso no existe.");

                courseToUpdate.Credits = entity.Credits;
                courseToUpdate.DepartmentID = entity.DepartmentID;
                courseToUpdate.ModifyDate = DateTime.Now;
                courseToUpdate.Title = entity.Title;
                courseToUpdate.UserMod = entity.UserMod;

                base.Update(courseToUpdate);
                base.SaveChanges();

            }
            catch (Exception ex)
            {

                this.logger.LogError("Ocurrió un error actualizando el curso", ex.ToString());
            }
        }
        public override void Remove(Course entity)
        {
            try
            {
                Course courseToRemove = base.GetEntity(entity.CourseID);

                if (courseToRemove is null)
                    throw new CourseException("El curso no existe.");


                courseToRemove.Deleted = true;
                courseToRemove.DeletedDate = DateTime.Now;
                courseToRemove.UserDeleted = entity.UserDeleted;

                base.Update(courseToRemove);
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this.logger.LogError("Ocurrió un error actualizando el curso", ex.ToString());
            }
        }

        public List<CursoModel> GetCoursesByDepartment(int departmentId)
        {
            List<CursoModel> cursos = new List<CursoModel>();

            try
            {

                this.logger.LogInformation($"Pase por aqui: {departmentId}");

                cursos = (from cu in base.GetEntities()
                          join de in context.Departments.ToList() on cu.DepartmentID equals de.DepartmentID
                          where cu.DepartmentID == departmentId
                           && !cu.Deleted
                          select new CursoModel()
                          {
                              CourseId = cu.CourseID,
                              Credits = cu.Credits,
                              DeparmentName = de.Name,
                              DepartmentID = de.DepartmentID,
                              Title = cu.Title
                          }).ToList();


            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error obeteniendo los cursos: {ex.Message}", ex.ToString());
            }

            return cursos;
        }

        public List<CursoModel> GetCourses()
        {
            List<CursoModel> cursos = new List<CursoModel>();

            try
            {

                cursos = (from cu in base.GetEntities()
                          join de in context.Departments.ToList() on cu.DepartmentID equals de.DepartmentID
                          where !cu.Deleted
                          select new CursoModel()
                          {
                              CourseId = cu.CourseID,
                              Credits = cu.Credits,
                              DeparmentName = de.Name,
                              DepartmentID = de.DepartmentID,
                              Title = cu.Title
                          }).ToList();


            }
            catch (Exception ex)
            {

                this.logger.LogError($"Error obeteniendo los cursos: {ex.Message}", ex.ToString());
            }

            return cursos;
        }

        public CursoModel GetCourse(int courseId)
        {
            CursoModel cursoModel = new CursoModel();


            try
            {
                if (!base.Exists(cu => cu.CourseID == courseId))
                    throw new Exception("Curso no existe..");

                cursoModel = base.GetEntity(courseId).ConvertCourseEntityToModel();


            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo el curso", ex.ToString());
                throw new CourseException("Curso no existe..");
            }

            return cursoModel;
        }

    }
}
