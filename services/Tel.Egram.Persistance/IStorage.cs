﻿namespace Tel.Egram.Persistance
{
    public interface IStorage
    {
        string BaseDirectory { get; }

        string LogDirectory { get; }

        string TdLibDirectory { get; }
        
        string CacheDirectory { get; }
        
        string AvatarDirectory { get; }
        
        string DatabaseFile { get; }
    }
}