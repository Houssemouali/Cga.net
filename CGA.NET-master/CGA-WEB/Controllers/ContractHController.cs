using Domain.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGA_WEB.Controllers
{
    public class ContractHController : Controller
    {
        // GET: ContractH
        public ActionResult Index()
        {
            var contrats = new RestClient("http://127.0.0.1:18080/cga-web/pidev/");
            var request = new RestRequest("contract", Method.GET);
            request.AddHeader("Content-type", "application/json");
            IRestResponse<List<contract>> contrat = contrats.Execute<List<contract>>(request);
            return View(contrat.Data);
        }

        // GET: ContractH/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContractH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContractH/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ContractH/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContractH/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ContractH/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContractH/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
