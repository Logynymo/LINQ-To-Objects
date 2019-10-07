using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_Objects
{
    [Table(Name = "Orders")]
    public class ClassOrder
    {
        private EntityRef<ClassCustomer> _Customer;

        private int _OrderID;
        private string _CustomerID;
        private int _EmployeeID;
        private DateTime? _OrderDate;
        private DateTime? _RequiredDate;
        private DateTime? _ShippedDate;
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
            this._Customer = new EntityRef<ClassCustomer>();
            //OrderID = 0;
        }

        [Column(IsPrimaryKey = true, Storage = "_OrderID", 
            DbType = "int NOT NULL IDENTITY", IsDbGenerated = true)]
        public int OrderID
        {
            get { return _OrderID; }
            
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
        [Association(Storage = "_Customer", ThisKey = "CustomerID")]
        public ClassCustomer Customer
        {
            get { return this._Customer.Entity; }
            set { this._Customer.Entity = value; }
        }

        [Column(Storage = "_EmployeeID", DbType = "int")]
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

        [Column(Storage = "_OrderDate", DbType = "datetime")]
        public DateTime? OrderDate
        {
            get { return _OrderDate.GetValueOrDefault(DateTime.Now); }
            set
            {
                if (_OrderDate != value)
                {
                    _OrderDate = value;
                }
            }
        }

        [Column(Storage = "_RequiredDate", DbType = "datetime")]
        public DateTime? RequiredDate
        {
            get { return _RequiredDate.GetValueOrDefault(); }
            set
            {
                if (_RequiredDate != value)
                {
                    _RequiredDate = value;
                }
            }
        }

        [Column(Storage = "_ShippedDate", DbType = "datetime")]
        public DateTime? ShippedDate
        {
            get { return _ShippedDate.GetValueOrDefault(); }
            set
            {
                if (_ShippedDate != value)
                {
                    _ShippedDate = value;
                }
            }
        }

        [Column(Storage = "_ShipVia", DbType = "int")]
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

        [Column(Storage = "_ShipName", DbType = "nvarchar(40)")]
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

        [Column(Storage = "_ShipAddress", DbType = "nvarchar(60)")] 
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

        [Column(Storage = "_ShipCity", DbType = "nvarchar(15)")]
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

        [Column(Storage = "_ShipRegion", DbType = "nvarchar(15)")]
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

        [Column(Storage = "_ShipPostalCode", DbType = "nvarchar(10)")]
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

        [Column(Storage = "_ShipCountry", DbType = "nvarchar(15)")]
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
