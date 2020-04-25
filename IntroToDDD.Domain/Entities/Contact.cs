using System;

namespace IntroToDDD.Domain.Entitites
{
    public class Contact
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public DateTime Birthday { get; set; }
    }
}
