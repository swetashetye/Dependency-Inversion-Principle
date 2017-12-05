﻿
namespace ASPPattern.Chap2.Service
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data);

        T Retrieve<T>(string key);

    }
}
