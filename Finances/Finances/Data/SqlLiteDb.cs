using Finances.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finances.Data
{
    public class SqlLiteDb
    {
        private static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        private static SQLiteAsyncConnection Database => lazyInitializer.Value;

        private static bool initialized = false;

        public SqlLiteDb()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        private async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Account).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Account)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }

        public Task<List<Account>> GetAccountsAsync()
        {
            return Database.Table<Account>().ToListAsync();
        }

        public Task<Account> GetAccountAsync(int id)
        {
            return Database.Table<Account>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAccountAsync(Account account)
        {
            if (account.ID != 0)
            {
                return Database.UpdateAsync(account);
            }
            else
            {
                return Database.InsertAsync(account);
            }
        }

        public Task<int> DeleteAccountAsync(Account account)
        {
            return Database.DeleteAsync(account);
        }
    }
}
