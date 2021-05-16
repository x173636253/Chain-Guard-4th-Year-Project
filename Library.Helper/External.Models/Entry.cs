using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library.Helper.External.Models
{

    [Serializable]
    [XmlRoot("Entry"), XmlType("Entry")]

    public class Entry
    {
        public int RoleCode { get; set; }
        public string RoleName { get; set; }
        public string RoleAccess { get; set; }
    }
}
