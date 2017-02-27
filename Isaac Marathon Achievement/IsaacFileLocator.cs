using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Win32;

namespace Isaac_Achievement_Unlocker
{
    class IsaacFileLocator
    {
        public List<string> SaveFileUsers = new List<string>();
        public List<SaveFile> SaveFileList = new List<SaveFile> { new SaveFile(), new SaveFile(), new SaveFile() };
        private readonly string MyDocumentsName = System.Security.Principal.WindowsIdentity.GetCurrent().Name + " - My Document Saves";
        private readonly string IsaacFileSaveLocation = @"\My Games\Binding of Isaac Afterbirth+";
        private string DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string SaveLocation { get; set; }
        private string SteamIsaacFileSaveLocation = @"\250900\remote";
        private Dictionary<string, string> SteamUserProfiles { get; set; }
        private List<string> saveFileNames = new List<string> { "abp_persistentgamedata1.dat",
                                                                "abp_persistentgamedata2.dat",
                                                                "abp_persistentgamedata3.dat" };

        public IsaacFileLocator()
        {
            determineSaveLocations();
        }

        public string getFilePath(string slot)
        {
            int slotNumber = Int32.Parse(System.Text.RegularExpressions.Regex.Match(slot, @"\d+").Value) - 1;
            return SaveFileList[slotNumber].Location;
        }

        public List<string> getSaveSlots(string user)
        {
            //Console.Clear();
            SaveFileList = new List<SaveFile> { new SaveFile(), new SaveFile(), new SaveFile() }; //clear out SaveFileList
            if (user.Equals(MyDocumentsName))
            {
                checkForSavesInDirectory(DocumentsPath + IsaacFileSaveLocation);
            }
            else
            {
                checkForSavesInDirectory(SteamUserProfiles[user] + SteamIsaacFileSaveLocation);
            }
            List<string> results = new List<string>();
            for(int i=0; i<3; i++)
            {
                if (SaveFileList[i].Enabled)
                {
                    int slot = i + 1;
                    results.Add("Slot " + slot);
                }
            }
            return results;
        }

        private void determineSaveLocations()
        {
            if( checkForSaveDirectoryInDocuments() )
            {
                if (checkForSavesInDirectory(DocumentsPath + IsaacFileSaveLocation) )
                {
                    SaveFileUsers.Add(MyDocumentsName);
                }
            }
            if (checkForSaveInProgramFiles())
            {

            }
        }

        private bool checkForSaveDirectoryInDocuments()
        {
            return Directory.Exists(DocumentsPath + IsaacFileSaveLocation);
        }

        private bool checkForSaveInProgramFiles()
        {
            bool result = false;
            SteamUserProfiles = GetSteamProfiles();
            checkForBOIDirAndRemoveNonBOIUsers();
            if(SteamUserProfiles.Count > 0)
            {
                return true;
            }
            return result;
        }

        private bool checkForSavesInDirectory(string path)
        {
            bool result = false;
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileNamePath in fileEntries)
            {
                string fileName = Path.GetFileName(fileNamePath);
                if ( saveFileNames.Contains(fileName) )
                {
                    Console.WriteLine("Save Found Here: " + fileName);
                    int saveFile = Int32.Parse(System.Text.RegularExpressions.Regex.Match(fileName, @"\d+").Value) -1;
                    Console.WriteLine("Save Slot: " + saveFile);
                    SaveFileList[saveFile].Enabled = true;
                    SaveFileList[saveFile].Location = fileNamePath;
                    result = true;
                }
            }
            foreach(SaveFile sf in SaveFileList)
            {
                Console.WriteLine("Enabled: " + sf.Enabled);
                Console.WriteLine("Location: " + sf.Location);
            }
            return result;
        }

        private void checkForBOIDirAndRemoveNonBOIUsers()
        {
            List<string> keysToDelete = new List<string>();
            foreach (KeyValuePair<string, string> entry in SteamUserProfiles)
            {
                if (!Directory.Exists(entry.Value + SteamIsaacFileSaveLocation))
                {
                    keysToDelete.Add(entry.Key);
                }
                else
                {
                    if( checkForSavesInDirectory(entry.Value + SteamIsaacFileSaveLocation) )
                    {
                        SaveFileUsers.Add(entry.Key);
                    }
                    else
                    {
                        keysToDelete.Add(entry.Key);
                    }
                }
            }
            foreach (string key in keysToDelete)
            {
                SteamUserProfiles.Remove(key);
            }
        }

        private Dictionary<string, string> GetSteamProfiles()
        {
            string steampath;
            try
            {
                steampath = (string)Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam").GetValue("SteamPath") + "//userdata";
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("Unable to locate steam path via registry.", e);
            }

            if (!Directory.Exists(steampath))
            {
                throw new FileNotFoundException("Unable to locate steam path via registry as found location does not exist.");
            }

            Dictionary<string, string> LookupTable = new Dictionary<string, string>();

            try
            {
                foreach (string userdir in Directory.GetDirectories(steampath))
                {
                    if (!File.Exists(userdir + "//Config//localconfig.vdf"))
                        continue;
                    string quoted = string.Format("\"{0}\"", userdir.Substring(userdir.LastIndexOf('\\') + 1));
                    using (StreamReader reader = new StreamReader(userdir + "//Config//localconfig.vdf"))
                    {
                        while (!reader.ReadLine().Trim().EndsWith(quoted)) { }
                        reader.ReadLine();
                        string line = reader.ReadLine().Trim();
                        while (!line.EndsWith("}"))
                        {
                            if (line.StartsWith("\"Name\"", StringComparison.InvariantCultureIgnoreCase))
                            {
                                line = line.Substring(6).Trim();
                                line = line.Substring(1, line.Length - 2);
                                LookupTable.Add(line, new DirectoryInfo(steampath + userdir.Substring(userdir.LastIndexOf('\\'))).FullName);
                                reader.Close();
                                break;
                            }
                            line = reader.ReadLine().Trim();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Unexpected error retrieving steam user data.", e);
            }

            return LookupTable;
        }

    }
}
