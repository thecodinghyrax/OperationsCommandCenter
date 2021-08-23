using ModelClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OperationsCommandCenter
{
    public partial class CommandMainForm : Form
    {
        List<FilesModel> fileInfo = new List<FilesModel>();
        public CommandMainForm()
        {
            InitializeComponent();
            SqliteDataAccess.ResetTable("config");
        }

        private void ShowSearchUI()
        {
            listbox_result.Show();
            btn_openDoc.Show();
            btn_openFolder.Show();
        }

        private void HideSearchUI()
        {
            listbox_result.Hide();
            btn_openDoc.Hide();
            btn_openFolder.Hide();
        }

        private void DisplayResults()
        {
            ShowSearchUI();
            listbox_result.DataSource = null;
            listbox_result.DataSource = fileInfo;
            listbox_result.DisplayMember = "filePath";
        }

        private void LoadSearchResult()
        {
            fileInfo = SqliteDataAccess.FindSearchFileInfo(textB_search.Text);
            //files.Add(new FilesModel { Id = 3, fileName = "bkp4", filePath = @"c:\users\drewc\documents\bkp4.docx" });
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ShowSearchUI();
            LoadSearchResult();
            DisplayResults();

        }

        private void btn_openDoc_Click(object sender, EventArgs e)
        {
            
            var searchFileName = listbox_result.SelectedItem;
            try
            {
            Process.Start(searchFileName.ToString());
            } catch (Exception ex)
            {
                //skip
            }
        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            string selectedResult = listbox_result.GetItemText(listbox_result.SelectedValue);
            try
            {
            Process.Start(Path.GetDirectoryName(selectedResult));
            } catch (Exception exc)
            {
                //skip
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
   
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\Users\drewc\documents");
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Users\drewc");
            List<DirectoryInfo> rootDirs = new List<DirectoryInfo>() { dir1, dir2 };

            RecursiveFileSearch search = new RecursiveFileSearch(rootDirs);
            search.SavePathsToDB();
            MessageBox.Show("The files list has been updated!", "Update successful", MessageBoxButtons.OK);
        }

        private void CommandMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings();
            settingsForm.Show();

        }
    }
}
