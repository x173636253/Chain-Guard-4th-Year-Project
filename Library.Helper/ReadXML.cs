using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using Library.Helper.External.Models;

namespace Library.Helper
{
    public class ReadXML
    {
        public List<Entry> ReturnListOfRoles()
        {
            string XMLData = HttpContext.Current.Server.MapPath("~/App_Data/RankRoles.xml");

            DataSet ds = new DataSet();

            ds.ReadXml(XMLData);

            var Roles = new List<Entry>();

            Roles = (from rows in ds.Tables[0].AsEnumerable() 
                     select new Entry
                        {
                            RoleCode = Convert.ToInt32(rows[0].ToString()),
                            RoleName = rows[1].ToString(),
                            RoleAccess = rows[2].ToString()
                        }
                     ).ToList();

            return Roles;
        }
    }
}
