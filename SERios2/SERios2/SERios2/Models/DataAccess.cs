using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;

namespace SERios2
{
    class DataAccess : IDisposable
    {
        public SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DirectorioDB, "Note.db3"));
            connection.CreateTable<Note>();
        }

        public void InsertNote(Note note)
        {
            connection.Insert(note);
        }

        public Note GetNote(int NotesId)
        {
            return connection.Table<Note>().FirstOrDefault(c => c.NotesId == NotesId);
        }

        public List<Note> GetNotes()
        {
            return connection.Table<Note>().ToList();

        }


        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
