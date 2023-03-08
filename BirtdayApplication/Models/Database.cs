using System.Collections.Generic;

namespace BirtdayApplication.Models
{
    public static class Database
    {
        private static Dictionary<string, InviteModel> _liste;

        static Database()
        {
            _liste = new Dictionary<string, InviteModel> ();
            
            _liste.Add("Hasan",new InviteModel
            {
                Name = "Hasan",
                Mail = "hasan@gmail.com",
                State = true,
            });
            _liste.Add("Mehmet",new InviteModel
            {
                Name = "Mehmet",
                Mail = "Mehmet@gmail.com",
                State = false,
            });
            _liste.Add("Ayşe",new InviteModel
            {
                Name = "Ayşe",
                Mail = "Ayşe@gmail.com",
                State = true,
            });
        }
        public static void Add(InviteModel model) 
        { 
            string key = model.Name.ToLower();
            if(_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<InviteModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}
