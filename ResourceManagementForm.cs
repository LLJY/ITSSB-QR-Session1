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
        /// <summary>
        /// Initialize function to call functions asynchronously before InitializeComponent()
        /// </summary>
        public async void Initialize()
        {
            var dbtask = GetResources();
            var asynctask2 = GetSkills();
            var asynctask3 = GetType();
            InitializeComponent();
            dgvlist = await dbtask;
            var ds2 = await asynctask2;
            var ds1 = await asynctask3;
            ds1.Add("None");
            ds2.Add("None");
            type_combo.DataSource = ds1;
            skillcombo.DataSource = ds2;
            type_combo.SelectedItem = "None";
            skillcombo.SelectedItem = "None";
        }
        /// <summary>
        /// Sets datagridview's Data Source as null and then the default list of objects to force a reload.
        /// Also calls the get resources function.
        /// </summary>
        public async void ReloadDGV()
        {
            string skill;
            string type;
            try
            {
                if (skillcombo.SelectedItem.ToString() == "None")
                {
                    skill = null;
                }
                else
                {
                    skill = skillcombo.SelectedItem.ToString();
                }
                if (type_combo.SelectedItem.ToString() == "None")
                {
                    type = null;
                }
                else
                {
                    type = type_combo.SelectedItem.ToString();
                }
                var asynctask = GetResources(type, skill);
                dataGridView1.DataSource = null;
                dgvlist = await asynctask;
                dataGridView1.DataSource = dgvlist;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Not Available")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// Get Resources from database to fill the default list, which will then be used to populate the datagridview.
        /// </summary>
        /// <param name="typefilter">
        /// parameter to filter by type.
        /// </param>
        /// <returns></returns>
        public async Task<List<ResourceManagement>> GetResources(string typefilter = null, string skillfilter = null)
        {
            var returnlist = new List<ResourceManagement>();
            using (var db = new Session1Entities1())
            {
                var resources = (from r in db.Resources
                                 join rt in db.Resource_Type on r.resTypeIdFK equals rt.resTypeId
                                 select new { r, rt}).ToList();
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
                    if (skillfilter != null)
                    {
                        if (skills.Contains(skillfilter))
                        {
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
                    else
                    {
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
            }
            return returnlist;
        }
        public async Task<List<string>> GetType()
        {
            using(var db = new Session1Entities1())
            {
                return (from s in db.Resource_Type
                        select s.resTypeName).ToList();
            }
        }
        public async Task<List<string>> GetSkills()
        {
            using (var db = new Session1Entities1())
            {
                return (from s in db.Skills
                        select s.skillName).ToList();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadDGV();
        }
        private void Skillcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadDGV();
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
