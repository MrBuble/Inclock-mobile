using System;
using System.Collections.Generic;
using System.Text;

namespace Inclock.BL.Inteface
{
    public interface IToast
    {
        void LongAlert(string Mensage);
        void ShortAlert(string Mensage);
    }
}
