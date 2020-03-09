using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronizedPasswordChanger
{
    public class PasswordChanger
    {
        public async Task<(bool result, string message)> CheckUserPassword(string domain, string username, string password)
        {
            return await Task.Run(() => DoCheckUserPassword(domain, username, password));
        }

        private (bool result, string message) DoCheckUserPassword(string domain, string username, string password)
        {
            bool result = false;
            string message = null;
            try
            {
                DirectoryEntry entry = new DirectoryEntry(
                    "LDAP://" + domain,
                    username,
                    password);
                object nativeObject = entry.NativeObject;
                result = true;
            }
            catch (DirectoryServicesCOMException ex)
            {
                message = ex.Message;
            }
            return (result, message);
        }

        public async Task<(bool result, string message)> ChangeUserPassword(string domain, string username, string oldPassword, string newPassword)
        {
            return await Task.Run(() => DoChangeUserPassword(domain, username, oldPassword, newPassword));
        }

        private (bool result, string message) DoChangeUserPassword(string domain, string username, string oldPassword, string newPassword)
        {
            bool result = false;
            string message = null;
            DirectoryEntry entry = new DirectoryEntry(
                "LDAP://" + domain,
                username,
                oldPassword);
            if (entry != null)

            {
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + username + ")";
                SearchResult searchResult = search.FindOne();
                if (searchResult != null)
                {
                    DirectoryEntry userEntry = searchResult.GetDirectoryEntry();
                    if (userEntry != null)
                    {
                        userEntry.Invoke("ChangePassword", new object[] { oldPassword, newPassword });
                        userEntry.CommitChanges();
                    }
                }
            }

            return (result, message);
        }
    }
}
