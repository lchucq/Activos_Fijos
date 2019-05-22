using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using activosFijos.Code;

namespace ActivosFijos.Tests
{
    [TestClass]
    public class Test_Valid
    {
        private libGen _linGen;
        [TestInitialize]
        public void Inicializar()
        {
            _linGen = new libGen();
        }
        [TestMethod]
        public void email_isValid()
        {
            var mail = "l@gmail.com";
            var resultado =  _linGen.IsValidEmail(mail);
            ////el resultado devuelto debe ser verdadero con una cadena de email valido
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void email_inValid()
        {
            var mail = "lgmail.com";
            var resultado = _linGen.IsValidEmail(mail);
            ////el resultado devuelto debe ser verdadero con una cadena de email valido
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void pass_isValid()
        {
            var pass = "Abc.1234";
            var resultado = _linGen.IsValidPass(pass);
            ////el resultado devuelto debe ser verdadero con una cadena de Contraseña Válida
            Assert.IsTrue(resultado);
        }
        //Test para una contraseña INVALIDA
        [TestMethod]
        public void pass_invalid()
        {
            var pass = "Abc'124";
            var resultado = _linGen.IsValidEmail(pass);
            ////el resultado devuelto debe ser falso con una cadena que no corresponde a una contraseña
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void gen_UsuNOm()
        {
            var name = "Elmer Leonel Chúc";
            var resultado = _linGen.genUsu(name);
            string esp = "ELC";
            ////el resultado devuelto debe ser falso con una cadena que no corresponde a una contraseña
            Assert.AreEqual(esp,resultado);
        }

        [TestMethod]
        public void dev_mes()
        {
            var annMes = "2019-03";
            var resultado = _linGen.annMes(annMes);
            string esp = "Marzo del 2019";
            ////el resultado devuelto debe ser falso con una cadena que no corresponde a una contraseña
            Assert.AreEqual(esp, resultado);
        }
    }
}
