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
        public static TValue GetOrDefaultValue<TKey,TValue>(this Dictionary<TKey,TValue> source,TKey key) where TValue : class, new()
        {
            source.TryGetValue(key, out var value);
            if (EqualityComparer<TValue>.Default.Equals(value, default(TValue)))
            {
               return default(TValue);
            }

            return value;
        }

        public static void AddToList<TKey, TValue, TCollectionItem>(this Dictionary<TKey, TValue> source, TKey key, TCollectionItem item) where TValue : class, ICollection<TCollectionItem>, new()
        {
            var collection = source.GetOrDefaultValue(key) ?? new TValue();
            collection.Add(item);
            source[key] = collection;
        }


        public static void AddManyToList<TKey, TValue, TCollectionItem>(this Dictionary<TKey, TValue> source, TKey key, ICollection<TCollectionItem> items)
            where TValue : class , ICollection<TCollectionItem>, new()
        {
            var collection = source.GetOrDefaultValue(key) ?? new TValue();
            foreach (var item in items)
            {
                collection.Add(item);
            }
            source[key] = collection;
        }
    }
}
