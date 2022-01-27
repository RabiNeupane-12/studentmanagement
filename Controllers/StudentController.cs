using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
public class StudentController : Controller
{
    private SMSContext db;
    public StudentController(SMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        var students = db.Students.ToList();


        return View(students);
    }
    public ActionResult Detail(int id)
    {
        var students = db.Students.Find(id);
        return View(students);
    }
    public ActionResult Add()

    {
        return View();
    }
    [HttpPost]
    public ActionResult Add(Person person)
    {
        db.Students.Add(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public ActionResult Edit(int id)
    {
        var students = db.Students.Find(id);
        return View();
    }
    [HttpPost]
    public ActionResult Edit(Person student)
    {
        db.Students.Attach(student);
        db.Students.Update(student);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
     public ActionResult Delete(int id)
    {
        var students = db.Students.Find(id);
        return View();
    }
    [HttpPost]
    public ActionResult Delete(Person student)
    {
         db.Students.Attach(student);
        db.Students.Remove(student);
        
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}


