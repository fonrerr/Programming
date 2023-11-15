using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discount
{
    public class PointsDiscount: IDiscount, IComparable<PointsDiscount>
    {
        private int _points;

        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value >= 0)
                {
                    _points = value;
                }
            }
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public double Calculate(List<Item> items)
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.Cost;
            }
            double total30 = total * 0.3;
            if (Points > total30)
            {
                return Math.Ceiling(total30);
            }
            return Points;
        }

        public double Apply(List<Item> items) 
        {
            double discount = Calculate(items);
            Points -= Convert.ToInt32(discount);
            return discount;
        }

        public void Update(List<Item> items) 
        {
            double total = 0.0;
            foreach (Item item in items) 
            {
                total += item.Cost;
            }
            Points += (int)(total / 10);
            if(total % 10 != 0)
            {
                Points += 1;
            }
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T?)"/>
        public int CompareTo(PointsDiscount other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.Points.CompareTo(other.Points);
        }
    }
}
