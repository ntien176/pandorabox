using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseIO2;
using Data_Provider;
namespace PandoraWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //DBIO db = new DBIO();
            //Tra ve mot danh sach
            //List<we_users> list = db.GetList_Users();
            //we_users u = db.GetObject_User("ntien176", "123456");
            //return View(u);

            //return View(list);
            //if (Session["user"] == null)
            //{
            //    Response.Redirect("https://localhost:44310/tim-manh-kieu");
            //}
            //else
            //{
            //    we_users user = (we_users)Session["user"];
            //    ViewBag.NAME = user.Fullname;
            //}
            return View();
        }

        /// <summary>
        /// Kiem tra dang nhap ban AJA
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle1(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);

        }

        /// <summary>
        /// CHECK PUZZLE 2
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle2(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// CHECK PUZZLE 3
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle3(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 4
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle4(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// CHECK PUZZLE 5
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle5(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 6
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle6(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 7
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle7(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 8
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle8(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 9
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle9(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 10
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle10(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// CHECK PUZZLE 11
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CheckPuzzle11(FormCollection collection)
        {
            string uid = collection["uid"];
            string pwd = collection["pass"];
            JsonResult jr = new JsonResult();
            DBIO db = new DBIO();
            we_users u = db.GetObject_UserByUsername(uid);
            if (u == null)
            {
                jr.Data = new
                {
                    status = "F"
                };
            }
            else
            {
                if (u.Pwd == pwd)
                {
                    jr.Data = new
                    {
                        status = "OK"
                    };
                }
                else
                {
                    jr.Data = new
                    {
                        status = "F"
                    };
                }
            }
            return Json(jr, JsonRequestBehavior.AllowGet);
        }

    }
}