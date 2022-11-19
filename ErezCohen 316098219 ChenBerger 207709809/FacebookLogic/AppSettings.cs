﻿using System.Collections.Generic;
using System.IO;

namespace FacebookLogic
{
    public class AppSettings
    {
        private string m_AppID;
        private List<string> m_Permissions;
        private const string k_FullLastAccessTokenFilePath = "";

        public AppSettings()
        {
            m_Permissions = new List<string>();
        }

        public string AppID { get => m_AppID; set => m_AppID = value; }
        public List<string> Permissions { get => m_Permissions; set => m_Permissions = value; }

        public void AddPermission(string i_Permission)
        {
            if (m_Permissions == null)
            {
                m_Permissions = new List<string>();
            }

            m_Permissions.Add(i_Permission);
        }
        public void SaveCurrentAccessTokenToFile(string i_CurrentAccessToken)
        {
            using (StreamWriter streamWriter = new StreamWriter(k_FullLastAccessTokenFilePath))
            {
                streamWriter.WriteLine(i_CurrentAccessToken);
            }
        }
        public void loadAccessTokenFromFile()
        {

        }
    }
}