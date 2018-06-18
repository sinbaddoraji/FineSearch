using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace FineSearch
{
    public sealed partial class Form1 : Form
    {
        private Thread _searchThread;
        private readonly System.Windows.Forms.Timer _countItems = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            _countItems.Tick += (sender, args) =>
            {
                var itemCountLength = treeView1.Nodes.Count;
                if (itemCountLength > 0)
                {
                    itemCount.Text = itemCountLength == 1 ? @"1 item" : $@"{itemCountLength} items";
                }
                else
                {
                    itemCount.Text = string.Empty;
                }
            };
            _countItems.Start();
        }

        private void Search(string file)
        {
            //get directories in c
            //search c for the file
            //if not in c then check first and all in it

            var startDir = searchStart.Text;

            _searchThread = new Thread(() => { Lookup(file, startDir, fileSearchOption.Checked); })
            {
                Name = "Searching",
                Priority = ThreadPriority.AboveNormal
            };
            _searchThread.Start();
        }

        private void Lookup(string file, string dir, bool fileSearch)
        {
            try
            {
                string[] filesInC;

                if (fileSearch)
                    filesInC = useRegex.Checked
                        ? Directory.GetFiles(dir).Where(x => new Regex(file).IsMatch(new FileInfo(x).Name))
                            .ToArray()
                        : Directory.GetFiles(dir).Where(x => x.ToLower().Contains(file.ToLower())).ToArray();
                else
                    filesInC = useRegex.Checked
                        ? Directory.GetDirectories(dir)
                            .Where(x => new Regex(file).IsMatch(new FileInfo(x).Name)).ToArray()
                        : Directory.GetDirectories(dir).Where(x => x.ToLower().Contains(file.ToLower())).ToArray();

                try
                {
                    treeView1.Invoke(new MethodInvoker(delegate
                    {
                        var z = 0;
                        while (z < filesInC.Length - 1)
                        {
                            treeView1.Nodes.Add(new TreeNode(filesInC[z]));
                            z++;
                        }
                    }));
                }
                catch
                {
                    // ignored
                }

                var rootDirectories = Directory.GetDirectories(dir);

                for (var i = 0; i < rootDirectories.Length - 1; i++)
                {
                    var folder = rootDirectories[i];

                    var checkDirectories = new Task(() =>
                     {
                         try
                         {
                             string[] files;
                             if (fileSearch)
                             {
                                 files = useRegex.Checked
                                     ? Directory.GetFiles(folder)
                                         .Where(x => new Regex(file).IsMatch(new FileInfo(x).Name)).ToArray()
                                     : Directory.GetFiles(folder).Where(x => x.ToLower().Contains(file.ToLower())).ToArray();
                             }
                             else
                             {
                                 files = useRegex.Checked
                                     ? Directory.GetDirectories(folder)
                                         .Where(x => new Regex(file).IsMatch(new FileInfo(x).Name)).ToArray()
                                     : Directory.GetDirectories(folder).Where(x => x.ToLower().Contains(file.ToLower())).ToArray();
                             }

                             try
                             {
                                 var addItems = new Task(() =>
                                 {
                                     treeView1.Invoke(new MethodInvoker(delegate
                                     {
                                         var z = 0;
                                         while (z < files.Length)
                                         {
                                             treeView1.Nodes.Add(new TreeNode(files[z]));
                                             z++;
                                         }
                                     }));
                                 });
                                 addItems.RunSynchronously();
                                 
                             }
                             catch
                             {
                                     // ignored
                             }

                             var checkSubDir = new Task(() => { Lookup(file, folder, fileSearch); });
                             checkSubDir.RunSynchronously();
                         }
                         catch
                         {
                                 // ignored
                             }
                     });

                    checkDirectories.RunSynchronously();
                    
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); StopThread(); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Search(searchBox.Text);
            searchBox.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StopThread();
        }

        private void TreeView1_DoubleClick(object sender, EventArgs e)
        {
            var choice = new CustomMessageBox().ShowDialog();
            if (choice == DialogResult.Yes)
                Process.Start(treeView1.SelectedNode.Text);
            else if (choice == DialogResult.No)
            {
                Process.Start(Directory.GetParent(treeView1.SelectedNode.Text).FullName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            searchStart.Items.Clear();
            searchStart.Items.AddRange(GetLogicalDrives());
            searchStart.Text = GetLogicalDrives()[0];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThread();
        }

        private void StopThread()
        {
            try
            {
                _searchThread.Abort();
                searchBox.Enabled = true;
            }
            catch
            {
                // ignored
            }
        }

        private void searchStart_DrawItem(object sender, DrawItemEventArgs e)
        {
            var text = ((ComboBox)sender).Items[e.Index].ToString();
            e.DrawBackground();
            e.Graphics.DrawString(text, searchBox.Font, Brushes.White, e.Bounds.X, e.Bounds.Y);
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            Search(searchBox.Text);
            searchBox.Enabled = false;
        }

        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            searchStart.Items.Add(folderBrowserDialog1.SelectedPath);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        
    }
}