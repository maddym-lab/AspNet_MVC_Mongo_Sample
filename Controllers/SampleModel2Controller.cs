using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using AspNet_MVC_Mongo_Sample.Models;
using AspNet_MVC_Mongo_Sample.Services;
using System.Diagnostics;

namespace AspNet_MVC_Mongo_Sample.Controllers
{
    /*[ApiController]
    [Route("api/[controller]")]*/
    public class SampleModel2Controller : Controller
    {
        private readonly SampleModel2Svc _model2Service;

        public SampleModel2Controller(SampleModel2Svc model2Service)
        {
            _model2Service = model2Service;
        }

        public IActionResult SampleModel2()
        {
            List<SampleModel2> sampleModel2List = _model2Service.GetProposalList();
            return View(sampleModel2List);
        }

        public IActionResult Add(SampleModel2 sampleModel2)
        {
            _model2Service.Add(sampleModel2);
            Debug.Write("after tranaction..");
            return Redirect("Proposal");
        }

        public IActionResult CreateSampleModel2Form()
        {
            ViewData["Action"] = "Create";
            SampleModel2 emptyModel = new SampleModel2();
            return View(emptyModel);
        }


    }
}
