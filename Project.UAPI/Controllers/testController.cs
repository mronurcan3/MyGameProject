using Project.UAPI.DTOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.UAPI.Controllers
{
    public class testController : ApiController
    {
        [HttpGet]
        public ShareDTO ListShare()
        {

            ShareDTO share = new ShareDTO()
            {
                ID = 1,
                Name = "test1",
                SharePrice = 500,
                ShareUnit = 300,
            };


            return share;

        }

    }
}
