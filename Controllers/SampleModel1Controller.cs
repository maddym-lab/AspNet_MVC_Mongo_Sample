using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using AspNet_MVC_Mongo_Sample.Models;
using AspNet_MVC_Mongo_Sample.Services;
using System.Diagnostics;

namespace AspNet_MVC_Mongo_Sample.Controllers
{
    /*
    [ApiController]
    [Route("api/[controller]")]
    */
    public class SampleModel1Controller : Controller
    {
        private readonly SampleModel1Svc _model1Service;
        public SampleModel1Controller(SampleModel1Svc model1Service)
        {
            _model1Service = model1Service;
        }
        public IActionResult SampleModel1()
        {
            List<SampleModel1> sampleModel1List = _model1Service.GetAll();
            return View(sampleModel1List);
        }

        public IActionResult AddSampleModel1(SampleModel1 sampleModel1)
        {
            _model1Service.AddSampleModel1(sampleModel1);
            Debug.Write("after tranaction..");
            return Redirect("SampleModel1");
        }

        public IActionResult CreateSampleModel1Form()
        {
            ViewData["Action"] = "Create";
            SampleModel1 emptyModel = new SampleModel1();
            return View(emptyModel);
        }

    }
}
