using System;
using System.Collections.Generic;
using System.Text;

namespace Classes02t02
{
    class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double Convert(string currencyName1, double money, string currencyName2 =null)
        {
            if (currencyName1 == "ua")
            {
                if (currencyName2 == "usd")
                    return money / _usd;

                if (currencyName2 == "eur")
                    return money / _eur;
                
                if (currencyName2 == "rub")
                    return money / _rub;
            }
            if (currencyName2 == null)
            {
                if (currencyName1 == "usd")
                    return money * _usd;

                if (currencyName1 == "eur")
                    return money * _eur;

                if (currencyName1 == "rub")
                    return money * _rub;
            }
            return -1;
        }
    }

}
