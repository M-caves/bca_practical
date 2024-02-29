using BCA_Practical.Helper;
using BCA_Practical.Model;
using BCA_Practicals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_Practical.BusinessLayer
{
    public class DistrictLayer
    {
        public List<DistrictInfo> GetAllDistrict()
        {
            var result = new List<DistrictInfo>();

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@DistrictID","")
            };
            DataTable dt = DAO.GetTable(@"select * from District where(IsNull(@DistrictID, '') = '' or DistrictID = @DistrictID)"
                                            , param
                                            , CommandType.Text);
            result = ClassToTable.ConvertDataTable<DistrictInfo>(dt).ToList();
            return result;
        }


        public DataTable AddUpdateDistrict(DistrictInfo model)
        {
            string query = "";
            if (model.DistrictID > 0)
            {
                query = @"
                        update district set districtName=@DistrictName, districtCode = @districtCode, provinceID=@provinceID
                        select id=@studentID, success = 1, message = 'update success'";
            }
            else // student id is 0
            {
                query = @"
                        insert into district(DistrictName,DistrictCode,ProvinceID) values (@districtName,@districtCode,@provinceID)
                        select id=@studentID, success = 1, message = 'insert success'";
            }
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                     new SqlParameter("@DistrictID",model.DistrictID),
                      new SqlParameter("@DistrictName",model.DistrictName),
                       new SqlParameter("@DistrictCode",model.DistrictCode),
                        new SqlParameter("@ProvinceID",model.ProvinceID),
                };
                return DAO.GetTable(query, param, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable DeleteStudent(int id)
        {
            var result = new StudentInfo();

            SqlParameter[] param = new SqlParameter[]
            {
                 new SqlParameter("@districtID",id)
            };
            return DAO.GetTable(@"delete from district where districtID = @districtID
			select success = 1, message = 'District Deleted Successfully'", param, CommandType.Text);
        }
    }
}
