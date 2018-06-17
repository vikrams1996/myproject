using System.Linq;
using System.Web.Mvc;
using mallform.Models;
using mallform.ViewModel;

namespace mallform.Controllers
{
    public class LeasingFormController : Controller
    {
        // GET: LeasingForm
        private ApplicationDbContext _context;

        public LeasingFormController()
        {

            _context = new ApplicationDbContext();
        }
        public ActionResult Form()
        {



            return View();
        }
        
        [HttpPost]
        public ActionResult Form(TenantFormViewModel Form)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", Form);

            }
            
                var tenant = new Tenant
            {
                    shopName = Form.shopName,
                    brandName = Form.brandName,
                    Address = Form.Address,
                    mobileNo = Form.mobileNo,
                    panNo = Form.panNo



                };

            var unit = new Unit
            {
                Size = Form.Size,
                Floor = Form.Floor,
                shopNo = Form.shopNo


            };



            _context.Tenant.Add(tenant);
            _context.Unit.Add(unit);

            _context.SaveChanges();

            
            return RedirectToAction("Index", "Home");
        }



            public ActionResult Update (int id)
        {

            

            return View(_context.Tenant.Find(id));
        }


        [HttpPost]

        public ActionResult Update (Tenant Model)
        {
         
            Tenant tenant = _context.Tenant.Where(m => m.Id == Model.Id).SingleOrDefault();
            if(tenant!=null)
            {

                _context.Entry(tenant).CurrentValues.SetValues(Model);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");

            }

            return View(Model);
        

        }

        public ActionResult Delete (int id)
        {

            _context.Tenant.Remove(_context.Tenant.Find(id));
            _context.SaveChanges();

            return RedirectToAction("Index" , "Home");

        }




    }
}



