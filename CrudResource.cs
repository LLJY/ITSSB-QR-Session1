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
    public partial class CrudResource : Form
    {
        bool Update;
        /// <summary>
        /// Form for CRUD operations on resources.
        /// </summary>
        /// <param name="isUpdate"></param>
        /// <param name="id"></param>
        public CrudResource(bool isUpdate, int id = 0)
        {
            Update = isUpdate;
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask1 = getTypes();
            InitializeComponent();
            restype_combo.DataSource = await asynctask1;
            if (Update)
            {
                resname_box.Enabled = false;
                restype_combo.Enabled = false;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RMF = new ResourceManagementForm();
            RMF.Closed += (s, args) => this.Close();
            RMF.Show();
        }
        /// <summary>
        /// Adds a new resource and its allocation, depending on if the checkbox for the different skills are checked.
        /// </summary>
        /// <returns></returns>
        public async Task AddResource()
        {
            using (var db = new Session1Entities1()) {
                //need to add resource and RA entries.
                int resourceid = 1;
                try
                {
                    resourceid = (from x in db.Resources orderby x.resId descending select x.resId).First() + 1;
                }
                catch
                {
                    
                }
                var resource = new Resource()
                {
                    remainingQuantity = (int)numericUpDown1.Value,
                    resId = resourceid,
                    resName = resname_box.Text,
                    resTypeIdFK = restype_combo.SelectedIndex + 1
                };
                db.Resources.Add(resource);
                if (CS.Checked)
                {
                    //try catch because it might error if there are no results found(database does not contain any values by default)
                    try
                    {
                        //try getting the largest id +1 as entity framework does not support auto incrementing.
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    
                }
                if (SSB.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                }
                if(NSA.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                }
                if (WT.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = resourceid,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                }
                await db.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Incomplete update function.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task updateDatabase(int id)
        {
            using(var db = new Session1Entities1())
            {
                var res = (from r in db.Resources
                           where r.resId == id
                           select r).First();
                res.remainingQuantity = (int)numericUpDown1.Value;
                if (CS.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }

                }
                if (SSB.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                }
                if (NSA.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                }
                if (WT.Checked)
                {
                    try
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = (from x in db.Resource_Allocation orderby x.allocId descending select x.allocId).First() + 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                    catch
                    {
                        var ra = new Resource_Allocation()
                        {
                            allocId = 1,
                            resIdFK = res.resId,
                            skillIdFK = 1
                        };
                        db.Resource_Allocation.Add(ra);
                    }
                }
            }
        }
        public async Task<List<string>> getTypes()
        {
            using (var db = new Session1Entities1())
            {
                return (from s in db.Resource_Type
                        select s.resTypeName).ToList();
            }
        }
        /// <summary>
        /// done_button calls the method to add resources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void done_button_Click(object sender, EventArgs e)
        {
            if (!Update)
            {
                if(!(string.IsNullOrEmpty(resname_box.Text) && !CS.Checked && !SSB.Checked && !NSA.Checked && !WT.Checked))
                {
                    await AddResource();
                    MessageBox.Show("Done!");
                }
                else
                {
                    MessageBox.Show("One or more fields are empty!");
                }
            }
        }
    }
}
