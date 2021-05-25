using System;
using System.Collections.Generic;
using SQLite;

namespace SQL.Config
{
    public class NotesRepository
    {
        SQLiteConnection db;
        static object locker = new object();
        public NotesRepository(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Note>();
        }
        public IEnumerable<Note> GetItems()
        {
            lock (locker)
            {
                return db.Table<Note>().ToList();
            }
        }
        public Note GetItem(int id)
        {
            lock (locker)
            {
                return db.Get<Note>(id);
            }
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return db.Delete<Note>(id);
            }
        }
        public void AddItem(Note item)
        {
            lock (locker)
            {
                db.Insert(item);
            }
        }
        public int UpdateItem(Note item)
        {
            db.Update(item);
            return item.Id;
        }
    }
}
