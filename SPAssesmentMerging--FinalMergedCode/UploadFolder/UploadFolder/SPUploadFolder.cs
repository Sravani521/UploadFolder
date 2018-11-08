using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using DAL;
using DAL.Repository;

namespace UploadFolder
{
    class SPUploadFolder
    {
       public  string FolderPAthForPermission="";
        Permissions SpPermissions = new Permissions();
        //***********************************Upload Doccument From the directory******************************// 

        public  void UploadDocument(ClientContext clientContext, string sourceFilePath, string serverRelativeDestinationPath)
        {
            try
            {
                using (var FileStream = new FileStream(sourceFilePath, FileMode.Open))
                {
                    var fileInfo = new FileInfo(sourceFilePath);
                    Microsoft.SharePoint.Client.File.SaveBinaryDirect(clientContext, serverRelativeDestinationPath, FileStream, true);
                }
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
        }

        //*********************************** add subfolder in doccument library and create SubFolder From the directory******************************// 


        public  void UploadFolder(ClientContext clientContext, System.IO.DirectoryInfo folderInfo, Folder folder,string destinationLigraryTitle)
        {
            System.IO.FileInfo[] Files = null;
            System.IO.DirectoryInfo[] SubDirs = null;

            try
            {
                Files = folderInfo.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
            if (Files != null)
            {
                foreach (System.IO.FileInfo Fi in Files)
                {
                    Console.WriteLine(Fi.FullName);
                    clientContext.Load(folder);
                    clientContext.ExecuteQuery();
                    UploadDocument(clientContext, Fi.FullName, folder.ServerRelativeUrl + "/" + Fi.Name);
                }
                SubDirs = folderInfo.GetDirectories();
                foreach (System.IO.DirectoryInfo DirectoriInfo in SubDirs)
                {
                    Folder subFolder = folder.Folders.Add(DirectoriInfo.Name);
                    clientContext.ExecuteQuery();
                    try
                    {
                     //_______________Add Permissions for the folder______________________//
                        SpPermissions.GetPermmssion(clientContext, subFolder, Path.GetFullPath(DirectoriInfo.ToString()), destinationLigraryTitle);
                    }
                    catch (Exception ex)
                    {
                        ErrrorLog.ErrorlogWrite(ex);
                    }
                    UploadFolder(clientContext, DirectoriInfo, subFolder, destinationLigraryTitle);
                }
            }
        }

     //***********************************add  folder in doccument library if rootfolder path  have one folder ******************************// 

        public void UploadFoldersRecursively(ClientContext clientContext, string sourceFolder, string destinationLigraryTitle)
        {
            try
            {
                Web web = clientContext.Web;
                var query = clientContext.LoadQuery(web.Lists.Where(p => p.Title == destinationLigraryTitle));
                clientContext.ExecuteQuery();
                List documentsLibrary = query.FirstOrDefault();
                var folder = documentsLibrary.RootFolder;
                System.IO.DirectoryInfo DirectoriInfo = new System.IO.DirectoryInfo(sourceFolder);
                clientContext.Load(documentsLibrary.RootFolder);
                clientContext.ExecuteQuery();
                folder = documentsLibrary.RootFolder.Folders.Add(DirectoriInfo.Name);
                clientContext.ExecuteQuery();
                //_______________Add Permissions for the folder______________________//
                SpPermissions.GetPermmssion(clientContext, folder, sourceFolder, destinationLigraryTitle);
                
                UploadFolder(clientContext, DirectoriInfo, folder, destinationLigraryTitle);

            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
        }

  //***********************************add folders in document library if rootfolder path has more than more than one folder******************************// 

        public  void CreateFolder(ClientContext clientContext, string path, string destinationLigraryTitle)
        {
            try
            {
                string[] splitpath = path.Split(Convert.ToChar(92));
                Web web = clientContext.Web;
                var query = clientContext.LoadQuery(web.Lists.Where(p => p.Title == destinationLigraryTitle));
                clientContext.ExecuteQuery();
                List documentsLibrary = query.FirstOrDefault();
                clientContext.Load(documentsLibrary.RootFolder);
                var folder = documentsLibrary.RootFolder;
                clientContext.ExecuteQuery();
                folder = documentsLibrary.RootFolder.Folders.Add(splitpath[1]);
                clientContext.ExecuteQuery();
                FolderPAthForPermission += splitpath[0]+"\\"+ splitpath[1];

                //_______________Add Permissions for the folder______________________//
                SpPermissions.GetPermmssion(clientContext, folder, FolderPAthForPermission, destinationLigraryTitle);
                if (splitpath.Length >= 2)
                {
                    CreateSubFolder(clientContext, path, 2, splitpath, folder, destinationLigraryTitle);
                }
                else
                {
                    System.IO.DirectoryInfo DirectoriInfo = new System.IO.DirectoryInfo(path);
                    UploadFolder(clientContext, DirectoriInfo, folder, destinationLigraryTitle);
                }
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
        }

        //***********************************add Subfolders in document library if rootfolder path has more than more than one folder******************************// 

        public  void CreateSubFolder(ClientContext clientContext, string path, int i, string[] SubFolder, Folder folder,string destinationLigraryTitle)
        {
            
            int cnt = i;
            cnt++;
            try
            {
                Folder subFolder = folder.Folders.Add(SubFolder[i]);
                clientContext.ExecuteQuery();
                FolderPAthForPermission += "\\" + SubFolder[i];
                //_______________Add Permissions for the folder______________________//
                SpPermissions.GetPermmssion(clientContext, folder, path, destinationLigraryTitle);
                if (cnt < SubFolder.Length)
                {
                    CreateSubFolder(clientContext, path, cnt, SubFolder, subFolder, destinationLigraryTitle);
                }
                else
                {
                    System.IO.DirectoryInfo DirectoriInfo = new System.IO.DirectoryInfo(path);
                    UploadFolder(clientContext, DirectoriInfo, subFolder, destinationLigraryTitle);
                }
            }
            catch (Exception ex)
            {
                ErrrorLog.ErrorlogWrite(ex);
            }
        }

    }
}

