using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class ResourceManagementForm : Form
    {
        List<ResourceManagement> dgvlist;
        public ResourceManagementForm()
        {
            Initialize();
        }
        public async void Initialize()
        {
            var dbtask = GetResources();
            var asyctask2 = getSkills();
            var asynctask3 = GetType();
            InitializeComponent();
            dgvlist = await dbtask;
            //typecombo.DataSource = await asyctask2;
            //skillcombo.DataSource = await asynctask3;
            ReloadDGV();
        }
        public async void ReloadDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dgvlist;
        }
        public async Task<List<ResourceManagement>> GetResources(string typefilter = null)
        {
            var returnlist = new List<ResourceManagement>();
            using (var db = new Session1Entities())
            {
                var resources = (from r in db.Resources
                                 join rt in db.Resource_Type on r.resTypeIdFK equals rt.resTypeId
                                 select new { r, rt }).ToList();
                if (typefilter != null)
                {
                    resources = (from r in resources
                                 where r.rt.resTypeName == typefilter
                                 select r).ToList();
                }
                foreach (var item in resources)
                {
                    var skills = (from ra in db.Resource_Allocation
                                  where ra.resIdFK == item.r.resId
                                  select ra.Skill.skillName).ToList();
                    string allc = "Nil";
                    string quantity = "Not Available";
                    int noSkills = 0;
                    if (skills.Count > 0) 
                    {
                        allc = "";
                        foreach (var a in skills)
                        {
                            noSkills++;
                            allc += $", {a}";
                        }
                    }
                    if(item.r.remainingQuantity > 5)
                    {
                        quantity = "Sufficient";
                    }else if(item.r.remainingQuantity < 5 && item.r.remainingQuantity > 1)
                    {
                        quantity = "Low Stock";
                    }
                    returnlist.Add(
                        new ResourceManagement()
                        {
                            ID = item.r.resId,
                            Name = item.r.resName,
                            Type = item.rt.resTypeName,
                            NoSkills = noSkills,
                            AllocatedSkills = allc,
                            AvailableQuantity = quantity
                        });
                }
            }
            return returnlist;
        }
        public async Task<List<string>> getType()
        {
            using(var db = new Session1Entities())
            {
                return (from s in db.Resource_Type
                        select s.resTypeName).ToList();
            }
        }
        public async Task<List<string>> getSkills()
        {
            using (var db = new Session1Entities())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class ResourceManagement
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public int NoSkills { get; set; }
            public string AllocatedSkills { get; set; }
            public string AvailableQuantity { get; set; }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CR = new CrudResource(false);
            CR.Closed += (s, args) => this.Close();
            CR.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CR = new CrudResource(true);
            CR.Closed += (s, args) => this.Close();
            CR.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LP = new LoginPage();
            LP.Closed += (s, args) => this.Close();
            LP.Show();
        }
    }
}
