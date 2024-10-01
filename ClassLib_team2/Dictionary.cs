using System;
using System.Collections;
using System.Collections.Generic;

public class ExtendedDictionaryElement<T, U, V>
{
    public T Key { get; set; }
    public U FirstValue { get; set; }
    public V SecondValue { get; set; }

    public ExtendedDictionaryElement(T key, U firstValue, V secondValue)
    {
        Key = key;
        FirstValue = firstValue;
        SecondValue = secondValue;
    }

    public override string ToString()
    {
        return $"Key: {Key}, First Value: {FirstValue}, Second Value: {SecondValue}";
    }
}

public class ExtendedDictionary<T, U, V> : IEnumerable<ExtendedDictionaryElement<T, U, V>>
{
    private List<ExtendedDictionaryElement<T, U, V>> elements = new List<ExtendedDictionaryElement<T, U, V>>();

    public void Add(T key, U firstValue, V secondValue)
    {
        if (ContainsKey(key))
        {
            throw new ArgumentException($"Element with key {key} already exists.");
        }
        elements.Add(new ExtendedDictionaryElement<T, U, V>(key, firstValue, secondValue));
    }

    public bool Remove(T key)
    {
        var index = elements.FindIndex(e => EqualityComparer<T>.Default.Equals(e.Key, key));
        if (index != null)
        {
            elements.RemoveAt(index);
            return true;
        }
        return false;
    }

    public bool ContainsKey(T key)
    {
        return elements.Exists(e => EqualityComparer<T>.Default.Equals(e.Key, key));
    }

    public bool ContainsValue(U firstValue, V secondValue)
    {
        return elements.Exists(e => EqualityComparer<U>.Default.Equals(e.FirstValue, firstValue) &&
                                    EqualityComparer<V>.Default.Equals(e.SecondValue, secondValue));
    }

    public ExtendedDictionaryElement<T, U, V> this[T key]
    {
        get
        {
            var element = elements.Find(e => EqualityComparer<T>.Default.Equals(e.Key, key));
            if (element == null)
            {
                throw new KeyNotFoundException($"Key {key} not found.");
            }
            return element;
        }
    }

    public int Count => elements.Count;

    public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
    {
        return elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
