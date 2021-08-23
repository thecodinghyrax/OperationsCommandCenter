using ModelClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;

public class RecursiveFileSearch
{
    private List<DirectoryInfo> searchDirs;
    private string[] FILETYPES;
    private List<string> filesFound = new List<string>();

    public RecursiveFileSearch(List<DirectoryInfo> rootDirs){

        searchDirs = rootDirs;
        FILETYPES = new string[]{ "*.txt", "*.doc" };
    }
        
    public void SavePathsToDB()
    {
        SqliteDataAccess.ResetTable("fileInfo");
        updateFilesFound(searchDirs);
        foreach (FilesModel filePath in GetModelsFromFilesFound())
        {
            
            SqliteDataAccess.SaveFileInfo(filePath);
        }
    }

    private void updateFilesFound(List<DirectoryInfo> roots)
    {
        foreach (DirectoryInfo root in roots)
        {
            foreach (string fileType in FILETYPES)
            {
                WalkDirectoryTree(root, fileType);
            }
        }
    }
   private List<FilesModel> GetModelsFromFilesFound()
    {
        List<FilesModel> results = new List<FilesModel>();
        foreach(string filePath in filesFound)
        {
            string[] splitFilePath = filePath.Split('\\');
            string fileName = splitFilePath[splitFilePath.Length - 1];
            results.Add(new FilesModel { fileName = fileName, filePath = filePath });
            //files.Add(new FilesModel { Id = 1, fileName = "bkp", filePath = @"c:\users\drewc\documents\bkp.docx" });
        }

        return results;
    }

    private void WalkDirectoryTree(DirectoryInfo root, string fileType)
    {
        FileInfo[] files = null;
        DirectoryInfo[] subDirs = null;
    
        try
            {
                files = root.GetFiles(fileType);
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
        catch (Exception e)
            {
                //treeResults.Add("Permision_Error");
            }

        if (files != null)
        {
            foreach (FileInfo fi in files)
            {
                filesFound.Add(fi.FullName);
            }
            subDirs = root.GetDirectories();

            foreach (DirectoryInfo dirInfo in subDirs)
            {
                // Resursive call for each subdirectory.
                WalkDirectoryTree(dirInfo, fileType);
            }
        }
         
     }

 }