﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAcessoDatos;

namespace CapaNegocio
{
    public class modeloUsuario
    {
       
        
        public bool LoginUsuario(string user, string pass)
        {
            usuarioDao userDao = new usuarioDao();
            return userDao.Login(user, pass);

        }

        public void insert()
        {
            mantenedores man = new mantenedores();
            man.insertarUsuario();
        }

        public DataSet listarUsuarios()
        {
            mantenedores man = new mantenedores();
            return man.listarUsuarios();
        }

        public void eliminarUser(int id)
        {
            mantenedores man = new mantenedores();
            man.eliminarUsuario(id);
        }

        public void updateCuenta(int id)
        {
            mantenedores man = new mantenedores();
            man.actualizarCuenta(id);
        }

        public void updateUser(int id)
        {
            mantenedores man = new mantenedores();
            man.actualizarUsuario(id);
        }

        public int idUser(int id)
        {
            mantenedores man = new mantenedores();
            man.rutUsuario();
            return (id);
            

        }
        public void insertCuenta()
        {
            mantenedores man = new mantenedores();
            man.insertarCuenta();
        }
    }
}
