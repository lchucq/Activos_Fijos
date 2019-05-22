using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using activosFijos.Code;

namespace ActivosFijos.Tests
{
    [TestClass]
    public class Test_Mail
    {
        private envMail _mail;
        [TestInitialize]
        public void Inicializar()
        {
            _mail = new envMail();
        }
        [TestMethod]
        public void enviarMail()
        {
            var resultado =  _mail.sendPass(1, "lchucq@gmail.com", "Abd.1234", "002EC", "Elmer Chúc");
            ////el resultado devuelto debe ser verdadero
            //con la comparacion de la siguiente frase "Credenciales Enviadas."
            Assert.IsTrue("Email enviado." == resultado);
        }
        [TestMethod]
        public void enviarMailFail()
        {
            var resultado = _mail.sendPass(1, "lchucqgmail.com", "Abd.1234", "002EC", "Elmer Chúc");
            ////el resultado devuelto debe ser verdadero
            //con la comparacion de la siguiente frase "Credenciales Enviadas."
            Assert.IsFalse("Email enviado." == resultado);
        }
    }
}
