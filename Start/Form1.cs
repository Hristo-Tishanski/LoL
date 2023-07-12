using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Start
{



    public partial class Form1 : Form
    {



        public static List<Champions> ChampionsList = new List<Champions>();

        public static List<Roles> RolesList = new List<Roles>();

        public static List<Roles> RegionsList = new List<Roles>();

        public static List<Roles> ReleaseDateList = new List<Roles>();

        public static List<Roles> ClassesList = new List<Roles>();

        public static List<Roles> AlphabeticalList = new List<Roles>();

        public Form1()
        {
            InitializeComponent();
            DataInitializationRoles();
            DataInitializationRegions();
            DataInitializationAlphabetical();
            DataInitializationClasses();
            DataInitializationReleaseDates();
            CenterToScreen();

            gameTitle.Text = "League Of Legends";
            gameTitle.Font = new Font("Arial", 30);
            gameTitle.Show();
        }

        public void DataInitializationRoles()
        {
            foreach (var role in Data.allRoles)
            {
                RolesList.Add(new Roles(role, RolesList.Count));
            }

            foreach (var champ in Data.allChampionRoles)
            {
                ChampionsList.Add(new Champions(champ.Split("-")[1]));
            }

            RolesList.ForEach(r =>
            {
                foreach (var champ in Data.allChampionRoles)
                {
                    var role = champ.Split("-")[0];

                    if (role == r.Name)
                    {
                        r.Champions.Add(ChampionsList.FirstOrDefault(z => z.Name == champ.Split("-")[1]));
                    }
                }
            });
        }
        public void DataInitializationRegions()
        {
            foreach (var role in Data.allRegions)
            {
                RegionsList.Add(new Roles(role, RegionsList.Count));
            }

            foreach (var champ in Data.allChampionRegions)
            {
                ChampionsList.Add(new Champions(champ.Split("-")[1]));
            }

            RegionsList.ForEach(r =>
            {
                foreach (var champ in Data.allChampionRegions)
                {
                    var role = champ.Split("-")[0];

                    if (role == r.Name)
                    {
                        r.Champions.Add(ChampionsList.FirstOrDefault(z => z.Name == champ.Split("-")[1]));
                    }
                }
            });

        }
        public void DataInitializationReleaseDates()
        {
            foreach (var role in Data.releaseDates)
            {
                ReleaseDateList.Add(new Roles(role, ReleaseDateList.Count));
            }

            foreach (var champ in Data.allChampionReleaseDates)
            {
                ChampionsList.Add(new Champions(champ.Split("-")[1]));
            }

            ReleaseDateList.ForEach(r =>
            {
                foreach (var champ in Data.allChampionReleaseDates)
                {
                    var role = champ.Split("-")[0];

                    if (role == r.Name)
                    {
                        r.Champions.Add(ChampionsList.FirstOrDefault(z => z.Name == champ.Split("-")[1]));
                    }
                }
            });
        }
        public void DataInitializationClasses()
        {
            foreach (var role in Data.allClasses)
            {
                ClassesList.Add(new Roles(role, ClassesList.Count));
            }

            foreach (var champ in Data.allChampionClasses)
            {
                ChampionsList.Add(new Champions(champ.Split("-")[1]));
            }

            ClassesList.ForEach(r =>
            {
                foreach (var champ in Data.allChampionClasses)
                {
                    var role = champ.Split("-")[0];

                    if (role == r.Name)
                    {
                        r.Champions.Add(ChampionsList.FirstOrDefault(z => z.Name == champ.Split("-")[1]));
                    }
                }
            });
        }
        public void DataInitializationAlphabetical()
        {
            foreach (var role in Data.alphabet)
            {
                AlphabeticalList.Add(new Roles(role, AlphabeticalList.Count));
            }

            foreach (var champ in Data.allChampionsAlphabetically)
            {
                ChampionsList.Add(new Champions(champ.Split("-")[1]));
            }

            AlphabeticalList.ForEach(r =>
            {
                foreach (var champ in Data.allChampionsAlphabetically)
                {
                    var role = champ.Split("-")[0];

                    if (role == r.Name)
                    {
                        r.Champions.Add(ChampionsList.FirstOrDefault(z => z.Name == champ.Split("-")[1]));
                    }
                }
            });
        }


        private void roles_Click(object sender, EventArgs e)
        {
            FrmRoles frmroles = new();



            var sorted = RolesList.OrderBy(s => s.SortIndex);

            foreach (var item in sorted)
            {
                frmroles.treeView1.Nodes.Add(item.Name);

                item.Champions.ForEach(c => frmroles.treeView1.Nodes[frmroles.treeView1.Nodes.Count - 1].Nodes.Add(c.Name));
            }



            frmroles.BackColor = Color.DarkBlue;
            frmroles.treeView1.CollapseAll();

            frmroles.treeView1.ForeColor = Color.White;
            frmroles.treeView1.BackColor = Color.Black;


            frmroles.Show();
        }
        private void region_Click(object sender, EventArgs e)
        {
            FrmRoles frmroles = new();

            frmroles.Text = "Regions";

            var sorted = RegionsList.OrderBy(s => s.SortIndex);

            foreach (var item in sorted)
            {
                frmroles.treeView1.Nodes.Add(item.Name);

                item.Champions.ForEach(c => frmroles.treeView1.Nodes[frmroles.treeView1.Nodes.Count - 1].Nodes.Add(c.Name));
            }



            frmroles.BackColor = Color.DarkBlue;
            frmroles.treeView1.CollapseAll();


            frmroles.Show();
        }

        private void releaseDate_Click(object sender, EventArgs e)
        {
            FrmRoles frmroles = new();

            frmroles.Text = "ReleaseDates";

            var sorted = ReleaseDateList.OrderBy(s => s.SortIndex);

            foreach (var item in sorted)
            {
                frmroles.treeView1.Nodes.Add(item.Name);

                item.Champions.ForEach(c => frmroles.treeView1.Nodes[frmroles.treeView1.Nodes.Count - 1].Nodes.Add(c.Name));
            }



            frmroles.BackColor = Color.DarkBlue;
            frmroles.treeView1.CollapseAll();
            frmroles.Show();
        }

        private void championClass_Click(object sender, EventArgs e)
        {
            FrmRoles frmroles = new();

            frmroles.Text = "Classes";

            var sorted = ClassesList.OrderBy(s => s.SortIndex);

            foreach (var item in sorted)
            {
                frmroles.treeView1.Nodes.Add(item.Name);

                item.Champions.ForEach(c => frmroles.treeView1.Nodes[frmroles.treeView1.Nodes.Count - 1].Nodes.Add(c.Name));
            }



            frmroles.BackColor = Color.DarkBlue;
            frmroles.treeView1.CollapseAll();


            frmroles.Show();
        }

        private void alphabetically_Click(object sender, EventArgs e)
        {
            FrmRoles frmroles = new();

            frmroles.Text = "Alphabetically";

            var sorted = AlphabeticalList.OrderBy(s => s.SortIndex);

            foreach (var item in sorted)
            {
                frmroles.treeView1.Nodes.Add(item.Name);

                item.Champions.ForEach(c => frmroles.treeView1.Nodes[frmroles.treeView1.Nodes.Count - 1].Nodes.Add(c.Name));
            }



            frmroles.BackColor = Color.DarkBlue;
            frmroles.treeView1.CollapseAll();


            frmroles.Show();

        }
    }
}

