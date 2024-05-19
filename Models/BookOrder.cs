using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookHaven.Models
{

    public class BookOrder
    {
        public string CustomerName { get; set; }

        public string BookType { get; set; }

        public bool GiftWrap { get; set; }

        public bool ExpressDelivery { get; set; }

        public int Qty { get; set; }

        public double BasicCost { get; set; }

        public double ExtraCost { get; set; }

        public double TotalCostSingle { get; set; }

        public double TotalCost { get; set; }

        public double VatDue { get; set; }

        public double FinalCost { get; set; }

        public double CalcBasicTotal()
        {
            double basic = 0.00;
            if (BookType == "Fiction")
            {
                basic = 150;
            }
            else if (BookType == "Non-Fiction")
            {
                basic = 200;
            }
            else if (BookType == "Comics")
            {
                basic = 100;
            }
            return basic;
        }

        public double CalcExtra()
        {
            double extra = 0.00;
            if (GiftWrap == true)
            {
                extra += 50;
            }
            if (ExpressDelivery == true)
            {
                extra += 30;
            }
            return extra;
        }

        public double CalcTotalCostSingle()
        {
            return CalcBasicTotal() * Qty;
        }

        public double CalcTotalCost()
        {
            return CalcTotalCostSingle() + CalcExtra();
        }

        public double CalcVatDue()
        {
            return CalcTotalCost() * 0.15;
        }

        public double CalcFinalCost()
        {
            return CalcTotalCost() + CalcVatDue();
        }
    }

}