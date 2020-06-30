using System;
using System.Collections.Generic;
using System.Text;

namespace Classes02t04
{
    class Invoice
    {
        private int _account;
        private string _customer;
        private string _provider;// не понял какую информацию должно содержать это поле
        private string _article;
        private int _price;//добавил сам. по условию не указано, но я не пойму как без цены товара обойтись 
        private int _quantity;

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public string Article
        {
            set
            {
                _article = value;
                if (value == "book")
                    _price = 100;

                if (value == "phone")
                    _price = 3200;

                if (value == "table")
                    _price = 5500;
            }
        }

        public int Quantity
        {
            set
            {
                _quantity = value;
            }
        }

        public int GetOrderPrise()
        {
            return _price * _quantity;
        }
        
        public int GetOrderPriseWithTaxes(int tax)
        {
            return _price * _quantity + _price * _quantity * tax / 100;
        }
    }
}
