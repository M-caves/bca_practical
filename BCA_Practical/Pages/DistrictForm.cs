using BCA_Practical.BusinessLayer;
using BCA_Practical.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_Practical.Pages
{
    public partial class DistrictForm : Form
    {
        DistrictLayer dl;
        public DistrictForm()
        {
            InitializeComponent();
            dl = new DistrictLayer();

            gvDistrict.AutoGenerateColumns = false;

            LoadAllDistrict();
        }

        void LoadAllDistrict()
         {
            string searchDistrictName = txtDistrictName.Text;
            string searchDistrictCode = txtDistrictCode.Text;

            List<DistrictInfo> allDistrict = dl.GetAllDistrict();
            allDistrict = allDistrict
                .Where(x => 
                        string.IsNullOrEmpty(searchDistrictName) || x.DistrictName.ToLower().Contains(searchDistrictName.ToLower()))
                .ToList();
            gvDistrict.DataSource = allDistrict;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAllDistrict();
        }
    }
}
