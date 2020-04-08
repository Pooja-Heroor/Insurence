using Insurance.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Insurance.Controllers
{
    public class ValuesController : ApiController
    {
        InsurenceEntities db = new InsurenceEntities();

      
        [HttpGet]
        [Route("api/getcustomer")]
        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers.ToList();
        }

        [HttpPost]
        [Route("api/insertcustomer")]
        public IEnumerable<Customer> InsertCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return db.Customers.ToList();

        }

        [HttpGet]
        [Route("api/getvehicle")]
        public List<VehicleDetail> GetVehicle()
        {
            return db.VehicleDetails.ToList();
        }

        [HttpPost]
        [Route("api/vehicle")]
        public List<VehicleDetail> VehicleInsert(VehicleDetail detail)
        {
            db.VehicleDetails.Add(detail);
            db.SaveChanges();
            return db.VehicleDetails.ToList();
        }

       /* [HttpPost]
        [Route("api/Policy")]

        public PolicyDetail PlanInsert(PolicyDetail model)
        {
           
                db.PolicyDetails.Add(model);
                db.SaveChanges();
                return model;
        }*/

    }
}
