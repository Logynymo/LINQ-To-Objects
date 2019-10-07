using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Linq_To_Objects
{
    [Table(Name = "Customers")]
    public class ClassCustomer
    {
        private string _CustomerID;
        private string _CompanyName;
        private string _ContactName;
        private string _ContactTitle;
        private string _Address;
        private string _City;
        private string _Region;
        private string _Country;
        private string _Phone;
        private string _Fax;

        public ClassCustomer()
        {
            this._Orders = new EntitySet<ClassOrder>();
        }

        private EntitySet<ClassOrder> _Orders;
        [Association(Storage = "_Orders", OtherKey = "CustomerID")]

        public EntitySet<ClassOrder> Orders
        {
            get { return this._Orders; }
            set { this._Orders.Assign(value); }
        }


        [Column(IsPrimaryKey = true, Storage = "_CustomerID", DbType = "NChar(5)")]
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

        [Column(Storage = "_CompanyName")]
        public string CompanyName
        {
            get { return _CompanyName; }
            set
            {
                if (_CompanyName != value)
                {
                    _CompanyName = value;
                }
            }
        }

        [Column(Storage = "_ContactName")]
        public string ContactName
        {
            get { return _ContactName; }
            set
            {
                if (_ContactName != value)
                {
                    _ContactName = value;
                }
            }
        }
        [Column(Storage = "_ContactTitle")]
        public string ContactTitle
        {
            get { return _ContactTitle; }
            set
            {
                if (_ContactTitle != value)
                {
                    _ContactTitle = value;
                }
            }
        }

        [Column(Storage = "_Address")]
        public string Address
        {
            get { return _Address; }
            set
            {
                if (_Address != value)
                {
                    _Address = value;
                }
            }
        }

        [Column(Storage = "_City")]
        public string City
        {
            get { return _City; }
            set
            {
                if (_City != value)
                {
                    _City = value;
                }
            }
        }

        [Column(Storage = "_Region")]
        public string Region
        {
            get { return _Region; }
            set
            {
                if (_Region != value)
                {
                    _Region = value;
                }
            }
        }

        private string _PostalCode;
        [Column(Storage = "_PostalCode")]
        public string PostalCode
        {
            get { return _PostalCode; }
            set
            {
                if (_PostalCode != value)
                {
                    _PostalCode = value;
                }
            }
        }

        [Column(Storage = "_Country")]
        public string Country
        {
            get { return _Country; }
            set
            {
                if (_Country != value)
                {
                    _Country = value;
                }
            }
        }

        [Column(Storage = "_Phone")]
        public string Phone
        {
            get { return _Phone; }
            set
            {
                if (_Phone != value)
                {
                    _Phone = value;
                }
            }
        }

        [Column(Storage = "_Fax")]
        public string Fax
        {
            get { return _Fax; }
            set
            {
                if (_Fax != value)
                {
                    _Fax = value;
                }
            }
        }
    }
}
