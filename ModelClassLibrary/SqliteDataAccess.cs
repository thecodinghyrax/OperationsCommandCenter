using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace ModelClassLibrary
{
    public class SqliteDataAccess
    {

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        public static List<FilesModel> FindAllFileInfo()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                var results = cnn.Query<FilesModel>("Select * From FileInfo").ToList();
                return results;
            }
        }


        public static List<FilesModel> FindSearchFileInfo(string searchFileName)
        {
            if (searchFileName.Length < 3 && searchFileName != null)
            {
                List<FilesModel> results = new List<FilesModel>();
                results.Add(new FilesModel { fileName = "", filePath = "The search is too short. Please use more than two letters!" });
                return results;
            }

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                var results = cnn.Query<FilesModel>("Select * From FileInfo WHERE fileName LIKE '%" + searchFileName + "%'").ToList();
                    if (results.Count < 1)
                    {
                        results.Add(new FilesModel { fileName = "", filePath = "No results were founnd!" });
                        return results;
                    }
                    return results;             
            }
        }


        public static void SaveFileInfo(FilesModel fileInfo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                try
                {

                cnn.Execute("INSERT INTO FileInfo (fileName, filePath) values (@fileName, @filePath)", fileInfo);
                }catch (Exception e)
                {
                    //Skip
                }
            }
        }


    public static void ResetTable(string tableName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                switch (tableName)
                {
                    case "fileInfo":
                        cnn.Execute("DROP TABLE IF EXISTS " + tableName);
                        cnn.Execute("CREATE TABLE IF NOT EXISTS " + tableName + " (\"id\" INTEGER, \"fileName\"" +
                            " TEXT NOT NULL UNIQUE, \"filePath\" TEXT NOT NULL, PRIMARY KEY(\"id\" AUTOINCREMENT))");
                        break;
                    case "config":
                        cnn.Execute("DROP TABLE IF EXISTS " + tableName);
                        cnn.Execute("CREATE TABLE IF NOT EXISTS " + tableName + " (\"id\" INTEGER, \"settingName\"" +
                            " TEXT NOT NULL, \"settingText\" TEXT NOT NULL, PRIMARY KEY(\"id\" AUTOINCREMENT))");
                        //cnn.Execute("INSERT INTO " + tableName + " (\"id\", \"settingName\", \"settingText\") VALUES (NULL, \"pathSAP\", \"Not Set\"");
                        //cnn.Execute("INSERT INTO " + tableName + " (\"id\", \"settingName\", \"settingText\") VALUES (NULL, \"pathWin\", \"Not Set\"");
                        break;

                    default:
                        break;
                }
            }

        }
        //https://youtu.be/HYrXogLj7vg?t=1309
        // Testing video link
        public static ConfigModel FindSetting(string settingName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                var settingObj = cnn.QuerySingle<ConfigModel>("Select * From config WHERE settingName = '" + settingName + "'");
                return settingObj;

            }
        }

    }

}
