using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//Run içerisine istediğimiz kadar parametre gönderebilmek için
        {
            foreach (var logic in logics)//Her bir iş kuralını gez
            {
                if (!logic.Success)//Başarısız olanı business'a gönderiyoruz.
                {
                    return logic;
                }

            }
            return null;
        }
    }
}
