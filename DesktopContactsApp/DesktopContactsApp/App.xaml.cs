﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       public static string databaseName = "Contacts.db";
       public static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
       public static string databasePath = System.IO.Path.Combine(folderpath, databaseName);
    }
}
