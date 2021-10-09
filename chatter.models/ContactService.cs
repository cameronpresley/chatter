using System;
using System.Collections.Generic;

namespace chatter.models
{
    public interface ContactService
    {
        public IEnumerable<Contact>RetrieveContacts();
    }
}