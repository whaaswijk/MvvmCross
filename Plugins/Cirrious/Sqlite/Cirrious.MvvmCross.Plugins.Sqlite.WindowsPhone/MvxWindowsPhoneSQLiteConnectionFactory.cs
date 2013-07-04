// MvxWindowsPhoneSQLiteConnectionFactory.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using SQLite;
using System.IO;
using Windows.Storage;

namespace Cirrious.MvvmCross.Plugins.Sqlite.WindowsPhone
{
    public class MvxWindowsPhoneSQLiteConnectionFactory : ISQLiteConnectionFactory
    {
        public ISQLiteConnection Create(string address)
        {
            // In WP8 we have to specify the full path to where we want to save
            // the file. Note that this currently always creates the database
            // in a subfolder of the local application storage.
            return new SQLiteConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, address));
        }
    }
}