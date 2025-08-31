using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Asenjo_2025b2.classes
{
    class Erro
    {
        private static String msg;
        private static bool erro;

        public static void setMsg(String _msg)
        {
            erro = true;
            msg = _msg;
        }
        public static void setErro(bool _erro) { erro = _erro; }
        public static String getMsg() { return msg; }
        public static bool getErro() { return erro; }
    }
}

