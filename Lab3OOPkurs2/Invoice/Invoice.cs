using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    internal class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;
        private string _article;
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        private double _sum;
        public double Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }
        public Invoice(int account, string customer, string provider)
        {
            this._account = account;
            this._customer = customer;
            this._provider = provider;
        }

        public double tax()
        {
            double tax = 0;
            double sum = 0;
            Sum = sum;
            Random random = new Random();
            int price = 40;
            _quantity = _account / price;
            Article.ToLower();
            switch (Article)
            {
                case "1":
                    {
                        tax = 0.40;
                        sum = (price * _quantity) * tax;
                        break;
                    }
                case "2":
                    {
                        sum = price * _quantity;
                        break;
                    }
            }
            return sum;
        }

    }
}
