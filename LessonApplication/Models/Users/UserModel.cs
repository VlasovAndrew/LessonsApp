using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonApplication.Models.Users
{
    public class UserModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public List<string> Phones { get; set; }

    }
}
