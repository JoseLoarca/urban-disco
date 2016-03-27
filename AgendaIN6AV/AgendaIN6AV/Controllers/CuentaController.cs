﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaIN6AV.Controllers
{
    public class CuentaController : Controller
    {

        public DB_AGENDA db = new DB_AGENDA();
        // GET: Cuenta
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            var usr = db.Usuarios.FirstOrDefault(u => u.username == usuario.username && u.password == usuario.password);
            if(usr!=null){
                Session["nombreUsuario"] = usr.nombre;
                Session["idUsuario"] = usr.idUsuario;
                return VerificarSesion();
            }
            else
            {
                ModelState.AddModelError("", "Nombre de Usuario y/o Contraseña incorrectos.");
            }
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Usuario usuario)
        {
            if(ModelState.IsValid){
                var rol = db.Rols.FirstOrDefault(r => r.idRol == 2);
                usuario.Rol = rol;
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                ViewBag.mensaje = "El usuario " + usuario.nombre + " ha sido registrado con éxito!";
            }
            return View();
        }

        public ActionResult VerificarSesion()
        {
            if(Session["idUsuario"]!=null){
                return RedirectToAction("../Inicio/Index");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Remove("idUsuario");
            Session.Remove("nombreUsuario");
            return RedirectToAction("Login");
        }
    }
}