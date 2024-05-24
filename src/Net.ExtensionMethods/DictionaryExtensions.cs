using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Net.ExtensionMethods
{
    public static class DictionaryExtensions
    {
        public static TValue GetOrDefault<TKey,TValue>(this Dictionary<TKey,TValue> dictionary,TKey key) where TValue : class, new()
        {
            if (!dictionary.TryGetValue(key, out var collection))
            {
                collection = new TValue();
            }

            return collection;
        }

        public static void AddToList<TKey, TValue, TCollectionItem>(this Dictionary<TKey, TValue> dictionary, TKey key, TCollectionItem item) where TValue : class, ICollection<TCollectionItem>, new()
        {
            var collection = dictionary.GetOrDefault(key);
            collection.Add(item);
            dictionary[key] = collection;
        }


        public static void AddManyToList<TKey, TValue, TCollectionItem>(this Dictionary<TKey, TValue> dictionary, TKey key, ICollection<TCollectionItem> items)
            where TValue : class , ICollection<TCollectionItem>, new()
        {
            var collection = dictionary.GetOrDefault(key);
            foreach (var item in items)
            {
                collection.Add(item);
            }
           dictionary[key] = collection;
        }
    }
}
