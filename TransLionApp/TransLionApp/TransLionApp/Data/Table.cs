using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TransLionApp.Data
{
    public class Table
    {
        readonly SQLiteAsyncConnection database;
        public Table(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
            database.CreateTableAsync<Person>().Wait();
        }
        public Task<List<Person>> GetUsersAsync()
        {
            return database.Table<Person>().ToListAsync();
        }
        public Task<int> SaveUserAsync(Person person)
        {
            return database.InsertAsync(person);
        }
        public Task<Person> GetUserAsync(int id)
        {
            return database.GetAsync<Person>(id);
        }
        public Task<int> DeleteUserAsync(int id)
        {
            return database.DeleteAsync<Person>(id);
        }
        public Task<int> DeleteAll()
        {
            return database.DeleteAllAsync<Person>();
        }
        public Task<int> UpdateAsync(Person person)
        {
            return database.UpdateAsync(person);
        }
    }
}
