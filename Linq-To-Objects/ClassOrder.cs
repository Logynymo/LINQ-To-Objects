using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_Objects
{
    [Table(Name = "Order")]
    class ClassOrder
    {
        private int _OrderID;
        private string _CustomerID;
        private int _EmployeeID;
        private DateTime _OrderDate;
        private DateTime _RequiredDate;
        private DateTime _ShippedDate;
        private int _ShipVia;
        private double _Freight;
        private string _ShipName;
        private string _ShipAddress;
        private string _ShipCity;
        private string _ShipRegion;
        private string _ShipPostalCode;
        private string _ShipCountry;

        public ClassOrder()
        {
            
        }

        [Column(IsPrimaryKey = true, Storage = "_OrderID")]
        public int OrderID
        {
            get { return _OrderID; }
            set
            {
                if (_OrderID != value)
                {
                    _OrderID = value;
                }
            }
        }

        [Column(Storage = "_CustomerID", DbType = "NChar(5)")]
        public string CustomerID
        {
            get { return _CustomerID; }
            set
            {
                if (_CustomerID != value)
                {
                    _CustomerID = value;
                }
            }
        }

        [Column(Storage = "_EmployeeID")]
        public int EmployeeID
        {
            get { return _EmployeeID; }
            set
            {
                if (_EmployeeID != value)
                {
                    _EmployeeID = value;
                }
            }
        }

        [Column(Storage = "_OrderDate")]
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set
            {
                if (_OrderDate != value)
                {
                    _OrderDate = value;
                }
            }
        }

        [Column(Storage = "_RequiredDate")]
        public DateTime RequiredDate
        {
            get { return _RequiredDate; }
            set
            {
                if (_RequiredDate != value)
                {
                    _RequiredDate = value;
                }
            }
        }

        [Column(Storage = "_ShippedDate")]
        public DateTime ShippedDate
        {
            get { return _ShippedDate; }
            set
            {
                if (_ShippedDate != value)
                {
                    _ShippedDate = value;
                }
            }
        }

        [Column(Storage = "_ShipVia")]
        public int ShipVia
        {
            get { return _ShipVia; }
            set
            {
                if (_ShipVia != value)
                {
                    _ShipVia = value;
                }
            }
        }

        [Column(Storage = "_Freight", DbType ="money")]
        public double Freight
        {
            get { return _Freight; }
            set
            {
                if (_Freight != value)
                {
                    _Freight = value;
                }
            }
        }

        [Column(Storage = "_ShipName")]
        public string ShipName
        {
            get { return _ShipName; }
            set
            {
                if (_ShipName != value)
                {
                    _ShipName = value;
                }
            }
        }

        [Column(Storage = "_ShipAddress")]
        public string ShipAddress
        {
            get { return _ShipAddress; }
            set
            {
                if (_ShipAddress != value)
                {
                    _ShipAddress = value;
                }
            }
        }

        [Column(Storage = "_ShipCity")]
        public string ShipCity
        {
            get { return _ShipCity; }
            set
            {
                if (_ShipCity != value)
                {
                    _ShipCity = value;
                }
            }
        }

        [Column(Storage = "_ShipRegion")]
        public string ShipRegion
        {
            get { return _ShipRegion; }
            set
            {
                if (_ShipRegion != value)
                {
                    _ShipRegion = value;
                }
            }
        }

        [Column(Storage = "_ShipPostalCode")]
        public string ShipPostalCode
        {
            get { return _ShipPostalCode; }
            set
            {
                if (_ShipPostalCode != value)
                {
                    _ShipPostalCode = value;
                }
            }
        }

        [Column(Storage = "ShipCountry")]
        public string ShipCountry
        {
            get { return _ShipCountry; }
            set
            {
                if (_ShipCountry != value)
                {
                    _ShipCountry = value;
                }
            }
        }
    }
}
