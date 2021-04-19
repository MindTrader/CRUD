using CRUDImplementation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDImplementation.Controllers
{
    public class HomeController : Controller
    {
        MVCTutorialEntities db = new MVCTutorialEntities();
        public ActionResult Index()
        {
            List<tblDepartment> DeptList = db.tblDepartments.ToList();

            ViewBag.ListOfDepartments = new SelectList(DeptList, "DepartmentId", "DepartmentName");

            return View();
        }

        public JsonResult GetStudentList()
        {
            List<StudentViewModel> StuList = db.tblStudents.Where(p => p.IsDeleted == false).Select(p => new StudentViewModel()
            {
                StudentId = p.StudentId,
                StudentName = p.StudentName,
                Email = p.Email,
                DepartmentName = p.tblDepartment.DepartmentName
            }).ToList();

            return Json(StuList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStudentById(int StudentId)
        {
            tblStudent model = db.tblStudents.Where(p => p.StudentId == StudentId).SingleOrDefault();

            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveDataInDatabase(StudentViewModel model)
        {
            bool result = false;
            try
            {
                tblStudent stu = model.StudentId > 0 ? db.tblStudents.SingleOrDefault(p => p.StudentId == model.StudentId && p.IsDeleted == false) : new tblStudent();

                stu.StudentName = model.StudentName;
                stu.Email = model.Email;
                stu.IsDeleted = false;
                stu.DepartmentId = model.DepartmentId;

                if (!(model.StudentId > 0))
                    db.tblStudents.Add(stu);

                db.SaveChanges();
                result = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public JsonResult DeleteStudentRecord(int StudentId)
        {
            bool result = false;
            tblStudent stu = db.tblStudents.SingleOrDefault(p => p.StudentId == StudentId && p.IsDeleted == false);

            if (stu != null)
            {
                stu.IsDeleted = true;
                db.SaveChanges();
                result = true;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}