﻿using TaskAPI.Data.Entities;

namespace TaskAPI.Data.SqlServer.Mappings
{
    public class UserMap : VersionedClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId);
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.UserName).Not.Nullable();
        }
    }
}
